namespace CapaPresentacion.Modals
{
    partial class mdProductos
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
            panel1 = new Panel();
            BCerrar = new PictureBox();
            titulo = new Label();
            TIndice = new TextBox();
            TIdProducto = new TextBox();
            BCancelar = new FontAwesome.Sharp.IconButton();
            BAgregar = new FontAwesome.Sharp.IconButton();
            TCodProd = new TextBox();
            LCodigoProd = new Label();
            TNombreProd = new TextBox();
            LNombreProd = new Label();
            TStockProd = new TextBox();
            LStockProd = new Label();
            TStockMinProd = new TextBox();
            label1 = new Label();
            TPrecioProd = new TextBox();
            LPrecio = new Label();
            TPrecioVentaProd = new TextBox();
            LPrecioVenta = new Label();
            CCategoria = new ComboBox();
            LCategoriaProd = new Label();
            CEstado = new ComboBox();
            LEstado = new Label();
            CMarca = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(210, 120, 61);
            panel1.Controls.Add(BCerrar);
            panel1.Controls.Add(titulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 34);
            panel1.TabIndex = 1;
            // 
            // BCerrar
            // 
            BCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrar.BackColor = Color.FromArgb(210, 120, 61);
            BCerrar.Cursor = Cursors.Hand;
            BCerrar.Image = Properties.Resources.cerrar;
            BCerrar.Location = new Point(510, 5);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(25, 25);
            BCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            BCerrar.TabIndex = 9;
            BCerrar.TabStop = false;
            BCerrar.Click += BCerrar_Click;
            // 
            // titulo
            // 
            titulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(126, 4);
            titulo.Name = "titulo";
            titulo.Size = new Size(297, 26);
            titulo.TabIndex = 9;
            titulo.Text = "Crear Producto";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TIndice
            // 
            TIndice.Location = new Point(458, 41);
            TIndice.Name = "TIndice";
            TIndice.Size = new Size(26, 23);
            TIndice.TabIndex = 33;
            TIndice.Text = "-1";
            TIndice.Visible = false;
            // 
            // TIdProducto
            // 
            TIdProducto.Location = new Point(490, 41);
            TIdProducto.Name = "TIdProducto";
            TIdProducto.Size = new Size(26, 23);
            TIdProducto.TabIndex = 34;
            TIdProducto.Text = "0";
            TIdProducto.Visible = false;
            // 
            // BCancelar
            // 
            BCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BCancelar.BackColor = Color.Firebrick;
            BCancelar.Cursor = Cursors.Hand;
            BCancelar.FlatAppearance.BorderColor = Color.Black;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = Color.White;
            BCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            BCancelar.IconColor = Color.White;
            BCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BCancelar.IconSize = 30;
            BCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BCancelar.Location = new Point(399, 442);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(117, 36);
            BCancelar.TabIndex = 11;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // BAgregar
            // 
            BAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BAgregar.BackColor = Color.FromArgb(210, 120, 61);
            BAgregar.Cursor = Cursors.Hand;
            BAgregar.FlatAppearance.BorderColor = Color.Black;
            BAgregar.FlatStyle = FlatStyle.Flat;
            BAgregar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregar.ForeColor = Color.White;
            BAgregar.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            BAgregar.IconColor = Color.White;
            BAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregar.IconSize = 30;
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(270, 442);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(107, 36);
            BAgregar.TabIndex = 10;
            BAgregar.Text = "Agregar";
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            // 
            // TCodProd
            // 
            TCodProd.Font = new Font("Microsoft Sans Serif", 9.75F);
            TCodProd.Location = new Point(24, 77);
            TCodProd.Name = "TCodProd";
            TCodProd.Size = new Size(222, 22);
            TCodProd.TabIndex = 1;
            // 
            // LCodigoProd
            // 
            LCodigoProd.AutoSize = true;
            LCodigoProd.Font = new Font("Microsoft Sans Serif", 9.75F);
            LCodigoProd.Location = new Point(24, 59);
            LCodigoProd.Name = "LCodigoProd";
            LCodigoProd.Size = new Size(57, 16);
            LCodigoProd.TabIndex = 37;
            LCodigoProd.Text = "Codigo: ";
            // 
            // TNombreProd
            // 
            TNombreProd.Font = new Font("Microsoft Sans Serif", 9.75F);
            TNombreProd.Location = new Point(24, 137);
            TNombreProd.Name = "TNombreProd";
            TNombreProd.Size = new Size(222, 22);
            TNombreProd.TabIndex = 2;
            // 
            // LNombreProd
            // 
            LNombreProd.AutoSize = true;
            LNombreProd.Font = new Font("Microsoft Sans Serif", 9.75F);
            LNombreProd.Location = new Point(24, 119);
            LNombreProd.Name = "LNombreProd";
            LNombreProd.Size = new Size(59, 16);
            LNombreProd.TabIndex = 40;
            LNombreProd.Text = "Nombre:";
            // 
            // TStockProd
            // 
            TStockProd.Font = new Font("Microsoft Sans Serif", 9.75F);
            TStockProd.Location = new Point(23, 317);
            TStockProd.Name = "TStockProd";
            TStockProd.Size = new Size(222, 22);
            TStockProd.TabIndex = 5;
            // 
            // LStockProd
            // 
            LStockProd.AutoSize = true;
            LStockProd.Font = new Font("Microsoft Sans Serif", 9.75F);
            LStockProd.Location = new Point(24, 299);
            LStockProd.Name = "LStockProd";
            LStockProd.Size = new Size(44, 16);
            LStockProd.TabIndex = 42;
            LStockProd.Text = "Stock:";
            // 
            // TStockMinProd
            // 
            TStockMinProd.Font = new Font("Microsoft Sans Serif", 9.75F);
            TStockMinProd.Location = new Point(23, 377);
            TStockMinProd.Name = "TStockMinProd";
            TStockMinProd.Size = new Size(222, 22);
            TStockMinProd.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.Location = new Point(24, 359);
            label1.Name = "label1";
            label1.Size = new Size(90, 16);
            label1.TabIndex = 44;
            label1.Text = "Stock mínimo:";
            // 
            // TPrecioProd
            // 
            TPrecioProd.Font = new Font("Microsoft Sans Serif", 9.75F);
            TPrecioProd.Location = new Point(294, 77);
            TPrecioProd.Name = "TPrecioProd";
            TPrecioProd.PasswordChar = '*';
            TPrecioProd.Size = new Size(222, 22);
            TPrecioProd.TabIndex = 7;
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Font = new Font("Microsoft Sans Serif", 9.75F);
            LPrecio.Location = new Point(294, 59);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(49, 16);
            LPrecio.TabIndex = 46;
            LPrecio.Text = "Precio:";
            // 
            // TPrecioVentaProd
            // 
            TPrecioVentaProd.Font = new Font("Microsoft Sans Serif", 9.75F);
            TPrecioVentaProd.Location = new Point(294, 137);
            TPrecioVentaProd.Name = "TPrecioVentaProd";
            TPrecioVentaProd.PasswordChar = '*';
            TPrecioVentaProd.Size = new Size(222, 22);
            TPrecioVentaProd.TabIndex = 8;
            // 
            // LPrecioVenta
            // 
            LPrecioVenta.AutoSize = true;
            LPrecioVenta.Font = new Font("Microsoft Sans Serif", 9.75F);
            LPrecioVenta.Location = new Point(294, 119);
            LPrecioVenta.Name = "LPrecioVenta";
            LPrecioVenta.Size = new Size(87, 16);
            LPrecioVenta.TabIndex = 47;
            LPrecioVenta.Text = "Precio Venta:";
            // 
            // CCategoria
            // 
            CCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CCategoria.Font = new Font("Microsoft Sans Serif", 9.75F);
            CCategoria.FormattingEnabled = true;
            CCategoria.Location = new Point(24, 197);
            CCategoria.Name = "CCategoria";
            CCategoria.Size = new Size(222, 24);
            CCategoria.TabIndex = 3;
            // 
            // LCategoriaProd
            // 
            LCategoriaProd.AutoSize = true;
            LCategoriaProd.Font = new Font("Microsoft Sans Serif", 9.75F);
            LCategoriaProd.Location = new Point(23, 179);
            LCategoriaProd.Name = "LCategoriaProd";
            LCategoriaProd.Size = new Size(69, 16);
            LCategoriaProd.TabIndex = 49;
            LCategoriaProd.Text = "Categoria:";
            // 
            // CEstado
            // 
            CEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CEstado.Font = new Font("Microsoft Sans Serif", 9.75F);
            CEstado.FormattingEnabled = true;
            CEstado.Location = new Point(294, 197);
            CEstado.Name = "CEstado";
            CEstado.Size = new Size(222, 24);
            CEstado.TabIndex = 9;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Font = new Font("Microsoft Sans Serif", 9.75F);
            LEstado.Location = new Point(294, 179);
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(53, 16);
            LEstado.TabIndex = 52;
            LEstado.Text = "Estado:";
            // 
            // CMarca
            // 
            CMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            CMarca.Font = new Font("Microsoft Sans Serif", 9.75F);
            CMarca.FormattingEnabled = true;
            CMarca.Location = new Point(24, 257);
            CMarca.Name = "CMarca";
            CMarca.Size = new Size(222, 24);
            CMarca.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(23, 239);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 53;
            label2.Text = "Marca:";
            // 
            // mdProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 491);
            Controls.Add(CMarca);
            Controls.Add(label2);
            Controls.Add(CEstado);
            Controls.Add(LEstado);
            Controls.Add(CCategoria);
            Controls.Add(LCategoriaProd);
            Controls.Add(TPrecioVentaProd);
            Controls.Add(LPrecioVenta);
            Controls.Add(TPrecioProd);
            Controls.Add(LPrecio);
            Controls.Add(TStockMinProd);
            Controls.Add(label1);
            Controls.Add(TStockProd);
            Controls.Add(LStockProd);
            Controls.Add(TNombreProd);
            Controls.Add(LNombreProd);
            Controls.Add(TCodProd);
            Controls.Add(LCodigoProd);
            Controls.Add(BCancelar);
            Controls.Add(BAgregar);
            Controls.Add(TIndice);
            Controls.Add(TIdProducto);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mdProductos";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdProductos";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label titulo;
        private PictureBox BCerrar;
        private TextBox TIndice;
        private TextBox TIdProducto;
        private FontAwesome.Sharp.IconButton BCancelar;
        private FontAwesome.Sharp.IconButton BAgregar;
        private TextBox TCodProd;
        private Label LCodigoProd;
        private TextBox TNombreProd;
        private Label LNombreProd;
        private TextBox TStockProd;
        private Label LStockProd;
        private TextBox TStockMinProd;
        private Label label1;
        private TextBox TPrecioProd;
        private Label LPrecio;
        private TextBox TPrecioVentaProd;
        private Label LPrecioVenta;
        private ComboBox CCategoria;
        private Label LCategoriaProd;
        private ComboBox CEstado;
        private Label LEstado;
        private ComboBox CMarca;
        private Label label2;
    }
}