using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using misClases;
using Mensajes;
namespace SN
{
    public partial class frmLogin : Form
    {
        frmSalas salas;
        clsUsuario usuario = new clsUsuario();
        clsComunicacion comunicacion = new clsComunicacion();
        string mensaje;
        public frmLogin()
        {
            InitializeComponent();
            comunicacion.Logear += Comunicacion_IntentarLogear;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Length == 0)
            {
                MessageBox.Show("No deje campos vacío para el ingreso", "Error");
            }

            else 
            //if (tbUsuario.Text == "Usuario")
            {
                usuario.User = tbUsuario.Text;
                Task.Run(()=>comunicacion.conectar(usuario.User));
                //Abre el otro formulario
               
            }

           

        }

        private void Comunicacion_IntentarLogear(MensajeLogin m)
        {
            if (m.Conectado)
            {
                MessageBox.Show("Logeado", "logeado");
                salas = new frmSalas(usuario);
                salas.Show();
               // this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                MessageBox.Show(m.Mensaje);
            }
        }
    }
}
