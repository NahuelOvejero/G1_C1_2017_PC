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
        public frmJuego()
        {
            InitializeComponent();
            lapiz = new Pen(Color.Black, 6);
            grafico = pnlDibujo.CreateGraphics();

        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
           
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
            }
        }


        bool har = false;
        private void tbResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter && tbResp.Text.Length !=0)
            {
                //Compara la palabra que se ha dado con la que ingresó
                if (har)
                {
                    //se le informa que ganó
                }
                else
                {
                    lbPalabrasIncorrectas.Items.Add(tbResp.Text);
                    tbResp.Clear();
                }   
            }
        }

        private void pnlNegro_Click(object sender, EventArgs e)
        {
            Panel color = (Panel)sender;
            lapiz.Color = color.BackColor;
        }

    }
}
