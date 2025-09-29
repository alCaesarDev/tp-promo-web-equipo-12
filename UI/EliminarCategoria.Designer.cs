namespace UI
{
    partial class EliminarCategoria
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
            this.btnEliminarAceptar = new System.Windows.Forms.Button();
            this.btnEliminarCancelar = new System.Windows.Forms.Button();
            this.lblEliminarTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminarAceptar
            // 
            this.btnEliminarAceptar.Location = new System.Drawing.Point(33, 184);
            this.btnEliminarAceptar.Name = "btnEliminarAceptar";
            this.btnEliminarAceptar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminarAceptar.TabIndex = 0;
            this.btnEliminarAceptar.Text = "Aceptar";
            this.btnEliminarAceptar.UseVisualStyleBackColor = true;
            this.btnEliminarAceptar.Click += new System.EventHandler(this.btnEliminarAceptar_Click);
            // 
            // btnEliminarCancelar
            // 
            this.btnEliminarCancelar.Location = new System.Drawing.Point(180, 182);
            this.btnEliminarCancelar.Name = "btnEliminarCancelar";
            this.btnEliminarCancelar.Size = new System.Drawing.Size(102, 42);
            this.btnEliminarCancelar.TabIndex = 1;
            this.btnEliminarCancelar.Text = "Cancelar";
            this.btnEliminarCancelar.UseVisualStyleBackColor = true;
            this.btnEliminarCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEliminarTitulo
            // 
            this.lblEliminarTitulo.AutoSize = true;
            this.lblEliminarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarTitulo.Location = new System.Drawing.Point(75, 98);
            this.lblEliminarTitulo.Name = "lblEliminarTitulo";
            this.lblEliminarTitulo.Size = new System.Drawing.Size(166, 20);
            this.lblEliminarTitulo.TabIndex = 2;
            this.lblEliminarTitulo.Text = "¿Eliminar Categoría?";
            // 
            // EliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.lblEliminarTitulo);
            this.Controls.Add(this.btnEliminarCancelar);
            this.Controls.Add(this.btnEliminarAceptar);
            this.MaximumSize = new System.Drawing.Size(330, 330);
            this.MinimumSize = new System.Drawing.Size(330, 330);
            this.Name = "EliminarCategoria";
            this.Text = "EliminarCategoria";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarAceptar;
        private System.Windows.Forms.Button btnEliminarCancelar;
        private System.Windows.Forms.Label lblEliminarTitulo;
    }
}