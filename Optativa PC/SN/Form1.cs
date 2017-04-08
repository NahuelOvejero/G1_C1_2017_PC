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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string simulaUs = "Usuario", simulaPass = "Contraseña";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == simulaUs && mtbPass.Text == simulaPass)
            {
                //Abre el otro formulario
                MessageBox.Show("Logeado", "logeado");
            }
            else if (tbUsuario.Text.Length == 0 || mtbPass.Text.Length == 0)
            {
                MessageBox.Show("No deje campos vacío para el ingreso", "Error");
            }
            else if (tbUsuario.Text != simulaUs || mtbPass.Text != simulaPass)
            {
                MessageBox.Show("Combinación de usuario y contraseña incorrectos", "Error");
            }
         }
    }
}
