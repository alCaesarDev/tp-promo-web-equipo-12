namespace UI
{
    partial class EditarMarca
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
            this.btnAceptarEditarMarca = new System.Windows.Forms.Button();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.lblNuevaDescripcion = new System.Windows.Forms.Label();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.lblTituloEditarMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptarEditarMarca
            // 
            this.btnAceptarEditarMarca.Location = new System.Drawing.Point(38, 125);
            this.btnAceptarEditarMarca.Name = "btnAceptarEditarMarca";
            this.btnAceptarEditarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarEditarMarca.TabIndex = 0;
            this.btnAceptarEditarMarca.Text = "Aceptar";
            this.btnAceptarEditarMarca.UseVisualStyleBackColor = true;
            this.btnAceptarEditarMarca.Click += new System.EventHandler(this.btnAceptarEditarMarca_Click);
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.Location = new System.Drawing.Point(150, 125);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEdicion.TabIndex = 1;
            this.btnCancelarEdicion.Text = "Cancelar";
            this.btnCancelarEdicion.UseVisualStyleBackColor = true;
            this.btnCancelarEdicion.Click += new System.EventHandler(this.btnCancelarEdicion_Click);
            // 
            // lblNuevaDescripcion
            // 
            this.lblNuevaDescripcion.AutoSize = true;
            this.lblNuevaDescripcion.Location = new System.Drawing.Point(22, 76);
            this.lblNuevaDescripcion.Name = "lblNuevaDescripcion";
            this.lblNuevaDescripcion.Size = new System.Drawing.Size(104, 13);
            this.lblNuevaDescripcion.TabIndex = 2;
            this.lblNuevaDescripcion.Text = "Nueva Descripción: ";
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(132, 73);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtbDescripcion.TabIndex = 3;
            // 
            // lblTituloEditarMarca
            // 
            this.lblTituloEditarMarca.AutoSize = true;
            this.lblTituloEditarMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEditarMarca.Location = new System.Drawing.Point(70, 30);
            this.lblTituloEditarMarca.Name = "lblTituloEditarMarca";
            this.lblTituloEditarMarca.Size = new System.Drawing.Size(127, 21);
            this.lblTituloEditarMarca.TabIndex = 4;
            this.lblTituloEditarMarca.Text = "EDITAR MARCA";
            // 
            // EditarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 213);
            this.Controls.Add(this.lblTituloEditarMarca);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.lblNuevaDescripcion);
            this.Controls.Add(this.btnCancelarEdicion);
            this.Controls.Add(this.btnAceptarEditarMarca);
            this.MaximumSize = new System.Drawing.Size(291, 252);
            this.MinimumSize = new System.Drawing.Size(291, 252);
            this.Name = "EditarMarca";
            this.Text = "Editar Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarEditarMarca;
        private System.Windows.Forms.Button btnCancelarEdicion;
        private System.Windows.Forms.Label lblNuevaDescripcion;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.Label lblTituloEditarMarca;
    }
}