namespace Generador_QR
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnqr = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.PicBoxQR = new System.Windows.Forms.PictureBox();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnqr
            // 
            this.btnqr.Location = new System.Drawing.Point(38, 92);
            this.btnqr.Name = "btnqr";
            this.btnqr.Size = new System.Drawing.Size(58, 50);
            this.btnqr.TabIndex = 0;
            this.btnqr.Text = "Generar";
            this.btnqr.UseVisualStyleBackColor = true;
            this.btnqr.Click += new System.EventHandler(this.btnqr_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(173, 92);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(58, 50);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // PicBoxQR
            // 
            this.PicBoxQR.Location = new System.Drawing.Point(38, 158);
            this.PicBoxQR.Name = "PicBoxQR";
            this.PicBoxQR.Size = new System.Drawing.Size(193, 185);
            this.PicBoxQR.TabIndex = 2;
            this.PicBoxQR.TabStop = false;
            // 
            // txtQR
            // 
            this.txtQR.Location = new System.Drawing.Point(38, 45);
            this.txtQR.Multiline = true;
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(193, 32);
            this.txtQR.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresa el texto a convertir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.PicBoxQR);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.btnqr);
            this.Name = "Form1";
            this.Text = "Generador de código QR";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnqr;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.PictureBox PicBoxQR;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

