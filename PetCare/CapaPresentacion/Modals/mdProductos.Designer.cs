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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdProductos));
            panel1 = new Panel();
            BCerrar = new PictureBox();
            titulo = new Label();
            TIndice = new TextBox();
            TIdProducto = new TextBox();
            BCancelar = new FontAwesome.Sharp.IconButton();
            BAgregar = new FontAwesome.Sharp.IconButton();
            TCodigo = new TextBox();
            LCodigoProd = new Label();
            TNombre = new TextBox();
            LNombreProd = new Label();
            LStockProd = new Label();
            label1 = new Label();
            LPrecio = new Label();
            LPrecioVenta = new Label();
            CCategoria = new ComboBox();
            LCategoriaProd = new Label();
            CEstado = new ComboBox();
            LEstado = new Label();
            CMarca = new ComboBox();
            label2 = new Label();
            numStock = new NumericUpDown();
            numStockMin = new NumericUpDown();
            numPrecio = new NumericUpDown();
            numPrecioVenta = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).BeginInit();
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
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(182, 5);
            titulo.Name = "titulo";
            titulo.Size = new Size(171, 25);
            titulo.TabIndex = 9;
            titulo.Text = "Crear Producto";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TIndice
            // 
            TIndice.Location = new Point(458, 41);
            TIndice.Name = "TIndice";
            TIndice.Size = new Size(26, 21);
            TIndice.TabIndex = 33;
            TIndice.Text = "-1";
            TIndice.Visible = false;
            // 
            // TIdProducto
            // 
            TIdProducto.Location = new Point(490, 41);
            TIdProducto.Name = "TIdProducto";
            TIdProducto.Size = new Size(26, 21);
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
            BAgregar.Location = new Point(253, 442);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(124, 36);
            BAgregar.TabIndex = 10;
            BAgregar.Text = "Agregar";
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // TCodigo
            // 
            TCodigo.Font = new Font("Microsoft Sans Serif", 11F);
            TCodigo.Location = new Point(24, 77);
            TCodigo.Name = "TCodigo";
            TCodigo.Size = new Size(222, 24);
            TCodigo.TabIndex = 1;
            // 
            // LCodigoProd
            // 
            LCodigoProd.AutoSize = true;
            LCodigoProd.Font = new Font("Microsoft Sans Serif", 11F);
            LCodigoProd.Location = new Point(24, 56);
            LCodigoProd.Name = "LCodigoProd";
            LCodigoProd.Size = new Size(64, 18);
            LCodigoProd.TabIndex = 37;
            LCodigoProd.Text = "Codigo: ";
            // 
            // TNombre
            // 
            TNombre.Font = new Font("Microsoft Sans Serif", 11F);
            TNombre.Location = new Point(24, 137);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(222, 24);
            TNombre.TabIndex = 2;
            // 
            // LNombreProd
            // 
            LNombreProd.AutoSize = true;
            LNombreProd.Font = new Font("Microsoft Sans Serif", 11F);
            LNombreProd.Location = new Point(24, 116);
            LNombreProd.Name = "LNombreProd";
            LNombreProd.Size = new Size(66, 18);
            LNombreProd.TabIndex = 40;
            LNombreProd.Text = "Nombre:";
            // 
            // LStockProd
            // 
            LStockProd.AutoSize = true;
            LStockProd.Font = new Font("Microsoft Sans Serif", 11F);
            LStockProd.Location = new Point(24, 296);
            LStockProd.Name = "LStockProd";
            LStockProd.Size = new Size(51, 18);
            LStockProd.TabIndex = 42;
            LStockProd.Text = "Stock:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.Location = new Point(24, 357);
            label1.Name = "label1";
            label1.Size = new Size(104, 18);
            label1.TabIndex = 44;
            label1.Text = "Stock mínimo:";
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Font = new Font("Microsoft Sans Serif", 11F);
            LPrecio.Location = new Point(294, 56);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(55, 18);
            LPrecio.TabIndex = 46;
            LPrecio.Text = "Precio:";
            // 
            // LPrecioVenta
            // 
            LPrecioVenta.AutoSize = true;
            LPrecioVenta.Font = new Font("Microsoft Sans Serif", 11F);
            LPrecioVenta.Location = new Point(294, 116);
            LPrecioVenta.Name = "LPrecioVenta";
            LPrecioVenta.Size = new Size(96, 18);
            LPrecioVenta.TabIndex = 47;
            LPrecioVenta.Text = "Precio Venta:";
            // 
            // CCategoria
            // 
            CCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CCategoria.Font = new Font("Microsoft Sans Serif", 11F);
            CCategoria.FormattingEnabled = true;
            CCategoria.Location = new Point(24, 197);
            CCategoria.Name = "CCategoria";
            CCategoria.Size = new Size(222, 26);
            CCategoria.TabIndex = 3;
            // 
            // LCategoriaProd
            // 
            LCategoriaProd.AutoSize = true;
            LCategoriaProd.Font = new Font("Microsoft Sans Serif", 11F);
            LCategoriaProd.Location = new Point(24, 176);
            LCategoriaProd.Name = "LCategoriaProd";
            LCategoriaProd.Size = new Size(76, 18);
            LCategoriaProd.TabIndex = 49;
            LCategoriaProd.Text = "Categoria:";
            // 
            // CEstado
            // 
            CEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CEstado.Font = new Font("Microsoft Sans Serif", 11F);
            CEstado.FormattingEnabled = true;
            CEstado.Location = new Point(294, 197);
            CEstado.Name = "CEstado";
            CEstado.Size = new Size(222, 26);
            CEstado.TabIndex = 9;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Font = new Font("Microsoft Sans Serif", 11F);
            LEstado.Location = new Point(294, 176);
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(59, 18);
            LEstado.TabIndex = 52;
            LEstado.Text = "Estado:";
            // 
            // CMarca
            // 
            CMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            CMarca.Font = new Font("Microsoft Sans Serif", 11F);
            CMarca.FormattingEnabled = true;
            CMarca.Location = new Point(24, 257);
            CMarca.Name = "CMarca";
            CMarca.Size = new Size(222, 26);
            CMarca.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.Location = new Point(24, 236);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 53;
            label2.Text = "Marca:";
            // 
            // numStock
            // 
            numStock.Font = new Font("Microsoft Sans Serif", 11F);
            numStock.Location = new Point(23, 317);
            numStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(223, 24);
            numStock.TabIndex = 5;
            // 
            // numStockMin
            // 
            numStockMin.Font = new Font("Microsoft Sans Serif", 11F);
            numStockMin.Location = new Point(23, 378);
            numStockMin.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numStockMin.Name = "numStockMin";
            numStockMin.Size = new Size(223, 24);
            numStockMin.TabIndex = 6;
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Font = new Font("Microsoft Sans Serif", 11F);
            numPrecio.Location = new Point(294, 77);
            numPrecio.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(223, 24);
            numPrecio.TabIndex = 7;
            // 
            // numPrecioVenta
            // 
            numPrecioVenta.DecimalPlaces = 2;
            numPrecioVenta.Font = new Font("Microsoft Sans Serif", 11F);
            numPrecioVenta.Location = new Point(294, 137);
            numPrecioVenta.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numPrecioVenta.Name = "numPrecioVenta";
            numPrecioVenta.Size = new Size(223, 24);
            numPrecioVenta.TabIndex = 8;
            // 
            // mdProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 491);
            Controls.Add(numPrecioVenta);
            Controls.Add(numPrecio);
            Controls.Add(numStockMin);
            Controls.Add(numStock);
            Controls.Add(CMarca);
            Controls.Add(label2);
            Controls.Add(CEstado);
            Controls.Add(LEstado);
            Controls.Add(CCategoria);
            Controls.Add(LCategoriaProd);
            Controls.Add(LPrecioVenta);
            Controls.Add(LPrecio);
            Controls.Add(label1);
            Controls.Add(LStockProd);
            Controls.Add(TNombre);
            Controls.Add(LNombreProd);
            Controls.Add(TCodigo);
            Controls.Add(LCodigoProd);
            Controls.Add(BCancelar);
            Controls.Add(BAgregar);
            Controls.Add(TIndice);
            Controls.Add(TIdProducto);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mdProductos";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdProductos";
            Load += mdProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).EndInit();
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
        private TextBox TCodigo;
        private Label LCodigoProd;
        private TextBox TNombre;
        private Label LNombreProd;
        private Label LStockProd;
        private Label label1;
        private Label LPrecio;
        private Label LPrecioVenta;
        private ComboBox CCategoria;
        private Label LCategoriaProd;
        private ComboBox CEstado;
        private Label LEstado;
        private ComboBox CMarca;
        private Label label2;
        private NumericUpDown numStock;
        private NumericUpDown numStockMin;
        private NumericUpDown numPrecio;
        private NumericUpDown numPrecioVenta;
    }
}