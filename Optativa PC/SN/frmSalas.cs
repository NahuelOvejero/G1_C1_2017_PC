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
        
        clsUsuario usuario;
        clsComunicacion comunicacion = new clsComunicacion();

        public frmSalas(clsUsuario us)
        {
            InitializeComponent();
            usuario = us;
            label3.Text = usuario.User;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            juego = new frmJuego(usuario,comunicacion);
            juego.Show();
           
            this.WindowState = FormWindowState.Minimized;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sala "  + (sender as Button).Tag + " en mantenimiento","Lo sentimos");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
