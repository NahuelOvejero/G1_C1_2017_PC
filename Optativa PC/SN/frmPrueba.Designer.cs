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
            this.pnlDibujo = new System.Windows.Forms.Panel();
            this.tbPalabra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btIngresa = new System.Windows.Forms.Button();
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
            this.pnlDibujo.Location = new System.Drawing.Point(87, 82);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(320, 286);
            this.pnlDibujo.TabIndex = 1;
            // 
            // tbPalabra
            // 
            this.tbPalabra.Location = new System.Drawing.Point(116, 442);
            this.tbPalabra.Name = "tbPalabra";
            this.tbPalabra.Size = new System.Drawing.Size(150, 20);
            this.tbPalabra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escribe lo que crees que estan dibujand";
            // 
            // btIngresa
            // 
            this.btIngresa.Location = new System.Drawing.Point(284, 442);
            this.btIngresa.Name = "btIngresa";
            this.btIngresa.Size = new System.Drawing.Size(75, 23);
            this.btIngresa.TabIndex = 4;
            this.btIngresa.Text = "Ingresar";
            this.btIngresa.UseVisualStyleBackColor = true;
            this.btIngresa.Click += new System.EventHandler(this.btIngresa_Click);
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 496);
            this.Controls.Add(this.btIngresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPalabra);
            this.Controls.Add(this.pnlDibujo);
            this.Name = "frmPrueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmPrueba";
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDibujo;
        private System.Windows.Forms.TextBox tbPalabra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btIngresa;
    }
}