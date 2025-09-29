namespace UI
{
    partial class CrearCategoria
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
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.txtIngreseDescripcion = new System.Windows.Forms.TextBox();
            this.lblIngreseDescripcion = new System.Windows.Forms.Label();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Location = new System.Drawing.Point(29, 216);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(108, 39);
            this.btnGuardarCategoria.TabIndex = 0;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCategoria.Location = new System.Drawing.Point(173, 216);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(108, 39);
            this.btnCancelarCategoria.TabIndex = 1;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIngreseDescripcion
            // 
            this.txtIngreseDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIngreseDescripcion.Location = new System.Drawing.Point(134, 142);
            this.txtIngreseDescripcion.Name = "txtIngreseDescripcion";
            this.txtIngreseDescripcion.Size = new System.Drawing.Size(147, 20);
            this.txtIngreseDescripcion.TabIndex = 3;
            // 
            // lblIngreseDescripcion
            // 
            this.lblIngreseDescripcion.AutoSize = true;
            this.lblIngreseDescripcion.Location = new System.Drawing.Point(12, 145);
            this.lblIngreseDescripcion.Name = "lblIngreseDescripcion";
            this.lblIngreseDescripcion.Size = new System.Drawing.Size(104, 13);
            this.lblIngreseDescripcion.TabIndex = 5;
            this.lblIngreseDescripcion.Text = "Ingrese Descripcion:";
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.Location = new System.Drawing.Point(84, 72);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(165, 20);
            this.lblTituloCategoria.TabIndex = 6;
            this.lblTituloCategoria.Text = "Crea una Categoria";
            // 
            // CrearCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.lblTituloCategoria);
            this.Controls.Add(this.lblIngreseDescripcion);
            this.Controls.Add(this.txtIngreseDescripcion);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnGuardarCategoria);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 330);
            this.Name = "CrearCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Categoría";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.TextBox txtIngreseDescripcion;
        private System.Windows.Forms.Label lblIngreseDescripcion;
        private System.Windows.Forms.Label lblTituloCategoria;
    }
}