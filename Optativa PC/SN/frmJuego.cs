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
        Graphics grafico;
        clsUsuario usuario;
        //frmPrueba prueba;
        clsComunicacion comunicacion;
        

        public frmJuego(clsUsuario us,clsComunicacion c)
        {
            InitializeComponent();
            usuario = us;
            comunicacion = c;
            comunicacion.RespuestaPalabraEnviada += Comunicacion_RespuestaPalabraEnviada;
            comunicacion.Dibujar += Comunicacion_Dibujar;
            lapiz = new Pen(Color.Black,(int) nudWidth.Value);
            grafico = pnlDibujo.CreateGraphics();
            lblNick.Text = usuario.User;
            lblPuntos.Text =Convert.ToString(usuario.Puntos);
            lbUsuarios.Items.Add(usuario.User + "     " + usuario.Puntos.ToString());

        }

        private void Comunicacion_Dibujar(MensajeDibujarPuntos m)
        {
            Color colorcito = Color.FromArgb(m.ColorRGB);
            Pen lap = new Pen(colorcito,m.Grosor);
            grafico.DrawLine(lap,m.CordX,m.CordY,m.CordX+1,m.CordY);
        }

        private void Comunicacion_RespuestaPalabraEnviada(MensajeEnviarPalabra m)
        {
            if (m.Correcta)
            {
                usuario.Puntos += m.Puntos;
                MessageBox.Show("Ganaste!");
            }
            else
            {
                lbPalabrasIncorrectas.Invoke((Action)(() => { lbPalabrasIncorrectas.Items.Add(usuario.User + ": "+m.Palabra); }));
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

                int x = e.X;
                int y = e.Y;            
                grafico.DrawLine(lapiz, e.X, e.Y, e.X+1 , e.Y+1);
                // grafico.DrawLine(lapiz, e.X, e.Y, e.X -1, e.Y -1);
                Task.Run(()=>comunicacion.enviarDibujado(lapiz, new Point(x, y), usuario.User));
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
        int cont = 60;
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
            if (((int)e.KeyChar == (int)Keys.Enter))
            {
                if ((tbPalabra.Text != "") && (tbPalabra.Text != null))
                {
                    Task.Run(() => comunicacion.enviaRta(tbPalabra.Text, usuario.User,37));
                }
                tbPalabra.Clear();
            }
        }

    }
}
