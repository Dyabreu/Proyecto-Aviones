namespace WindowsAviones
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
            this.btn_avion = new System.Windows.Forms.Button();
            this.btn_Av_Carga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_avion
            // 
            this.btn_avion.Location = new System.Drawing.Point(300, 126);
            this.btn_avion.Name = "btn_avion";
            this.btn_avion.Size = new System.Drawing.Size(188, 23);
            this.btn_avion.TabIndex = 0;
            this.btn_avion.Text = "Avión Comercial";
            this.btn_avion.UseVisualStyleBackColor = true;
            this.btn_avion.Click += new System.EventHandler(this.btn_avion_Click);
            // 
            // btn_Av_Carga
            // 
            this.btn_Av_Carga.Location = new System.Drawing.Point(300, 212);
            this.btn_Av_Carga.Name = "btn_Av_Carga";
            this.btn_Av_Carga.Size = new System.Drawing.Size(188, 23);
            this.btn_Av_Carga.TabIndex = 1;
            this.btn_Av_Carga.Text = "Avión de Carga";
            this.btn_Av_Carga.UseVisualStyleBackColor = true;
            this.btn_Av_Carga.Click += new System.EventHandler(this.btn_Av_Carga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Av_Carga);
            this.Controls.Add(this.btn_avion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_avion;
        private System.Windows.Forms.Button btn_Av_Carga;
    }
}

