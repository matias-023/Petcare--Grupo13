namespace CapaPresentacion
{
    partial class frmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label8 = new Label();
            CBusqueda = new ComboBox();
            label9 = new Label();
            TBusqueda = new TextBox();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            CCategoria = new ComboBox();
            LCategoriaProd = new Label();
            TPrecioVentaProd = new TextBox();
            TIndice = new TextBox();
            CEstado = new ComboBox();
            LEstado = new Label();
            TIdUsuario = new TextBox();
            BLimpiar = new FontAwesome.Sharp.IconButton();
            BGuardarProd = new FontAwesome.Sharp.IconButton();
            LPrecioVenta = new Label();
            TPrecioProd = new TextBox();
            LPrecio = new Label();
            TStockProd = new TextBox();
            LStockProd = new Label();
            TNombreProd = new TextBox();
            LNombreProd = new Label();
            TCodProd = new TextBox();
            LCodigoProd = new Label();
            dgvDataProd = new DataGridView();
            BSeleccionar = new DataGridViewButtonColumn();
            idUsuario = new DataGridViewTextBoxColumn();
            CodigoProd = new DataGridViewTextBoxColumn();
            nombreProd = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            precioProd = new DataGridViewTextBoxColumn();
            precioVtaProd = new DataGridViewTextBoxColumn();
            idCategoria = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            estadoValorProd = new DataGridViewTextBoxColumn();
            estadoProd = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataProd).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(381, 56);
            label8.Name = "label8";
            label8.Size = new Size(1155, 90);
            label8.TabIndex = 3;
            label8.Text = "Lista de Productos:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            label8.Click += label8_Click;
            // 
            // CBusqueda
            // 
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(789, 94);
            CBusqueda.Margin = new Padding(3, 4, 3, 4);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(198, 28);
            CBusqueda.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(701, 97);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 10;
            label9.Text = "Buscar por:";
            // 
            // TBusqueda
            // 
            TBusqueda.Location = new Point(1021, 94);
            TBusqueda.Margin = new Padding(3, 4, 3, 4);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(246, 27);
            TBusqueda.TabIndex = 11;
            // 
            // BBusqueda
            // 
            BBusqueda.BackColor = Color.White;
            BBusqueda.Cursor = Cursors.Hand;
            BBusqueda.FlatAppearance.BorderColor = Color.Black;
            BBusqueda.FlatStyle = FlatStyle.Flat;
            BBusqueda.ForeColor = Color.White;
            BBusqueda.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBusqueda.IconColor = Color.Black;
            BBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBusqueda.IconSize = 20;
            BBusqueda.Location = new Point(1286, 88);
            BBusqueda.Margin = new Padding(3, 4, 3, 4);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(54, 39);
            BBusqueda.TabIndex = 12;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
            // 
            // BLimpiarBusqueda
            // 
            BLimpiarBusqueda.BackColor = Color.White;
            BLimpiarBusqueda.Cursor = Cursors.Hand;
            BLimpiarBusqueda.FlatAppearance.BorderColor = Color.Black;
            BLimpiarBusqueda.FlatStyle = FlatStyle.Flat;
            BLimpiarBusqueda.ForeColor = Color.White;
            BLimpiarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Broom;
            BLimpiarBusqueda.IconColor = Color.Black;
            BLimpiarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BLimpiarBusqueda.IconSize = 20;
            BLimpiarBusqueda.Location = new Point(1346, 88);
            BLimpiarBusqueda.Margin = new Padding(3, 4, 3, 4);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(54, 39);
            BLimpiarBusqueda.TabIndex = 13;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(CCategoria);
            panel1.Controls.Add(LCategoriaProd);
            panel1.Controls.Add(TPrecioVentaProd);
            panel1.Controls.Add(TIndice);
            panel1.Controls.Add(CEstado);
            panel1.Controls.Add(LEstado);
            panel1.Controls.Add(TIdUsuario);
            panel1.Controls.Add(BLimpiar);
            panel1.Controls.Add(BGuardarProd);
            panel1.Controls.Add(LPrecioVenta);
            panel1.Controls.Add(TPrecioProd);
            panel1.Controls.Add(LPrecio);
            panel1.Controls.Add(TStockProd);
            panel1.Controls.Add(LStockProd);
            panel1.Controls.Add(TNombreProd);
            panel1.Controls.Add(LNombreProd);
            panel1.Controls.Add(TCodProd);
            panel1.Controls.Add(LCodigoProd);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 785);
            panel1.TabIndex = 14;
            // 
            // CCategoria
            // 
            CCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CCategoria.FormattingEnabled = true;
            CCategoria.Location = new Point(32, 448);
            CCategoria.Margin = new Padding(3, 4, 3, 4);
            CCategoria.Name = "CCategoria";
            CCategoria.Size = new Size(253, 28);
            CCategoria.TabIndex = 21;
            // 
            // LCategoriaProd
            // 
            LCategoriaProd.AutoSize = true;
            LCategoriaProd.Location = new Point(31, 424);
            LCategoriaProd.Name = "LCategoriaProd";
            LCategoriaProd.Size = new Size(77, 20);
            LCategoriaProd.TabIndex = 20;
            LCategoriaProd.Text = "Categoria:";
            // 
            // TPrecioVentaProd
            // 
            TPrecioVentaProd.Location = new Point(31, 378);
            TPrecioVentaProd.Margin = new Padding(3, 4, 3, 4);
            TPrecioVentaProd.Name = "TPrecioVentaProd";
            TPrecioVentaProd.PasswordChar = '*';
            TPrecioVentaProd.Size = new Size(253, 27);
            TPrecioVentaProd.TabIndex = 17;
            // 
            // TIndice
            // 
            TIndice.Location = new Point(221, 16);
            TIndice.Margin = new Padding(3, 4, 3, 4);
            TIndice.Name = "TIndice";
            TIndice.Size = new Size(29, 27);
            TIndice.TabIndex = 16;
            TIndice.Text = "-1";
            TIndice.Visible = false;
            // 
            // CEstado
            // 
            CEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CEstado.FormattingEnabled = true;
            CEstado.Location = new Point(33, 515);
            CEstado.Margin = new Padding(3, 4, 3, 4);
            CEstado.Name = "CEstado";
            CEstado.Size = new Size(253, 28);
            CEstado.TabIndex = 8;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Location = new Point(33, 491);
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(57, 20);
            LEstado.TabIndex = 14;
            LEstado.Text = "Estado:";
            // 
            // TIdUsuario
            // 
            TIdUsuario.Location = new Point(257, 16);
            TIdUsuario.Margin = new Padding(3, 4, 3, 4);
            TIdUsuario.Name = "TIdUsuario";
            TIdUsuario.Size = new Size(29, 27);
            TIdUsuario.TabIndex = 13;
            TIdUsuario.Text = "0";
            TIdUsuario.Visible = false;
            // 
            // BLimpiar
            // 
            BLimpiar.BackColor = Color.RoyalBlue;
            BLimpiar.Cursor = Cursors.Hand;
            BLimpiar.FlatAppearance.BorderColor = Color.Black;
            BLimpiar.FlatStyle = FlatStyle.Flat;
            BLimpiar.ForeColor = Color.White;
            BLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            BLimpiar.IconColor = Color.White;
            BLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BLimpiar.IconSize = 16;
            BLimpiar.Location = new Point(33, 609);
            BLimpiar.Margin = new Padding(3, 4, 3, 4);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(254, 33);
            BLimpiar.TabIndex = 10;
            BLimpiar.Text = "Limpiar";
            BLimpiar.TextAlign = ContentAlignment.MiddleRight;
            BLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiar.UseVisualStyleBackColor = false;
            // 
            // BGuardarProd
            // 
            BGuardarProd.BackColor = Color.ForestGreen;
            BGuardarProd.Cursor = Cursors.Hand;
            BGuardarProd.FlatAppearance.BorderColor = Color.Black;
            BGuardarProd.FlatStyle = FlatStyle.Flat;
            BGuardarProd.ForeColor = Color.White;
            BGuardarProd.IconChar = FontAwesome.Sharp.IconChar.Save;
            BGuardarProd.IconColor = Color.White;
            BGuardarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BGuardarProd.IconSize = 16;
            BGuardarProd.Location = new Point(33, 568);
            BGuardarProd.Margin = new Padding(3, 4, 3, 4);
            BGuardarProd.Name = "BGuardarProd";
            BGuardarProd.Size = new Size(254, 33);
            BGuardarProd.TabIndex = 9;
            BGuardarProd.Text = "Añadir Producto";
            BGuardarProd.TextAlign = ContentAlignment.MiddleRight;
            BGuardarProd.TextImageRelation = TextImageRelation.ImageBeforeText;
            BGuardarProd.UseVisualStyleBackColor = false;
            // 
            // LPrecioVenta
            // 
            LPrecioVenta.AutoSize = true;
            LPrecioVenta.Location = new Point(31, 354);
            LPrecioVenta.Name = "LPrecioVenta";
            LPrecioVenta.Size = new Size(94, 20);
            LPrecioVenta.TabIndex = 12;
            LPrecioVenta.Text = "Precio Venta:";
            // 
            // TPrecioProd
            // 
            TPrecioProd.Location = new Point(31, 304);
            TPrecioProd.Margin = new Padding(3, 4, 3, 4);
            TPrecioProd.Name = "TPrecioProd";
            TPrecioProd.PasswordChar = '*';
            TPrecioProd.Size = new Size(253, 27);
            TPrecioProd.TabIndex = 6;
            TPrecioProd.TextChanged += TPrecio_TextChanged;
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Location = new Point(33, 280);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(53, 20);
            LPrecio.TabIndex = 10;
            LPrecio.Text = "Precio:";
            // 
            // TStockProd
            // 
            TStockProd.Location = new Point(32, 228);
            TStockProd.Margin = new Padding(3, 4, 3, 4);
            TStockProd.Name = "TStockProd";
            TStockProd.Size = new Size(253, 27);
            TStockProd.TabIndex = 4;
            // 
            // LStockProd
            // 
            LStockProd.AutoSize = true;
            LStockProd.Location = new Point(32, 204);
            LStockProd.Name = "LStockProd";
            LStockProd.Size = new Size(48, 20);
            LStockProd.TabIndex = 6;
            LStockProd.Text = "Stock:";
            // 
            // TNombreProd
            // 
            TNombreProd.Location = new Point(32, 154);
            TNombreProd.Margin = new Padding(3, 4, 3, 4);
            TNombreProd.Name = "TNombreProd";
            TNombreProd.Size = new Size(253, 27);
            TNombreProd.TabIndex = 2;
            // 
            // LNombreProd
            // 
            LNombreProd.AutoSize = true;
            LNombreProd.Location = new Point(33, 116);
            LNombreProd.Name = "LNombreProd";
            LNombreProd.Size = new Size(131, 20);
            LNombreProd.TabIndex = 2;
            LNombreProd.Text = "Nombre Producto:";
            // 
            // TCodProd
            // 
            TCodProd.Location = new Point(33, 64);
            TCodProd.Margin = new Padding(3, 4, 3, 4);
            TCodProd.Name = "TCodProd";
            TCodProd.Size = new Size(253, 27);
            TCodProd.TabIndex = 1;
            // 
            // LCodigoProd
            // 
            LCodigoProd.AutoSize = true;
            LCodigoProd.Location = new Point(33, 40);
            LCodigoProd.Name = "LCodigoProd";
            LCodigoProd.Size = new Size(65, 20);
            LCodigoProd.TabIndex = 0;
            LCodigoProd.Text = "Codigo: ";
            // 
            // dgvDataProd
            // 
            dgvDataProd.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDataProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDataProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataProd.Columns.AddRange(new DataGridViewColumn[] { BSeleccionar, idUsuario, CodigoProd, nombreProd, stock, precioProd, precioVtaProd, idCategoria, categoria, estadoValorProd, estadoProd });
            dgvDataProd.Location = new Point(381, 156);
            dgvDataProd.Margin = new Padding(3, 4, 3, 4);
            dgvDataProd.MultiSelect = false;
            dgvDataProd.Name = "dgvDataProd";
            dgvDataProd.ReadOnly = true;
            dgvDataProd.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvDataProd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDataProd.RowTemplate.Height = 28;
            dgvDataProd.Size = new Size(1155, 605);
            dgvDataProd.TabIndex = 15;
            // 
            // BSeleccionar
            // 
            BSeleccionar.HeaderText = "";
            BSeleccionar.MinimumWidth = 6;
            BSeleccionar.Name = "BSeleccionar";
            BSeleccionar.ReadOnly = true;
            BSeleccionar.Width = 35;
            // 
            // idUsuario
            // 
            idUsuario.HeaderText = "ID";
            idUsuario.MinimumWidth = 6;
            idUsuario.Name = "idUsuario";
            idUsuario.ReadOnly = true;
            idUsuario.Visible = false;
            idUsuario.Width = 125;
            // 
            // CodigoProd
            // 
            CodigoProd.HeaderText = "Código";
            CodigoProd.MinimumWidth = 6;
            CodigoProd.Name = "CodigoProd";
            CodigoProd.ReadOnly = true;
            CodigoProd.Width = 125;
            // 
            // nombreProd
            // 
            nombreProd.HeaderText = "Nombre Producto";
            nombreProd.MinimumWidth = 6;
            nombreProd.Name = "nombreProd";
            nombreProd.ReadOnly = true;
            nombreProd.Width = 220;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Width = 122;
            // 
            // precioProd
            // 
            precioProd.HeaderText = "Precio";
            precioProd.MinimumWidth = 6;
            precioProd.Name = "precioProd";
            precioProd.ReadOnly = true;
            precioProd.Width = 150;
            // 
            // precioVtaProd
            // 
            precioVtaProd.HeaderText = "Precio Venta";
            precioVtaProd.MinimumWidth = 6;
            precioVtaProd.Name = "precioVtaProd";
            precioVtaProd.ReadOnly = true;
            precioVtaProd.Width = 150;
            // 
            // idCategoria
            // 
            idCategoria.HeaderText = "idCategoria";
            idCategoria.MinimumWidth = 6;
            idCategoria.Name = "idCategoria";
            idCategoria.ReadOnly = true;
            idCategoria.Visible = false;
            idCategoria.Width = 125;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 175;
            // 
            // estadoValorProd
            // 
            estadoValorProd.HeaderText = "estadoValorProd";
            estadoValorProd.MinimumWidth = 6;
            estadoValorProd.Name = "estadoValorProd";
            estadoValorProd.ReadOnly = true;
            estadoValorProd.Visible = false;
            estadoValorProd.Width = 125;
            // 
            // estadoProd
            // 
            estadoProd.HeaderText = "Estado";
            estadoProd.MinimumWidth = 6;
            estadoProd.Name = "estadoProd";
            estadoProd.ReadOnly = true;
            estadoProd.Width = 125;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1586, 785);
            Controls.Add(dgvDataProd);
            Controls.Add(panel1);
            Controls.Add(BLimpiarBusqueda);
            Controls.Add(BBusqueda);
            Controls.Add(TBusqueda);
            Controls.Add(label9);
            Controls.Add(CBusqueda);
            Controls.Add(label8);
            Name = "frmProductos";
            Text = "frmProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private ComboBox CBusqueda;
        private Label label9;
        private TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private Panel panel1;
        private TextBox TIndice;
        private ComboBox CEstado;
        private Label LEstado;
        private TextBox TIdUsuario;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private FontAwesome.Sharp.IconButton BGuardarProd;
        private Label LPrecioVenta;
        private TextBox TPrecioProd;
        private Label LPrecio;
        private TextBox TStockProd;
        private Label LStockProd;
        private TextBox TNombreProd;
        private Label LNombreProd;
        private TextBox TCodProd;
        private Label LCodigoProd;
        private ComboBox CCategoria;
        private Label LCategoriaProd;
        private TextBox TPrecioVentaProd;
        private DataGridView dgvDataProd;
        private DataGridViewButtonColumn BSeleccionar;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn CodigoProd;
        private DataGridViewTextBoxColumn nombreProd;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn precioProd;
        private DataGridViewTextBoxColumn precioVtaProd;
        private DataGridViewTextBoxColumn idCategoria;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn estadoValorProd;
        private DataGridViewTextBoxColumn estadoProd;
    }
}