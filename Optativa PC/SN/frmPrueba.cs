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
       
        Pen lapiz;
        Graphics grafico;
        //clsUsuario usuario;
        clsComunicacion comunicacion;
        frmJuego juegoform;
       

        public frmPrueba(clsComunicacion c,frmJuego j)
        {
            InitializeComponent();
            lapiz = new Pen(Color.Black, 6);
            grafico = pnlDibujo.CreateGraphics();
            comunicacion = c;
            juegoform = j;

        }
        public void dibujar(int X,int Y1)
        {
            grafico.DrawLine(lapiz, X, Y1, X + 1, Y1 + 1);
            grafico.DrawLine(lapiz, X, Y1, X - 1, Y1 - 1);

        }

        private void btIngresa_Click(object sender, EventArgs e)
        {
            comunicacion.enviaRta(tbPalabra.Text,juegoform);
        }
    }
}
