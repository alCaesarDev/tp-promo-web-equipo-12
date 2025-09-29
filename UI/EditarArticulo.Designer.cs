namespace UI
{
    partial class EditarArticulo
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
            this.cboEditarArticuloCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarcaEditarArticulo = new System.Windows.Forms.ComboBox();
            this.lblTituloEditarArticulo = new System.Windows.Forms.Label();
            this.btnCancelarArticuloEditado = new System.Windows.Forms.Button();
            this.btnGuardarArticuloEditado = new System.Windows.Forms.Button();
            this.txtEditarPrecioArticulo = new System.Windows.Forms.TextBox();
            this.txtEditarDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.txtEditarNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtEditarCodigoArticulo = new System.Windows.Forms.TextBox();
            this.lblEditarArticuloPrecio = new System.Windows.Forms.Label();
            this.lblEditarCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblEditarArticuloMarca = new System.Windows.Forms.Label();
            this.lblEditarArticuloDescripcion = new System.Windows.Forms.Label();
            this.lblEditarArticuloNombre = new System.Windows.Forms.Label();
            this.lblEditarArticuloCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboEditarArticuloCategoria
            // 
            this.cboEditarArticuloCategoria.FormattingEnabled = true;
            this.cboEditarArticuloCategoria.Location = new System.Drawing.Point(125, 181);
            this.cboEditarArticuloCategoria.Name = "cboEditarArticuloCategoria";
            this.cboEditarArticuloCategoria.Size = new System.Drawing.Size(123, 21);
            this.cboEditarArticuloCategoria.TabIndex = 31;
            // 
            // cboMarcaEditarArticulo
            // 
            this.cboMarcaEditarArticulo.FormattingEnabled = true;
            this.cboMarcaEditarArticulo.Location = new System.Drawing.Point(125, 154);
            this.cboMarcaEditarArticulo.Name = "cboMarcaEditarArticulo";
            this.cboMarcaEditarArticulo.Size = new System.Drawing.Size(123, 21);
            this.cboMarcaEditarArticulo.TabIndex = 30;
            // 
            // lblTituloEditarArticulo
            // 
            this.lblTituloEditarArticulo.AutoSize = true;
            this.lblTituloEditarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEditarArticulo.Location = new System.Drawing.Point(97, 32);
            this.lblTituloEditarArticulo.Name = "lblTituloEditarArticulo";
            this.lblTituloEditarArticulo.Size = new System.Drawing.Size(142, 20);
            this.lblTituloEditarArticulo.TabIndex = 29;
            this.lblTituloEditarArticulo.Text = "Edita un Articulo";
            // 
            // btnCancelarArticuloEditado
            // 
            this.btnCancelarArticuloEditado.Location = new System.Drawing.Point(197, 253);
            this.btnCancelarArticuloEditado.Name = "btnCancelarArticuloEditado";
            this.btnCancelarArticuloEditado.Size = new System.Drawing.Size(86, 47);
            this.btnCancelarArticuloEditado.TabIndex = 28;
            this.btnCancelarArticuloEditado.Text = "Cancelar";
            this.btnCancelarArticuloEditado.UseVisualStyleBackColor = true;
            this.btnCancelarArticuloEditado.Click += new System.EventHandler(this.btnCancelarArticuloEditado_Click);
            // 
            // btnGuardarArticuloEditado
            // 
            this.btnGuardarArticuloEditado.Location = new System.Drawing.Point(61, 253);
            this.btnGuardarArticuloEditado.Name = "btnGuardarArticuloEditado";
            this.btnGuardarArticuloEditado.Size = new System.Drawing.Size(86, 47);
            this.btnGuardarArticuloEditado.TabIndex = 27;
            this.btnGuardarArticuloEditado.Text = "Agregar";
            this.btnGuardarArticuloEditado.UseVisualStyleBackColor = true;
            this.btnGuardarArticuloEditado.Click += new System.EventHandler(this.btnGuardarArticuloEditado_Click);
            // 
            // txtEditarPrecioArticulo
            // 
            this.txtEditarPrecioArticulo.Location = new System.Drawing.Point(125, 212);
            this.txtEditarPrecioArticulo.Name = "txtEditarPrecioArticulo";
            this.txtEditarPrecioArticulo.Size = new System.Drawing.Size(123, 20);
            this.txtEditarPrecioArticulo.TabIndex = 26;
            // 
            // txtEditarDescripcionArticulo
            // 
            this.txtEditarDescripcionArticulo.Location = new System.Drawing.Point(125, 124);
            this.txtEditarDescripcionArticulo.Name = "txtEditarDescripcionArticulo";
            this.txtEditarDescripcionArticulo.Size = new System.Drawing.Size(123, 20);
            this.txtEditarDescripcionArticulo.TabIndex = 25;
            // 
            // txtEditarNombreArticulo
            // 
            this.txtEditarNombreArticulo.Location = new System.Drawing.Point(125, 98);
            this.txtEditarNombreArticulo.Name = "txtEditarNombreArticulo";
            this.txtEditarNombreArticulo.Size = new System.Drawing.Size(123, 20);
            this.txtEditarNombreArticulo.TabIndex = 24;
            // 
            // txtEditarCodigoArticulo
            // 
            this.txtEditarCodigoArticulo.Location = new System.Drawing.Point(125, 64);
            this.txtEditarCodigoArticulo.Name = "txtEditarCodigoArticulo";
            this.txtEditarCodigoArticulo.Size = new System.Drawing.Size(123, 20);
            this.txtEditarCodigoArticulo.TabIndex = 23;
            // 
            // lblEditarArticuloPrecio
            // 
            this.lblEditarArticuloPrecio.AutoSize = true;
            this.lblEditarArticuloPrecio.Location = new System.Drawing.Point(73, 215);
            this.lblEditarArticuloPrecio.Name = "lblEditarArticuloPrecio";
            this.lblEditarArticuloPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblEditarArticuloPrecio.TabIndex = 22;
            this.lblEditarArticuloPrecio.Text = "Precio:";
            // 
            // lblEditarCategoriaArticulo
            // 
            this.lblEditarCategoriaArticulo.AutoSize = true;
            this.lblEditarCategoriaArticulo.Location = new System.Drawing.Point(58, 186);
            this.lblEditarCategoriaArticulo.Name = "lblEditarCategoriaArticulo";
            this.lblEditarCategoriaArticulo.Size = new System.Drawing.Size(55, 13);
            this.lblEditarCategoriaArticulo.TabIndex = 21;
            this.lblEditarCategoriaArticulo.Text = "Categoria:";
            // 
            // lblEditarArticuloMarca
            // 
            this.lblEditarArticuloMarca.AutoSize = true;
            this.lblEditarArticuloMarca.Location = new System.Drawing.Point(73, 157);
            this.lblEditarArticuloMarca.Name = "lblEditarArticuloMarca";
            this.lblEditarArticuloMarca.Size = new System.Drawing.Size(40, 13);
            this.lblEditarArticuloMarca.TabIndex = 20;
            this.lblEditarArticuloMarca.Text = "Marca:";
            // 
            // lblEditarArticuloDescripcion
            // 
            this.lblEditarArticuloDescripcion.AutoSize = true;
            this.lblEditarArticuloDescripcion.Location = new System.Drawing.Point(47, 127);
            this.lblEditarArticuloDescripcion.Name = "lblEditarArticuloDescripcion";
            this.lblEditarArticuloDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblEditarArticuloDescripcion.TabIndex = 19;
            this.lblEditarArticuloDescripcion.Text = "Descripcion:";
            // 
            // lblEditarArticuloNombre
            // 
            this.lblEditarArticuloNombre.AutoSize = true;
            this.lblEditarArticuloNombre.Location = new System.Drawing.Point(66, 98);
            this.lblEditarArticuloNombre.Name = "lblEditarArticuloNombre";
            this.lblEditarArticuloNombre.Size = new System.Drawing.Size(47, 13);
            this.lblEditarArticuloNombre.TabIndex = 18;
            this.lblEditarArticuloNombre.Text = "Nombre:";
            // 
            // lblEditarArticuloCodigo
            // 
            this.lblEditarArticuloCodigo.AutoSize = true;
            this.lblEditarArticuloCodigo.Location = new System.Drawing.Point(70, 67);
            this.lblEditarArticuloCodigo.Name = "lblEditarArticuloCodigo";
            this.lblEditarArticuloCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblEditarArticuloCodigo.TabIndex = 17;
            this.lblEditarArticuloCodigo.Text = "Codigo:";
            // 
            // EditarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 332);
            this.Controls.Add(this.cboEditarArticuloCategoria);
            this.Controls.Add(this.cboMarcaEditarArticulo);
            this.Controls.Add(this.lblTituloEditarArticulo);
            this.Controls.Add(this.btnCancelarArticuloEditado);
            this.Controls.Add(this.btnGuardarArticuloEditado);
            this.Controls.Add(this.txtEditarPrecioArticulo);
            this.Controls.Add(this.txtEditarDescripcionArticulo);
            this.Controls.Add(this.txtEditarNombreArticulo);
            this.Controls.Add(this.txtEditarCodigoArticulo);
            this.Controls.Add(this.lblEditarArticuloPrecio);
            this.Controls.Add(this.lblEditarCategoriaArticulo);
            this.Controls.Add(this.lblEditarArticuloMarca);
            this.Controls.Add(this.lblEditarArticuloDescripcion);
            this.Controls.Add(this.lblEditarArticuloNombre);
            this.Controls.Add(this.lblEditarArticuloCodigo);
            this.MaximumSize = new System.Drawing.Size(359, 371);
            this.MinimumSize = new System.Drawing.Size(359, 371);
            this.Name = "EditarArticulo";
            this.Text = "Editar Artículo";
            this.Load += new System.EventHandler(this.EditarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEditarArticuloCategoria;
        private System.Windows.Forms.ComboBox cboMarcaEditarArticulo;
        private System.Windows.Forms.Label lblTituloEditarArticulo;
        private System.Windows.Forms.Button btnCancelarArticuloEditado;
        private System.Windows.Forms.Button btnGuardarArticuloEditado;
        private System.Windows.Forms.TextBox txtEditarPrecioArticulo;
        private System.Windows.Forms.TextBox txtEditarDescripcionArticulo;
        private System.Windows.Forms.TextBox txtEditarNombreArticulo;
        private System.Windows.Forms.TextBox txtEditarCodigoArticulo;
        private System.Windows.Forms.Label lblEditarArticuloPrecio;
        private System.Windows.Forms.Label lblEditarCategoriaArticulo;
        private System.Windows.Forms.Label lblEditarArticuloMarca;
        private System.Windows.Forms.Label lblEditarArticuloDescripcion;
        private System.Windows.Forms.Label lblEditarArticuloNombre;
        private System.Windows.Forms.Label lblEditarArticuloCodigo;
    }
}