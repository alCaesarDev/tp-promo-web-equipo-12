using System.ComponentModel;
using System.Windows.Forms;

namespace UI
{
    partial class Principal
    {
        private IContainer components = null;
        
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.vistaClientes = new UI.Articulos();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.vistaMarcas = new UI.Marcas();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.vistaCategorias = new UI.Categorias();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Controls.Add(this.tab3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 400);
            this.tabControl.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.vistaClientes);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(792, 374);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Articulos";
            // 
            // vistaClientes
            // 
            this.vistaClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaClientes.Location = new System.Drawing.Point(0, 0);
            this.vistaClientes.Name = "vistaClientes";
            this.vistaClientes.Size = new System.Drawing.Size(792, 374);
            this.vistaClientes.TabIndex = 0;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.vistaMarcas);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(792, 374);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Marcas";
            // 
            // vistaMarcas
            // 
            this.vistaMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaMarcas.Location = new System.Drawing.Point(0, 0);
            this.vistaMarcas.Name = "vistaMarcas";
            this.vistaMarcas.Size = new System.Drawing.Size(792, 374);
            this.vistaMarcas.TabIndex = 0;
            this.vistaMarcas.Load += new System.EventHandler(this.vistaMarcas_Load);
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.vistaCategorias);
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(792, 374);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Categorias";
            // 
            // vistaCategorias
            // 
            this.vistaCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaCategorias.Location = new System.Drawing.Point(0, 0);
            this.vistaCategorias.Name = "vistaCategorias";
            this.vistaCategorias.Size = new System.Drawing.Size(792, 374);
            this.vistaCategorias.TabIndex = 0;
            // 
            // Principal
            // 
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.tabControl);
            this.Name = "Principal";
            this.tabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tab1;
        private Articulos vistaClientes;
        private TabPage tab2;
        private Marcas vistaMarcas;
        private TabPage tab3;
        private Categorias vistaCategorias;
    }
}