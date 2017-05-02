using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SN
{
    
    public partial class frmJuego : Form
    {
        private bool btnDown;
        Pen lapiz;
        Graphics grafico;
        clsUsuario usuario;
        frmPrueba prueba;
        clsComunicacion comunicacion;
        

        public frmJuego(clsUsuario us,clsComunicacion c)
        {
            InitializeComponent();
            usuario = us;
           
           
            comunicacion = c;

            lapiz = new Pen(Color.Black, 6);
            grafico = pnlDibujo.CreateGraphics();
            lblNick.Text = usuario.User;
            lblPuntos.Text =Convert.ToString(usuario.Puntos);

        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            prueba = new frmPrueba(comunicacion,this);
            prueba.Show();
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
                // mover el pictureBox con el raton               
                grafico.DrawLine(lapiz, e.X, e.Y, e.X+1 , e.Y+1);
                grafico.DrawLine(lapiz, e.X, e.Y, e.X - 1, e.Y - 1);
                comunicacion.enviaEjes(e.X, e.Y,prueba);
                
            }
        }


        bool har = false;
       

        private void pnlNegro_Click(object sender, EventArgs e)
        {
            Panel color = (Panel)sender;
            lapiz.Color = color.BackColor;
        }

        public void rtasIncorrectas(string rta)
        {
            lbPalabrasIncorrectas.Items.Add(rta);

        }
    }
}
