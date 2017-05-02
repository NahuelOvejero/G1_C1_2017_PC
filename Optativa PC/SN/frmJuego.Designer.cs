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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDibujo
            // 
            this.pnlDibujo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDibujo.BackColor = System.Drawing.Color.White;
            this.pnlDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDibujo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlDibujo.Location = new System.Drawing.Point(27, 131);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(274, 340);
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
            this.groupBox1.Location = new System.Drawing.Point(31, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 50);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colores";
            // 
            // lbPalabrasIncorrectas
            // 
            this.lbPalabrasIncorrectas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPalabrasIncorrectas.FormattingEnabled = true;
            this.lbPalabrasIncorrectas.Location = new System.Drawing.Point(349, 131);
            this.lbPalabrasIncorrectas.Name = "lbPalabrasIncorrectas";
            this.lbPalabrasIncorrectas.Size = new System.Drawing.Size(142, 329);
            this.lbPalabrasIncorrectas.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "M Nick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ms Puntos";
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(416, 31);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(41, 13);
            this.lblNick.TabIndex = 16;
            this.lblNick.Text = "M Nick";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(416, 71);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(39, 13);
            this.lblPuntos.TabIndex = 17;
            this.lblPuntos.Text = "puntos";
            this.lblPuntos.UseWaitCursor = true;
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(557, 507);
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
            this.groupBox1.ResumeLayout(false);
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
    }
}