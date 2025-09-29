namespace UI
{
    partial class CrearArticulo
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCrearArticuloCodigo = new System.Windows.Forms.Label();
            this.lblCrearArticuloNombre = new System.Windows.Forms.Label();
            this.lblCrearArticuloDescripcion = new System.Windows.Forms.Label();
            this.lblCrearArticuloMarca = new System.Windows.Forms.Label();
            this.lblCrearArticuloCategoria = new System.Windows.Forms.Label();
            this.lblCrearArticuloPrecio = new System.Windows.Forms.Label();
            this.lblImagenArticulo = new System.Windows.Forms.Label();
            this.txtCrearCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtCrearNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtCrearDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.txtCrearPrecioArticulo = new System.Windows.Forms.TextBox();
            this.listImagenes = new System.Windows.Forms.ListBox();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.btnCancelarArticulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCrearArticuloCodigo
            // 
            this.lblCrearArticuloCodigo.AutoSize = true;
            this.lblCrearArticuloCodigo.Location = new System.Drawing.Point(74, 44);
            this.lblCrearArticuloCodigo.Name = "lblCrearArticuloCodigo";
            this.lblCrearArticuloCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCrearArticuloCodigo.TabIndex = 0;
            this.lblCrearArticuloCodigo.Text = "Codigo:";
            // 
            // lblCrearArticuloNombre
            // 
            this.lblCrearArticuloNombre.AutoSize = true;
            this.lblCrearArticuloNombre.Location = new System.Drawing.Point(70, 75);
            this.lblCrearArticuloNombre.Name = "lblCrearArticuloNombre";
            this.lblCrearArticuloNombre.Size = new System.Drawing.Size(47, 13);
            this.lblCrearArticuloNombre.TabIndex = 1;
            this.lblCrearArticuloNombre.Text = "Nombre:";
            // 
            // lblCrearArticuloDescripcion
            // 
            this.lblCrearArticuloDescripcion.AutoSize = true;
            this.lblCrearArticuloDescripcion.Location = new System.Drawing.Point(51, 104);
            this.lblCrearArticuloDescripcion.Name = "lblCrearArticuloDescripcion";
            this.lblCrearArticuloDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblCrearArticuloDescripcion.TabIndex = 2;
            this.lblCrearArticuloDescripcion.Text = "Descripcion:";
            // 
            // lblCrearArticuloMarca
            // 
            this.lblCrearArticuloMarca.AutoSize = true;
            this.lblCrearArticuloMarca.Location = new System.Drawing.Point(77, 134);
            this.lblCrearArticuloMarca.Name = "lblCrearArticuloMarca";
            this.lblCrearArticuloMarca.Size = new System.Drawing.Size(40, 13);
            this.lblCrearArticuloMarca.TabIndex = 3;
            this.lblCrearArticuloMarca.Text = "Marca:";
            // 
            // lblCrearArticuloCategoria
            // 
            this.lblCrearArticuloCategoria.AutoSize = true;
            this.lblCrearArticuloCategoria.Location = new System.Drawing.Point(62, 163);
            this.lblCrearArticuloCategoria.Name = "lblCrearArticuloCategoria";
            this.lblCrearArticuloCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCrearArticuloCategoria.TabIndex = 4;
            this.lblCrearArticuloCategoria.Text = "Categoria:";
            // 
            // lblCrearArticuloPrecio
            // 
            this.lblCrearArticuloPrecio.AutoSize = true;
            this.lblCrearArticuloPrecio.Location = new System.Drawing.Point(77, 192);
            this.lblCrearArticuloPrecio.Name = "lblCrearArticuloPrecio";
            this.lblCrearArticuloPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblCrearArticuloPrecio.TabIndex = 5;
            this.lblCrearArticuloPrecio.Text = "Precio:";
            // 
            // lblImagenArticulo
            // 
            this.lblImagenArticulo.AutoSize = true;
            this.lblImagenArticulo.Location = new System.Drawing.Point(70, 220);
            this.lblImagenArticulo.Name = "lblImagenArticulo";
            this.lblImagenArticulo.Size = new System.Drawing.Size(45, 13);
            this.lblImagenArticulo.TabIndex = 17;
            this.lblImagenArticulo.Text = "Imagen:";
            // 
            // txtCrearCodigoArticulo
            // 
            this.txtCrearCodigoArticulo.Location = new System.Drawing.Point(129, 41);
            this.txtCrearCodigoArticulo.Name = "txtCrearCodigoArticulo";
            this.txtCrearCodigoArticulo.Size = new System.Drawing.Size(123, 20);
            this.txtCrearCodigoArticulo.TabIndex = 6;
            // 
            // txtCrearNombreArticulo
            // 
            this.txtCrearNombreArticulo.Location = new System.Drawing.Point(129, 75);
            this.txtCrearNombreArticulo.Name = "txtCrearNombreArticulo";
            this.txtCrearNombreArticulo.Size = new System.Drawing.Size(123, 20);
            this.txtCrearNombreArticulo.TabIndex = 7;
            // 
            // txtCrearDescripcionArticulo
            // 
            this.txtCrearDescripcionArticulo.Location = new System.Drawing.Point(129, 101);
            this.txtCrearDescripcionArticulo.Name = "txtCrearDescripcionArticulo";
            this.txtCrearDescripcionArticulo.Size = new System.Drawing.Size(123, 20);
            this.txtCrearDescripcionArticulo.TabIndex = 8;
            // 
            // txtCrearPrecioArticulo
            // 
            this.txtCrearPrecioArticulo.Location = new System.Drawing.Point(129, 189);
            this.txtCrearPrecioArticulo.Name = "txtCrearPrecioArticulo";
            this.txtCrearPrecioArticulo.Size = new System.Drawing.Size(123, 20);
            this.txtCrearPrecioArticulo.TabIndex = 11;
            // 
            // listImagenes
            // 
            this.listImagenes.FormattingEnabled = true;
            this.listImagenes.Location = new System.Drawing.Point(129, 217);
            this.listImagenes.Name = "listImagenes";
            this.listImagenes.Size = new System.Drawing.Size(123, 56);
            this.listImagenes.TabIndex = 18;
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(258, 217);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(29, 23);
            this.btnSeleccionarImagen.TabIndex = 19;
            this.btnSeleccionarImagen.Text = "...";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Location = new System.Drawing.Point(65, 290);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(86, 47);
            this.btnGuardarArticulo.TabIndex = 12;
            this.btnGuardarArticulo.Text = "Agregar";
            this.btnGuardarArticulo.UseVisualStyleBackColor = true;
            this.btnGuardarArticulo.Click += new System.EventHandler(this.btnGuardarArticulo_Click);
            // 
            // btnCancelarArticulo
            // 
            this.btnCancelarArticulo.Location = new System.Drawing.Point(201, 290);
            this.btnCancelarArticulo.Name = "btnCancelarArticulo";
            this.btnCancelarArticulo.Size = new System.Drawing.Size(86, 47);
            this.btnCancelarArticulo.TabIndex = 13;
            this.btnCancelarArticulo.Text = "Cancelar";
            this.btnCancelarArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarArticulo.Click += new System.EventHandler(this.btnCancelarArticulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Crea un Artículo";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(129, 131);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(123, 21);
            this.cboMarca.TabIndex = 15;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(129, 158);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(123, 21);
            this.cboCategoria.TabIndex = 16;
            // 
            // CrearArticulo
            // 
            this.ClientSize = new System.Drawing.Size(314, 361);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.listImagenes);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarArticulo);
            this.Controls.Add(this.btnGuardarArticulo);
            this.Controls.Add(this.txtCrearPrecioArticulo);
            this.Controls.Add(this.txtCrearDescripcionArticulo);
            this.Controls.Add(this.txtCrearNombreArticulo);
            this.Controls.Add(this.txtCrearCodigoArticulo);
            this.Controls.Add(this.lblImagenArticulo);
            this.Controls.Add(this.lblCrearArticuloPrecio);
            this.Controls.Add(this.lblCrearArticuloCategoria);
            this.Controls.Add(this.lblCrearArticuloMarca);
            this.Controls.Add(this.lblCrearArticuloDescripcion);
            this.Controls.Add(this.lblCrearArticuloNombre);
            this.Controls.Add(this.lblCrearArticuloCodigo);
            this.MaximumSize = new System.Drawing.Size(330, 400);
            this.MinimumSize = new System.Drawing.Size(330, 400);
            this.Name = "CrearArticulo";
            this.Text = "CrearArticulo";
            this.Load += new System.EventHandler(this.CrearArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCrearArticuloCodigo;
        private System.Windows.Forms.Label lblCrearArticuloNombre;
        private System.Windows.Forms.Label lblCrearArticuloDescripcion;
        private System.Windows.Forms.Label lblCrearArticuloMarca;
        private System.Windows.Forms.Label lblCrearArticuloCategoria;
        private System.Windows.Forms.Label lblCrearArticuloPrecio;
        private System.Windows.Forms.Label lblImagenArticulo;
        private System.Windows.Forms.TextBox txtCrearCodigoArticulo;
        private System.Windows.Forms.TextBox txtCrearNombreArticulo;
        private System.Windows.Forms.TextBox txtCrearDescripcionArticulo;
        private System.Windows.Forms.TextBox txtCrearPrecioArticulo;
        private System.Windows.Forms.ListBox listImagenes;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.Button btnGuardarArticulo;
        private System.Windows.Forms.Button btnCancelarArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
    }
}

