using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using misClases;
using Mensajes;
namespace SN
{
   
    public partial class frmJuego : Form
    {
        private bool btnDown;
        Pen lapiz;
        Graphics grafico,grafico2;
        clsUsuario usuario;
        //frmPrueba prueba;
        clsComunicacion comunicacion;
        EventWaitHandle _EsperarHilo = new AutoResetEvent(false),_PantallaActualizada=new AutoResetEvent(false);
        string toca = "";
        public frmJuego(clsUsuario us,clsComunicacion c)
        {
            InitializeComponent();
            lblMensaje.Visible = false;
            usuario = us;
            comunicacion = c;
            comunicacion.RespuestaPalabraEnviada += Comunicacion_RespuestaPalabraEnviada;
            comunicacion.Dibujar += Comunicacion_Dibujar;
            comunicacion.TocaDibujar += Comunicacion_TocaDibujar;
            comunicacion.IniciarPartida += Comunicacion_IniciarPartida;
            lapiz = new Pen(Color.Black,(int) nudWidth.Value);
            grafico = pnlDibujo.CreateGraphics();
            grafico2 = pnlAdivina.CreateGraphics();
          //  grafsecundario = pnlSecundarioDIbujar.CreateGraphics();
            lblNick.Text = usuario.User;
            lblPuntos.Text =Convert.ToString(usuario.Puntos);
            lbUsuarios.Items.Add(usuario.User + "     " + usuario.Puntos.ToString());

        }

        int cont;

        private void Comunicacion_IniciarPartida(MensajeIniciarPartida m)
        {
            _PantallaActualizada.Set();
            _EsperarHilo.WaitOne();
            lblMensaje.Invoke((Action)(() => lblMensaje.Visible = true));
            Thread.Sleep(2000);
            for (int i = 10; i > 0; i--)
            {
                Invoke((Action)(() =>
                {
                    lblMensaje.Text =toca+ ". La partida comenzará en:" + i;
                }));
                Thread.Sleep(1000);
            }
            lblMensaje.Invoke((Action)(() => lblMensaje.Visible = false));
            pnlDibujo.Invoke((Action)(() => pnlDibujo.Visible = true));
            cont = 60;
            timer1.Start();
        }
        private void contar()
        {

        }
        private void Comunicacion_TocaDibujar(MensajeTocaDibujar m)
        {
            _PantallaActualizada.WaitOne();
            if (usuario.User == m.Dibujante)
            {
                lblPalabra.Invoke((Action)(() => lblPalabra.Visible = true));
                groupBox1.Invoke((Action)(() => groupBox1.Visible = true ));
                lblPalabra.Invoke((Action)(()=> lblPalabra.Text = m.PalabraAdivinar));
                pnlAdivina.Invoke((Action)(()=>pnlAdivina.Visible=false));
                tbPalabra.Invoke((Action)(() => tbPalabra.Visible = false));
                toca = "Sos dibujante";
            }
            else
            {
                groupBox1.Invoke((Action)(() =>groupBox1.Visible=false));
                lblPalabra.Invoke((Action)(() =>lblPalabra.Visible=false));
                pnlDibujo.Invoke((Action)(() => pnlDibujo.Visible = false));
                pnlAdivina.Invoke((Action)(() => pnlAdivina.Visible = true));
                tbPalabra.Invoke((Action)(() => tbPalabra.Visible = true));
                toca = "Tenés que adivinar";
            }
            _EsperarHilo.Set();
        }

        private void Comunicacion_Dibujar(MensajeDibujarPuntos m)
        {
            Color colorcito = Color.FromArgb(m.ColorRGB);
            Pen lap = new Pen(colorcito,m.Grosor);
            
            //pnlDibujo.Invoke((Action)(()=>grafico.DrawLine(lap, m.CordX, m.CordY, m.CordX + 1, m.CordY)));
            pnlAdivina.Invoke((Action)(() => grafico2.DrawLine(lap, m.CordX, m.CordY, m.CordX + 1, m.CordY)));
        }



        private void Comunicacion_RespuestaPalabraEnviada(MensajeEnviarPalabra m)
        {
            if (m.Correcta)
            {
                if (m.To == usuario.User)
                {
                usuario.Puntos += m.Puntos;
                lblPuntos.Invoke((Action)(()=>lblPuntos.Text = usuario.Puntos.ToString()));
                    lblMensaje.Invoke((Action)(() =>
                    {
                        lblMensaje.Text = "Ganaste esta ronda!!";
                        lblMensaje.Visible = true;
                    }
                    ));
                }
            else
                {
                    lblMensaje.Invoke((Action)(() =>
                    {
                        lblMensaje.Text = "El ganador es" + m.To + "!";
                        lblMensaje.Visible = true;
                    }
                ));
                }
            }
            else
            {
                lbPalabrasIncorrectas.Invoke((Action)(() => { lbPalabrasIncorrectas.Items.Add(m.From + ": "+m.Palabra); }));
            }
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {

            lblPalabra.Text = comunicacion.PalabraDesignada;
            lblPalabra.Text = lblPalabra.Text.ToUpper();
           // prueba = new frmPrueba(comunicacion,this);
           // prueba.Show();

            timer1.Enabled = true;
        }

        private void pnlDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnDown = true;
                
            }
        }

        private void pnlDibujo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnDown = false;
            }
        }

        private void pnlDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            if (btnDown)
            {
                int x = e.X, y = e.Y,grosor=(int)lapiz.Width,colorRgb=lapiz.Color.ToArgb();
                grafico.DrawLine(lapiz, x, y, x+1 , y+1);
                // grafico.DrawLine(lapiz, e.X, e.Y, e.X -1, e.Y -1);
                Task.Run(()=>comunicacion.enviarDibujado(grosor,colorRgb,x,y, usuario.User));
               
            }
        }
           
       

        private void pnlNegro_Click(object sender, EventArgs e)
        {
            Panel color = (Panel)sender;
            lapiz.Color = color.BackColor;
        }
        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            lapiz.Width = (int)nudWidth.Value;
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
             if (cont != 0)
              {
               cont--;
              lblContador.Text = cont.ToString();
             }
        }

     

        private void tbPalabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            string rta = tbPalabra.Text;
            if (((int)e.KeyChar == (int)Keys.Enter))
            {
                if ((rta != "") && (rta != null))
                {
                    Task.Run(() => comunicacion.enviaRta(rta, usuario.User,cont));
                }
                tbPalabra.Clear();
            }
        }

    }
}

