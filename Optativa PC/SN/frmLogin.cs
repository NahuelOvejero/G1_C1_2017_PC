using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
        EventWaitHandle _ARELogeo = new AutoResetEvent(false),_ARENoLogeo=new AutoResetEvent(false);
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
        

        private void pbLogin_MouseHover(object sender, EventArgs e)
        {
            pbLogin.BackColor = Color.Green;
        }

        private void pbLogin_MouseLeave(object sender, EventArgs e)
        {

            pbLogin.BackColor = Color.Transparent;
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Length == 0)
            {
                MessageBox.Show("No deje campos vacío para el ingreso", "Error");
            }

            else
            //if (tbUsuario.Text == "Usuario")
            {
                usuario.User = tbUsuario.Text;
                Task.Run(() => comunicacion.conectar(usuario.User));
                //Abre el otro formulario
                int i = WaitHandle.WaitAny(new WaitHandle[] { _ARELogeo, _ARENoLogeo }, 10000);
                if (i == 0)
                {
                    MessageBox.Show("Logeado", "logeado");
                    salas = new frmSalas(usuario, comunicacion);
                    salas.Show();
                }
                else if (i == 1)
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("Se agotó el tiempo de espera, vuelva a reintentarlo");
                }
            }

        }

        private void Comunicacion_IntentarLogear(MensajeLogin m)
        {
            if (m.Conectado)
            {
                
                _ARELogeo.Set();
                
               // this.WindowState = FormWindowState.Minimized;
            }
            else
            {
               mensaje=m.Mensaje;
                _ARENoLogeo.Set();
            }
        }
    }
}
