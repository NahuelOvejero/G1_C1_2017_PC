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
            this.pnlRojo = new System.Windows.Forms.Panel();
            this.pnlNegro = new System.Windows.Forms.Panel();
            this.pnlBlanco = new System.Windows.Forms.Panel();
            this.pnlVerde = new System.Windows.Forms.Panel();
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.pnlMarron = new System.Windows.Forms.Panel();
            this.pnlAmarillo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPalabrasIncorrectas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNick = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCont = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDibujo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDibujo
            // 
            this.pnlDibujo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDibujo.BackColor = System.Drawing.Color.White;
            this.pnlDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDibujo.Controls.Add(this.lblContador);
            this.pnlDibujo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnlDibujo.Location = new System.Drawing.Point(196, 131);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(435, 340);
            this.pnlDibujo.TabIndex = 0;
            this.pnlDibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseDown);
            this.pnlDibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseMove);
            this.pnlDibujo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseUp);
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
            this.groupBox1.Controls.Add(this.pnlAmarillo);
            this.groupBox1.Controls.Add(this.pnlMarron);
            this.groupBox1.Controls.Add(this.pnlAzul);
            this.groupBox1.Controls.Add(this.pnlVerde);
            this.groupBox1.Controls.Add(this.pnlBlanco);
            this.groupBox1.Controls.Add(this.pnlNegro);
            this.groupBox1.Controls.Add(this.pnlRojo);
            this.groupBox1.Location = new System.Drawing.Point(196, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 42);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colores";
            // 
            // lbPalabrasIncorrectas
            // 
            this.lbPalabrasIncorrectas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPalabrasIncorrectas.FormattingEnabled = true;
            this.lbPalabrasIncorrectas.Location = new System.Drawing.Point(667, 131);
            this.lbPalabrasIncorrectas.Name = "lbPalabrasIncorrectas";
            this.lbPalabrasIncorrectas.Size = new System.Drawing.Size(142, 329);
            this.lbPalabrasIncorrectas.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "M Nick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ms Puntos";
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(723, 20);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(41, 13);
            this.lblNick.TabIndex = 16;
            this.lblNick.Text = "M Nick";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(725, 60);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(39, 13);
            this.lblPuntos.TabIndex = 17;
            this.lblPuntos.Text = "puntos";
            this.lblPuntos.UseWaitCursor = true;
            // 
            // lblPalabra
            // 
            this.lblPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.ForeColor = System.Drawing.Color.Tomato;
            this.lblPalabra.Location = new System.Drawing.Point(251, 32);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(313, 23);
            this.lblPalabra.TabIndex = 18;
            this.lblPalabra.Text = "label3";
            this.lblPalabra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(478, 98);
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
            this.nudWidth.Size = new System.Drawing.Size(36, 20);
            this.nudWidth.TabIndex = 19;
            this.nudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ancho:";
            // 
            // lblCont
            // 
            this.lblCont.Location = new System.Drawing.Point(556, 20);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(27, 23);
            this.lblCont.TabIndex = 21;
            this.lblCont.Text = "60";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(3, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(30, 24);
            this.lblContador.TabIndex = 24;
            this.lblContador.Text = "60";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.lbUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.ItemHeight = 20;
            this.lbUsuarios.Location = new System.Drawing.Point(12, 84);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(166, 300);
            this.lbUsuarios.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Usuarios";
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(844, 507);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPalabrasIncorrectas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlDibujo);
            this.Name = "frmJuego";
            this.Text = "frmJuego";
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.pnlDibujo.ResumeLayout(false);
            this.pnlDibujo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
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
    }
}