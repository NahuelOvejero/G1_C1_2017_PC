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
namespace SN
{
    public partial class frmSalas : Form
    {
        frmJuego juego;
        
        clsUsuario usuario;
        clsComunicacion comunicacion;

        public frmSalas(clsUsuario us,clsComunicacion comunicacion)
        {
            InitializeComponent();
            usuario = us;
            this.comunicacion = comunicacion;
            label3.Text = usuario.User;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sala "  + (sender as Button).Tag + " en mantenimiento","Lo sentimos");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pbEntrar_Click(object sender, EventArgs e)
        {
            Task.Run(() => comunicacion.entrar_sala(usuario.User, "", 1, ""));

            juego = new frmJuego(usuario, comunicacion);
            juego.Show();

            this.WindowState = FormWindowState.Minimized;



            /* usuario.User = tbUsuario.Text;
             Task.Run(() => comunicacion.conectar(usuario.User));
             //Abre el otro formulario
             int i = WaitHandle.WaitAny(new WaitHandle[] { _ARELogeo, _ARENoLogeo });
             if (i == 0)
             {
                 salas = new frmSalas(usuario);
                 salas.Show();
             }*/

        }

        private void pbEntrar_MouseEnter(object sender, EventArgs e)
        {
            pbEntrar.BackColor = Color.Green;
        }

        private void pbEntrar_MouseLeave(object sender, EventArgs e)
        {
            pbEntrar.BackColor = Color.Transparent;
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {

        }
    }
}
