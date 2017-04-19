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
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlDibujo
            // 
            this.pnlDibujo.BackColor = System.Drawing.Color.White;
            this.pnlDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDibujo.Location = new System.Drawing.Point(37, 51);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(335, 242);
            this.pnlDibujo.TabIndex = 0;
            this.pnlDibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseDown);
            this.pnlDibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseMove);
            this.pnlDibujo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseUp);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(78, 315);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 1;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(202, 315);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(796, 496);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.pnlDibujo);
            this.Name = "frmJuego";
            this.Text = "frmJuego";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDibujo;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnBorrar;
    }
}