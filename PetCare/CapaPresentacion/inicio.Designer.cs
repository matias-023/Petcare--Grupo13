namespace CapaPresentacion
{
    partial class inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            menuUsuario = new FontAwesome.Sharp.IconMenuItem();
            menuReabastecedor = new FontAwesome.Sharp.IconMenuItem();
            menuVentas = new FontAwesome.Sharp.IconMenuItem();
            menuCompras = new FontAwesome.Sharp.IconMenuItem();
            menuClientes = new FontAwesome.Sharp.IconMenuItem();
            menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            menuReportes = new FontAwesome.Sharp.IconMenuItem();
            menuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            menuTitulo = new MenuStrip();
            sistemaDeVentasToolStripMenuItem = new ToolStripMenuItem();
            contenedor = new Panel();
            menu.SuspendLayout();
            menuTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menuUsuario, menuReabastecedor, menuVentas, menuCompras, menuClientes, menuProveedores, menuReportes, menuAcercaDe });
            menu.Location = new Point(0, 52);
            menu.Name = "menu";
            menu.Padding = new Padding(5, 2, 0, 2);
            menu.Size = new Size(1088, 76);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuUsuario
            // 
            menuUsuario.AutoSize = false;
            menuUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            menuUsuario.IconColor = Color.Black;
            menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuario.ImageScaling = ToolStripItemImageScaling.None;
            menuUsuario.Name = "menuUsuario";
            menuUsuario.Size = new Size(132, 72);
            menuUsuario.Text = "Usuarios";
            menuUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuReabastecedor
            // 
            menuReabastecedor.AutoSize = false;
            menuReabastecedor.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            menuReabastecedor.IconColor = Color.Black;
            menuReabastecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReabastecedor.ImageScaling = ToolStripItemImageScaling.None;
            menuReabastecedor.Name = "menuReabastecedor";
            menuReabastecedor.Size = new Size(132, 72);
            menuReabastecedor.Text = "Reabastecedor";
            menuReabastecedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuVentas
            // 
            menuVentas.AutoSize = false;
            menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuVentas.IconColor = Color.Black;
            menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuVentas.ImageScaling = ToolStripItemImageScaling.None;
            menuVentas.Name = "menuVentas";
            menuVentas.Size = new Size(132, 72);
            menuVentas.Text = "Ventas";
            menuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuCompras
            // 
            menuCompras.AutoSize = false;
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            menuCompras.IconColor = Color.Black;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.ImageScaling = ToolStripItemImageScaling.None;
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(132, 72);
            menuCompras.Text = "Compras";
            menuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuClientes
            // 
            menuClientes.AutoSize = false;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            menuClientes.IconColor = Color.Black;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.ImageScaling = ToolStripItemImageScaling.None;
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(132, 72);
            menuClientes.Text = "Clientes";
            menuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuProveedores
            // 
            menuProveedores.AutoSize = false;
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            menuProveedores.IconColor = Color.Black;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(132, 72);
            menuProveedores.Text = "Proveedores";
            menuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuReportes
            // 
            menuReportes.AutoSize = false;
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menuReportes.IconColor = Color.Black;
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReportes.ImageScaling = ToolStripItemImageScaling.None;
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(132, 72);
            menuReportes.Text = "Reportes";
            menuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuAcercaDe
            // 
            menuAcercaDe.AutoSize = false;
            menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuAcercaDe.IconColor = Color.Black;
            menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            menuAcercaDe.Name = "menuAcercaDe";
            menuAcercaDe.Size = new Size(132, 72);
            menuAcercaDe.Text = "Acerca de";
            menuAcercaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = Color.SpringGreen;
            menuTitulo.ImageScalingSize = new Size(20, 20);
            menuTitulo.Items.AddRange(new ToolStripItem[] { sistemaDeVentasToolStripMenuItem });
            menuTitulo.Location = new Point(0, 0);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.Padding = new Padding(5, 2, 0, 2);
            menuTitulo.RightToLeft = RightToLeft.No;
            menuTitulo.Size = new Size(1088, 52);
            menuTitulo.TabIndex = 1;
            menuTitulo.Text = "menuStrip2";
            // 
            // sistemaDeVentasToolStripMenuItem
            // 
            sistemaDeVentasToolStripMenuItem.AutoSize = false;
            sistemaDeVentasToolStripMenuItem.Name = "sistemaDeVentasToolStripMenuItem";
            sistemaDeVentasToolStripMenuItem.Size = new Size(152, 65);
            sistemaDeVentasToolStripMenuItem.Text = "Sistema de ventas";
            sistemaDeVentasToolStripMenuItem.Click += sistemaDeVentasToolStripMenuItem_Click;
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 128);
            contenedor.Margin = new Padding(3, 2, 3, 2);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1088, 279);
            contenedor.TabIndex = 2;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 407);
            Controls.Add(contenedor);
            Controls.Add(menu);
            Controls.Add(menuTitulo);
            MainMenuStrip = menu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            menuTitulo.ResumeLayout(false);
            menuTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem menuUsuario;
        private ToolStripMenuItem sistemaDeVentasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuReabastecedor;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcercaDe;
        private Panel contenedor;
    }
}
