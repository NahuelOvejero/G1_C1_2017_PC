namespace SN
{
    partial class frmPrueba
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
            this.lblContador = new System.Windows.Forms.Label();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.tbPalabra = new System.Windows.Forms.TextBox();
            this.lbPalabrasIncorrectas = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDibujo.SuspendLayout();
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
            this.pnlDibujo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlDibujo.Location = new System.Drawing.Point(129, 82);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(432, 320);
            this.pnlDibujo.TabIndex = 1;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(3, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(30, 24);
            this.lblContador.TabIndex = 25;
            this.lblContador.Text = "60";
            // 
            // lblPalabra
            // 
            this.lblPalabra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.ForeColor = System.Drawing.Color.Tomato;
            this.lblPalabra.Location = new System.Drawing.Point(175, 43);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(313, 23);
            this.lblPalabra.TabIndex = 24;
            this.lblPalabra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPalabra
            // 
            this.tbPalabra.Location = new System.Drawing.Point(586, 382);
            this.tbPalabra.Name = "tbPalabra";
            this.tbPalabra.Size = new System.Drawing.Size(142, 20);
            this.tbPalabra.TabIndex = 2;
            this.tbPalabra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPalabra_KeyPress);
            // 
            // lbPalabrasIncorrectas
            // 
            this.lbPalabrasIncorrectas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPalabrasIncorrectas.FormattingEnabled = true;
            this.lbPalabrasIncorrectas.Location = new System.Drawing.Point(586, 82);
            this.lbPalabrasIncorrectas.Name = "lbPalabrasIncorrectas";
            this.lbPalabrasIncorrectas.Size = new System.Drawing.Size(142, 303);
            this.lbPalabrasIncorrectas.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 496);
            this.Controls.Add(this.lbPalabrasIncorrectas);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.tbPalabra);
            this.Controls.Add(this.pnlDibujo);
            this.Name = "frmPrueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmPrueba";
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            this.pnlDibujo.ResumeLayout(false);
            this.pnlDibujo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDibujo;
        private System.Windows.Forms.TextBox tbPalabra;
        private System.Windows.Forms.ListBox lbPalabrasIncorrectas;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.Timer timer1;
    }
}