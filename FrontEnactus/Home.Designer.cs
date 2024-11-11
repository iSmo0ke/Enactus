namespace FrontEnactus
{
    partial class Home
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
            this.Search = new System.Windows.Forms.TextBox();
            this.Filtros = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPermisosDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableProductos = new System.Windows.Forms.DataGridView();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(36, 54);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(1000, 26);
            this.Search.TabIndex = 0;
            this.Search.Text = "Buscar producto";
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Filtros
            // 
            this.Filtros.Location = new System.Drawing.Point(1068, 54);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(163, 26);
            this.Filtros.TabIndex = 1;
            this.Filtros.Text = "Filtros de busqueda";
            this.Filtros.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.Menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.eliminarProductosToolStripMenuItem,
            this.editarProductosToolStripMenuItem,
            this.agrearUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.editarPermisosDeUsuarioToolStripMenuItem});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1407, 33);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(179, 29);
            this.agregarProductoToolStripMenuItem.Text = "Agregar productos";
            // 
            // eliminarProductosToolStripMenuItem
            // 
            this.eliminarProductosToolStripMenuItem.Name = "eliminarProductosToolStripMenuItem";
            this.eliminarProductosToolStripMenuItem.Size = new System.Drawing.Size(177, 29);
            this.eliminarProductosToolStripMenuItem.Text = "Eliminar productos";
            // 
            // editarProductosToolStripMenuItem
            // 
            this.editarProductosToolStripMenuItem.Name = "editarProductosToolStripMenuItem";
            this.editarProductosToolStripMenuItem.Size = new System.Drawing.Size(160, 29);
            this.editarProductosToolStripMenuItem.Text = "Editar productos";
            // 
            // agrearUsuarioToolStripMenuItem
            // 
            this.agrearUsuarioToolStripMenuItem.Name = "agrearUsuarioToolStripMenuItem";
            this.agrearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.agrearUsuarioToolStripMenuItem.Text = "Agrear usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(153, 29);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario";
            // 
            // editarPermisosDeUsuarioToolStripMenuItem
            // 
            this.editarPermisosDeUsuarioToolStripMenuItem.Name = "editarPermisosDeUsuarioToolStripMenuItem";
            this.editarPermisosDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(239, 29);
            this.editarPermisosDeUsuarioToolStripMenuItem.Text = "Editar permisos de usuario";
            // 
            // TableProductos
            // 
            this.TableProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableProductos.Location = new System.Drawing.Point(36, 110);
            this.TableProductos.Name = "TableProductos";
            this.TableProductos.RowHeadersWidth = 62;
            this.TableProductos.RowTemplate.Height = 28;
            this.TableProductos.Size = new System.Drawing.Size(1348, 691);
            this.TableProductos.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1407, 837);
            this.Controls.Add(this.TableProductos);
            this.Controls.Add(this.Filtros);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Home";
            this.Text = "Home";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button Filtros;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPermisosDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.DataGridView TableProductos;
    }
}