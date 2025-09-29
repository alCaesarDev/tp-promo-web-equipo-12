namespace UI
{
    partial class EditarCategoria
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
            this.lblModificarDescripcion = new System.Windows.Forms.Label();
            this.txtModificarDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardarMod = new System.Windows.Forms.Button();
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.lblTituloModifica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModificarDescripcion
            // 
            this.lblModificarDescripcion.AutoSize = true;
            this.lblModificarDescripcion.Location = new System.Drawing.Point(24, 127);
            this.lblModificarDescripcion.Name = "lblModificarDescripcion";
            this.lblModificarDescripcion.Size = new System.Drawing.Size(96, 13);
            this.lblModificarDescripcion.TabIndex = 0;
            this.lblModificarDescripcion.Text = "Editar Descripcion:";
          
            // 
            // txtModificarDescripcion
            // 
            this.txtModificarDescripcion.Location = new System.Drawing.Point(145, 124);
            this.txtModificarDescripcion.Name = "txtModificarDescripcion";
            this.txtModificarDescripcion.Size = new System.Drawing.Size(147, 20);
            this.txtModificarDescripcion.TabIndex = 1;
            // 
            // btnGuardarMod
            // 
            this.btnGuardarMod.Location = new System.Drawing.Point(35, 208);
            this.btnGuardarMod.Name = "btnGuardarMod";
            this.btnGuardarMod.Size = new System.Drawing.Size(108, 39);
            this.btnGuardarMod.TabIndex = 2;
            this.btnGuardarMod.Text = "Guardar";
            this.btnGuardarMod.UseVisualStyleBackColor = true;
            this.btnGuardarMod.Click += new System.EventHandler(this.btnGuardarMod_Click);
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.Location = new System.Drawing.Point(184, 208);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(108, 39);
            this.btnCancelarMod.TabIndex = 3;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = true;
            this.btnCancelarMod.Click += new System.EventHandler(this.btnCancelarMod_Click);
            // 
            // lblTituloModifica
            // 
            this.lblTituloModifica.AutoSize = true;
            this.lblTituloModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModifica.Location = new System.Drawing.Point(81, 70);
            this.lblTituloModifica.Name = "lblTituloModifica";
            this.lblTituloModifica.Size = new System.Drawing.Size(165, 20);
            this.lblTituloModifica.TabIndex = 4;
            this.lblTituloModifica.Text = "Editar la Categoría";
            // 
            // EditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.lblTituloModifica);
            this.Controls.Add(this.btnCancelarMod);
            this.Controls.Add(this.btnGuardarMod);
            this.Controls.Add(this.txtModificarDescripcion);
            this.Controls.Add(this.lblModificarDescripcion);
            this.MaximumSize = new System.Drawing.Size(330, 330);
            this.MinimumSize = new System.Drawing.Size(330, 330);
            this.Name = "EditarCategoria";
            this.Text = "EditarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificarDescripcion;
        private System.Windows.Forms.TextBox txtModificarDescripcion;
        private System.Windows.Forms.Button btnGuardarMod;
        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.Label lblTituloModifica;
    }
}