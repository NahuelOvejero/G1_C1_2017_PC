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
            this.tbResp = new System.Windows.Forms.TextBox();
            this.pnlRojo = new System.Windows.Forms.Panel();
            this.pnlNegro = new System.Windows.Forms.Panel();
            this.pnlBlanco = new System.Windows.Forms.Panel();
            this.pnlVerde = new System.Windows.Forms.Panel();
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.pnlMarron = new System.Windows.Forms.Panel();
            this.pnlAmarillo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPalabrasIncorrectas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDibujo
            // 
            this.pnlDibujo.BackColor = System.Drawing.Color.White;
            this.pnlDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDibujo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlDibujo.Location = new System.Drawing.Point(27, 131);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(335, 242);
            this.pnlDibujo.TabIndex = 0;
            this.pnlDibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseDown);
            this.pnlDibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseMove);
            this.pnlDibujo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseUp);
            // 
            // tbResp
            // 
            this.tbResp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResp.Location = new System.Drawing.Point(408, 464);
            this.tbResp.Name = "tbResp";
            this.tbResp.Size = new System.Drawing.Size(376, 20);
            this.tbResp.TabIndex = 3;
            this.tbResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbResp_KeyPress);
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
            this.lbPalabrasIncorrectas.FormattingEnabled = true;
            this.lbPalabrasIncorrectas.Location = new System.Drawing.Point(458, 131);
            this.lbPalabrasIncorrectas.Name = "lbPalabrasIncorrectas";
            this.lbPalabrasIncorrectas.Size = new System.Drawing.Size(272, 329);
            this.lbPalabrasIncorrectas.TabIndex = 13;
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(796, 496);
            this.Controls.Add(this.lbPalabrasIncorrectas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbResp);
            this.Controls.Add(this.pnlDibujo);
            this.Name = "frmJuego";
            this.Text = "frmJuego";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDibujo;
        private System.Windows.Forms.TextBox tbResp;
        private System.Windows.Forms.Panel pnlRojo;
        private System.Windows.Forms.Panel pnlNegro;
        private System.Windows.Forms.Panel pnlBlanco;
        private System.Windows.Forms.Panel pnlVerde;
        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.Panel pnlMarron;
        private System.Windows.Forms.Panel pnlAmarillo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbPalabrasIncorrectas;
    }
}