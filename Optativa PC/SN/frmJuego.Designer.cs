namespace SN
{
    partial class frmJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlDibujo = new System.Windows.Forms.Panel();
            this.pnlAdivina = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.pnlRojo = new System.Windows.Forms.Panel();
            this.pnlNegro = new System.Windows.Forms.Panel();
            this.pnlBlanco = new System.Windows.Forms.Panel();
            this.pnlVerde = new System.Windows.Forms.Panel();
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.pnlMarron = new System.Windows.Forms.Panel();
            this.pnlAmarillo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.lbPalabrasIncorrectas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNick = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.lblCont = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPalabra = new System.Windows.Forms.TextBox();
            this.lblAdivina = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDibujo
            // 
            this.pnlDibujo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDibujo.BackColor = System.Drawing.Color.White;
            this.pnlDibujo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnlDibujo.Location = new System.Drawing.Point(28, 29);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(633, 410);
            this.pnlDibujo.TabIndex = 0;
            this.pnlDibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseDown);
            this.pnlDibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseMove);
            this.pnlDibujo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseUp);
            // 
            // pnlAdivina
            // 
            this.pnlAdivina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAdivina.BackColor = System.Drawing.Color.White;
            this.pnlAdivina.Location = new System.Drawing.Point(42, 25);
            this.pnlAdivina.Name = "pnlAdivina";
            this.pnlAdivina.Size = new System.Drawing.Size(632, 426);
            this.pnlAdivina.TabIndex = 25;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Green;
            this.lblMensaje.Location = new System.Drawing.Point(28, 465);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(684, 42);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "label5";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.Transparent;
            this.lblContador.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Red;
            this.lblContador.Location = new System.Drawing.Point(618, 83);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(53, 39);
            this.lblContador.TabIndex = 24;
            this.lblContador.Text = "60";
            // 
            // pnlRojo
            // 
            this.pnlRojo.BackColor = System.Drawing.Color.Red;
            this.pnlRojo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRojo.Location = new System.Drawing.Point(70, 17);
            this.pnlRojo.Name = "pnlRojo";
            this.pnlRojo.Size = new System.Drawing.Size(21, 18);
            this.pnlRojo.TabIndex = 5;
            this.pnlRojo.Click += new System.EventHandler(this.pnlNegro_Click);
            // 
            // pnlNegro
            // 
            this.pnlNegro.BackColor = System.Drawing.Color.Black;
            this.pnlNegro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNegro.Location = new System.Drawing.Point(16, 17);
            this.pnlNegro.Name = "pnlNegro";
            this.pnlNegro.Size = new System.Drawing.Size(21, 18);
            this.pnlNegro.TabIndex = 6;
            this.pnlNegro.Click += new System.EventHandler(this.pnlNegro_Click);
            // 
            // pnlBlanco
            // 
            this.pnlBlanco.BackColor = System.Drawing.Color.White;
            this.pnlBlanco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBlanco.Location = new System.Drawing.Point(43, 17);
            this.pnlBlanco.Name = "pnlBlanco";
            this.pnlBlanco.Size = new System.Drawing.Size(21, 18);
            this.pnlBlanco.TabIndex = 7;
            this.pnlBlanco.Click += new System.EventHandler(this.pnlNegro_Click);
            // 
            // pnlVerde
            // 
            this.pnlVerde.BackColor = System.Drawing.Color.Green;
            this.pnlVerde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVerde.Location = new System.Drawing.Point(97, 17);
            this.pnlVerde.Name = "pnlVerde";
            this.pnlVerde.Size = new System.Drawing.Size(21, 18);
            this.pnlVerde.TabIndex = 8;
            this.pnlVerde.Click += new System.EventHandler(this.pnlNegro_Click);
            // 
            // pnlAzul
            // 
            this.pnlAzul.BackColor = System.Drawing.Color.Blue;
            this.pnlAzul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAzul.Location = new System.Drawing.Point(124, 17);
            this.pnlAzul.Name = "pnlAzul";
            this.pnlAzul.Size = new System.Drawing.Size(21, 18);
            this.pnlAzul.TabIndex = 9;
            this.pnlAzul.Click += new System.EventHandler(this.pnlNegro_Click);
            // 
            // pnlMarron
            // 
            this.pnlMarron.BackColor = System.Drawing.Color.Brown;
            this.pnlMarron.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMarron.Location = new System.Drawing.Point(151, 17);
            this.pnlMarron.Name = "pnlMarron";
            this.pnlMarron.Size = new System.Drawing.Size(21, 18);
            this.pnlMarron.TabIndex = 10;
            this.pnlMarron.Click += new System.EventHandler(this.pnlNegro_Click);
            // 
            // pnlAmarillo
            // 
            this.pnlAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.pnlAmarillo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAmarillo.Location = new System.Drawing.Point(178, 17);
            this.pnlAmarillo.Name = "pnlAmarillo";
            this.pnlAmarillo.Size = new System.Drawing.Size(21, 18);
            this.pnlAmarillo.TabIndex = 11;
            this.pnlAmarillo.Click += new System.EventHandler(this.pnlNegro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pnlAmarillo);
            this.groupBox1.Controls.Add(this.nudWidth);
            this.groupBox1.Controls.Add(this.pnlMarron);
            this.groupBox1.Controls.Add(this.pnlAzul);
            this.groupBox1.Controls.Add(this.pnlVerde);
            this.groupBox1.Controls.Add(this.pnlBlanco);
            this.groupBox1.Controls.Add(this.pnlNegro);
            this.groupBox1.Controls.Add(this.pnlRojo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(227, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 42);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ancho:";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(286, 15);
            this.nudWidth.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(36, 23);
            this.nudWidth.TabIndex = 19;
            this.nudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // lbPalabrasIncorrectas
            // 
            this.lbPalabrasIncorrectas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPalabrasIncorrectas.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbPalabrasIncorrectas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPalabrasIncorrectas.FormattingEnabled = true;
            this.lbPalabrasIncorrectas.ItemHeight = 20;
            this.lbPalabrasIncorrectas.Location = new System.Drawing.Point(973, 157);
            this.lbPalabrasIncorrectas.Name = "lbPalabrasIncorrectas";
            this.lbPalabrasIncorrectas.Size = new System.Drawing.Size(157, 404);
            this.lbPalabrasIncorrectas.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(948, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "M Nick :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(948, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ms Puntos :";
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.BackColor = System.Drawing.Color.Transparent;
            this.lblNick.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNick.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNick.Location = new System.Drawing.Point(1052, 40);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(74, 23);
            this.lblNick.TabIndex = 16;
            this.lblNick.Text = "M Nick";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPuntos.Location = new System.Drawing.Point(1054, 80);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(71, 23);
            this.lblPuntos.TabIndex = 17;
            this.lblPuntos.Text = "puntos";
            this.lblPuntos.UseWaitCursor = true;
            // 
            // lblPalabra
            // 
            this.lblPalabra.BackColor = System.Drawing.Color.DimGray;
            this.lblPalabra.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.ForeColor = System.Drawing.Color.Red;
            this.lblPalabra.Location = new System.Drawing.Point(453, 13);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(327, 50);
            this.lblPalabra.TabIndex = 18;
            this.lblPalabra.Text = "label3";
            this.lblPalabra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCont
            // 
            this.lblCont.BackColor = System.Drawing.Color.Transparent;
            this.lblCont.Location = new System.Drawing.Point(804, 106);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(27, 23);
            this.lblCont.TabIndex = 21;
            this.lblCont.Text = "60";
            this.lblCont.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsuarios.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.ItemHeight = 20;
            this.lbUsuarios.Location = new System.Drawing.Point(34, 161);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(143, 460);
            this.lbUsuarios.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(30, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Usuarios";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbPalabra
            // 
            this.tbPalabra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPalabra.Location = new System.Drawing.Point(973, 596);
            this.tbPalabra.Name = "tbPalabra";
            this.tbPalabra.Size = new System.Drawing.Size(157, 31);
            this.tbPalabra.TabIndex = 24;
            this.tbPalabra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPalabra_KeyPress);
            // 
            // lblAdivina
            // 
            this.lblAdivina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdivina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdivina.ForeColor = System.Drawing.Color.Tomato;
            this.lblAdivina.Location = new System.Drawing.Point(390, 160);
            this.lblAdivina.Name = "lblAdivina";
            this.lblAdivina.Size = new System.Drawing.Size(313, 23);
            this.lblAdivina.TabIndex = 26;
            this.lblAdivina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackgroundImage = global::SN.Properties.Resources.pizarron;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlAdivina);
            this.panel1.Controls.Add(this.pnlDibujo);
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Location = new System.Drawing.Point(227, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 507);
            this.panel1.TabIndex = 27;
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SN.Properties.Resources.ff123;
            this.ClientSize = new System.Drawing.Size(1165, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAdivina);
            this.Controls.Add(this.tbPalabra);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPalabrasIncorrectas);
            this.Name = "frmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmJuego";
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDibujo;
        private System.Windows.Forms.Panel pnlRojo;
        private System.Windows.Forms.Panel pnlNegro;
        private System.Windows.Forms.Panel pnlBlanco;
        private System.Windows.Forms.Panel pnlVerde;
        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.Panel pnlMarron;
        private System.Windows.Forms.Panel pnlAmarillo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbPalabrasIncorrectas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPalabra;
        private System.Windows.Forms.Panel pnlAdivina;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblAdivina;
        private System.Windows.Forms.Panel panel1;
    }
}