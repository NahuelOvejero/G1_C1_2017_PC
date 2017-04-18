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
    public partial class frmSalas : Form
    {
        frmJuego juego;
        public frmSalas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            juego = new frmJuego();
            juego.Show();
        }
    }
}
