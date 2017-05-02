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
        frmSalas salas;
        clsUsuario usuario = new clsUsuario();

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
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "Usuario")
            {
                usuario.User = tbUsuario.Text;
                usuario.Puntos = 0;
                //Abre el otro formulario
                MessageBox.Show("Logeado", "logeado");
                salas = new frmSalas(usuario);
                salas.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            else if (tbUsuario.Text.Length == 0 || mtbPass.Text.Length == 0)
            {
                MessageBox.Show("No deje campos vacío para el ingreso", "Error");
            }
           
         }
    }
}
