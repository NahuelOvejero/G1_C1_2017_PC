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

        //recibe
        Point ?antiguo;

        //puntos para dibujar correctamente linea intermedia
        public Point current = new Point();
        public Point old = new Point();

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
            comunicacion.FinTrazo += Comunicacion_finTrazo;

            lapiz = new Pen(Color.Black,(int) nudWidth.Value);
            lapiz.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

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
            //_PantallaActualizada.Set();
            // _EsperarHilo.WaitOne();

            while (this.IsDisposed) { }

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

        MensajeTocaDibujar msj;
        string p;
        private void Comunicacion_TocaDibujar(MensajeTocaDibujar m)
        {
            msj = m;
            p = msj.PalabraAdivinar;
            // _PantallaActualizada.WaitOne();
            if (usuario.User == m.Dibujante)
            {
                lblPalabra.Invoke((Action)(() => lblPalabra.Visible = true));
                groupBox1.Invoke((Action)(() => groupBox1.Visible = true ));
                lblPalabra.Invoke((Action)(()=> lblPalabra.Text = m.PalabraAdivinar));
                lblAdivina.Invoke((Action)(() => lblAdivina.Visible = false));
                pnlAdivina.Invoke((Action)(()=>pnlAdivina.Visible=false));
                tbPalabra.Invoke((Action)(() => tbPalabra.Visible = false));
                toca = "Sos dibujante";
            }
            else
            {
                groupBox1.Invoke((Action)(() =>groupBox1.Visible=false));
                lblPalabra.Invoke((Action)(() =>lblPalabra.Visible=false));
                lblAdivina.Invoke((Action)(() =>
                {
                    lblAdivina.Visible = true;
                    lblAdivina.Text = "";
                    int longPalabra = m.PalabraAdivinar.Length;
                    for (int i = 0; i < longPalabra; i++)
                    {
                        lblAdivina.Text += " _ ";
                    }
                }
                ));
                pnlDibujo.Invoke((Action)(() => pnlDibujo.Visible = false));
                pnlAdivina.Invoke((Action)(() => pnlAdivina.Visible = true));
                tbPalabra.Invoke((Action)(() => tbPalabra.Visible = true));
                toca = "Tenés que adivinar";
            }
           // _EsperarHilo.Set();
        }

        private void Comunicacion_Dibujar(MensajeDibujarPuntos m)
        {
            if (antiguo != null)
            {
                Color colorcito = Color.FromArgb(m.ColorRGB);
                Pen lap = new Pen(colorcito, m.Grosor);
                lap.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
               //pnlDibujo.Invoke((Action)(()=>grafico.DrawLine(lap, m.CordX, m.CordY, m.CordX + 1, m.CordY)));
                pnlAdivina.Invoke((Action)(() => grafico2.DrawLine(lap, ((Point)(antiguo)).X, ((Point)(antiguo)).Y, m.CordX, m.CordY)));
                antiguo = new Point(m.CordX, m.CordY);
            }
            else {
                antiguo = new Point(m.CordX, m.CordY);
            }

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

            //timer1.Enabled = true;
            
        }

        private void pnlDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnDown = true;
            }
            old = e.Location;
            
        }

        private void pnlDibujo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnDown = false;
                comunicacion.enviarFinTrazo(usuario.User);
            }
        }

        private void pnlDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && btnDown)
            {
                current = e.Location;
                grafico.DrawLine(lapiz, old, current);
                old = current;

                int x = e.X, y = e.Y, grosor = (int)lapiz.Width, colorRgb = lapiz.Color.ToArgb();
                //grafico.DrawLine(lapiz, x, y, x + 1, y + 1);
                // grafico.DrawLine(lapiz, e.X, e.Y, e.X -1, e.Y -1);
                comunicacion.enviarDibujado(grosor, colorRgb, x, y, usuario.User);
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //if (cont != 0)
            //{
            //    cont--;
            //    lblContador.Text = cont.ToString();
            //}

            
            int a = 0;

            if (cont != 0)
            {
                cont--;
                lblContador.Text = cont.ToString();
                if (cont == 50 && a <= p.Length)
                {
                    lblAdivina.Text = "";
                    lblAdivina.Text = p[0].ToString().ToUpper();
                    for (int i = 1; i < p.Length; i++)
                    {
                        lblAdivina.Text += " _ ";
                    }
                }

                if (cont == 45 && a <= p.Length)
                {
                    lblAdivina.Text = "";
                    lblAdivina.Text = p[0].ToString().ToUpper();
                    for (int i = 1; i < p.Length - 1; i++)
                    {
                        lblAdivina.Text += " _ ";
                    }
                    lblAdivina.Text += p[p.Length - 1].ToString().ToUpper();
                }
                a++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbPalabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            string rta = tbPalabra.Text;
            if (((int)e.KeyChar == (int)Keys.Enter))
            {
                if ((rta != "") && (rta != null))
                {
                    comunicacion.enviaRta(rta, usuario.User, cont);
                }
                tbPalabra.Clear();
            }
        }

        public void Comunicacion_finTrazo(MensajeFinTrazo m) {
            antiguo = null;
        }


    }
}

