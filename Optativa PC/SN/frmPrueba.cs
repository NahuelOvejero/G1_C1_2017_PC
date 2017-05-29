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
    public partial class frmPrueba : Form
    {
    
        Graphics grafico;
        //clsUsuario usuario;
        clsComunicacion comunicacion;
        frmJuego juegoform;
       

        public frmPrueba(clsComunicacion c,frmJuego j)
        {
            InitializeComponent();
           
            grafico = pnlDibujo.CreateGraphics();
            comunicacion = c;
            juegoform = j;

        }
        public void dibujar(Pen lapiz,int X,int Y1)
        {
            grafico.DrawLine(lapiz, X, Y1, X + 1, Y1 + 1);
            grafico.DrawLine(lapiz, X, Y1, X - 1, Y1 - 1);
        }

        private void btIngresa_Click(object sender, EventArgs e)
        {
            if (comunicacion.enviaRta(tbPalabra.Text, juegoform))
                MessageBox.Show("La palabra es correcta");
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            int longPalabra = comunicacion.PalabraDesignada.Length;
            for (int i = 0; i < longPalabra; i++)
            {
                lblPalabra.Text += "_ ";
            }
            timer1.Enabled = true;
        }

        private void tbPalabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar == (int)Keys.Enter))
            {
                if ((tbPalabra.Text != "") && (tbPalabra.Text != null))
                {
                    if ((comunicacion.enviaRta(tbPalabra.Text, juegoform)))
                    {
                        MessageBox.Show("La palabra es correcta");
                    }
                }
                tbPalabra.Clear();
            }
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
    }
}
