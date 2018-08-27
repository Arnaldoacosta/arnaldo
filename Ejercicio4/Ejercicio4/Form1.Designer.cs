namespace Ejercicio4
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
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.Ruta = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(31, 76);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(106, 23);
            this.btnCargarArchivo.TabIndex = 0;
            this.btnCargarArchivo.Text = "Cargar archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // Ruta
            // 
            this.Ruta.AutoSize = true;
            this.Ruta.Location = new System.Drawing.Point(28, 48);
            this.Ruta.Name = "Ruta";
            this.Ruta.Size = new System.Drawing.Size(46, 13);
            this.Ruta.TabIndex = 1;
            this.Ruta.Text = "Archivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calcular potenciales clientes.";
            // 
            // btnObtenerArchivo
            // 
            this.btnObtenerArchivo.Enabled = false;
            this.btnObtenerArchivo.Location = new System.Drawing.Point(143, 76);
            this.btnObtenerArchivo.Name = "btnObtenerArchivo";
            this.btnObtenerArchivo.Size = new System.Drawing.Size(118, 23);
            this.btnObtenerArchivo.TabIndex = 3;
            this.btnObtenerArchivo.Text = "Obtener archivo";
            this.btnObtenerArchivo.UseVisualStyleBackColor = true;
            this.btnObtenerArchivo.Click += new System.EventHandler(this.btnObtenerArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 134);
            this.Controls.Add(this.btnObtenerArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ruta);
            this.Controls.Add(this.btnCargarArchivo);
            this.MaximumSize = new System.Drawing.Size(350, 173);
            this.MinimumSize = new System.Drawing.Size(350, 173);
            this.Name = "Form1";
            this.Text = "Cliente Potencial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Label Ruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObtenerArchivo;
    }
}

