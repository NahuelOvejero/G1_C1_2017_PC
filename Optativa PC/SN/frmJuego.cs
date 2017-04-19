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
        private bool escribir;
        private bool borrar;
        private int offsetX;
        private int offsetY;
        Pen lapiz;
        Pen goma;
        Graphics grafico;
        public frmJuego()
        {
            InitializeComponent();
            lapiz = new Pen(Color.Black, 6);
            goma = new Pen(Color.White, 6);
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
            if ((escribir) && (btnDown))
            {
                // mover el pictureBox con el raton               
                grafico.DrawLine(lapiz, e.X, e.Y, e.X+1 , e.Y+1);
                grafico.DrawLine(lapiz, e.X, e.Y, e.X - 1, e.Y - 1);
            }
            else if ((borrar) && (btnDown))
            {
                grafico.DrawLine(goma, e.X, e.Y, e.X + 1, e.Y + 1);
                grafico.DrawLine(goma, e.X, e.Y, e.X - 1, e.Y - 1);
            }
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            escribir = true;
            borrar = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            escribir = false;
            borrar = true;
        }
    }
}
