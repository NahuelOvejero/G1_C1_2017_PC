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
        ICom comunicacion;
        frmJuego juegoform;
       

        public frmPrueba(ICom c,frmJuego j)
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

        }
    }
}
