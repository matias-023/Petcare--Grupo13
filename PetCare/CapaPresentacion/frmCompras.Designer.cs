namespace CapaPresentacion
{
    partial class frmCompras
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            TIdProveedor = new TextBox();
            label2 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            label5 = new Label();
            TRazonSocial = new TextBox();
            TDocumentoProveedor = new TextBox();
            BBuscarProveedor = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            BAgregar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            TCodProducto = new TextBox();
            label11 = new Label();
            LPrecio = new Label();
            TCantidad = new NumericUpDown();
            BBuscarProducto = new FontAwesome.Sharp.IconButton();
            TPrecioCompra = new TextBox();
            TIdProducto = new TextBox();
            label9 = new Label();
            TPrecioVenta = new TextBox();
            label6 = new Label();
            TProducto = new TextBox();
            dgvData = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            BEliminar = new DataGridViewButtonColumn();
            groupBox4 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label14 = new Label();
            THora = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            CTipoDocumento = new ComboBox();
            label15 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            TFecha = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            BRegistrar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel5 = new TableLayoutPanel();
            label17 = new Label();
            TTotal = new TextBox();
            label12 = new Label();
            label18 = new Label();
            TCambio = new TextBox();
            TPagaCon = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TIdProveedor);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(iconPictureBox2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(TRazonSocial);
            panel2.Controls.Add(TDocumentoProveedor);
            panel2.Controls.Add(BBuscarProveedor);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(14, 27);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1188, 90);
            panel2.TabIndex = 57;
            // 
            // TIdProveedor
            // 
            TIdProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TIdProveedor.BackColor = SystemColors.Window;
            TIdProveedor.Location = new Point(1111, 4);
            TIdProveedor.Margin = new Padding(3, 4, 3, 4);
            TIdProveedor.Name = "TIdProveedor";
            TIdProveedor.Size = new Size(50, 27);
            TIdProveedor.TabIndex = 65;
            TIdProveedor.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(210, 120, 61);
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(504, 50);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 64;
            label2.Text = "Proveedor";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox2.BackColor = Color.FromArgb(210, 120, 61);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 37;
            iconPictureBox2.Location = new Point(535, 17);
            iconPictureBox2.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(37, 43);
            iconPictureBox2.TabIndex = 63;
            iconPictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(891, 17);
            label8.Name = "label8";
            label8.Size = new Size(124, 20);
            label8.TabIndex = 62;
            label8.Text = "Razón social:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(613, 17);
            label5.Name = "label5";
            label5.Size = new Size(203, 20);
            label5.TabIndex = 59;
            label5.Text = "Número de documento:";
            // 
            // TRazonSocial
            // 
            TRazonSocial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TRazonSocial.BackColor = SystemColors.Window;
            TRazonSocial.Location = new Point(891, 43);
            TRazonSocial.Margin = new Padding(3, 4, 3, 4);
            TRazonSocial.Name = "TRazonSocial";
            TRazonSocial.Size = new Size(269, 27);
            TRazonSocial.TabIndex = 61;
            // 
            // TDocumentoProveedor
            // 
            TDocumentoProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TDocumentoProveedor.BackColor = SystemColors.Window;
            TDocumentoProveedor.Location = new Point(614, 45);
            TDocumentoProveedor.Margin = new Padding(3, 4, 3, 4);
            TDocumentoProveedor.Name = "TDocumentoProveedor";
            TDocumentoProveedor.Size = new Size(211, 27);
            TDocumentoProveedor.TabIndex = 58;
            // 
            // BBuscarProveedor
            // 
            BBuscarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BBuscarProveedor.BackColor = Color.White;
            BBuscarProveedor.Cursor = Cursors.Hand;
            BBuscarProveedor.FlatAppearance.BorderColor = Color.Black;
            BBuscarProveedor.FlatStyle = FlatStyle.Flat;
            BBuscarProveedor.ForeColor = Color.White;
            BBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscarProveedor.IconColor = Color.Black;
            BBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscarProveedor.IconSize = 22;
            BBuscarProveedor.Location = new Point(831, 43);
            BBuscarProveedor.Margin = new Padding(3, 4, 3, 4);
            BBuscarProveedor.Name = "BBuscarProveedor";
            BBuscarProveedor.Size = new Size(54, 31);
            BBuscarProveedor.TabIndex = 60;
            BBuscarProveedor.TextAlign = ContentAlignment.MiddleRight;
            BBuscarProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscarProveedor.UseVisualStyleBackColor = false;
            BBuscarProveedor.Click += BBuscarProveedor_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(210, 120, 61);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 57;
            iconPictureBox1.Location = new Point(5, 19);
            iconPictureBox1.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(57, 67);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(64, 31);
            label3.Name = "label3";
            label3.Size = new Size(247, 31);
            label3.TabIndex = 0;
            label3.Text = "Registrar compra:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.FromArgb(168, 100, 50);
            groupBox3.Controls.Add(BAgregar);
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(14, 127);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1189, 125);
            groupBox3.TabIndex = 58;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información del Producto:";
            // 
            // BAgregar
            // 
            BAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BAgregar.BackColor = Color.OrangeRed;
            BAgregar.FlatAppearance.BorderColor = Color.Black;
            BAgregar.FlatStyle = FlatStyle.Flat;
            BAgregar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregar.IconChar = FontAwesome.Sharp.IconChar.DollyBox;
            BAgregar.IconColor = Color.White;
            BAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregar.IconSize = 32;
            BAgregar.ImageAlign = ContentAlignment.TopCenter;
            BAgregar.Location = new Point(1037, 21);
            BAgregar.Margin = new Padding(3, 4, 3, 4);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(145, 88);
            BAgregar.TabIndex = 59;
            BAgregar.Text = "Agregar";
            BAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            BAgregar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6065168F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.85124969F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.28104F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6536312F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.3296089F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6368713F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(label7, 0, 0);
            tableLayoutPanel1.Controls.Add(TCodProducto, 0, 1);
            tableLayoutPanel1.Controls.Add(label11, 5, 0);
            tableLayoutPanel1.Controls.Add(LPrecio, 3, 0);
            tableLayoutPanel1.Controls.Add(TCantidad, 5, 1);
            tableLayoutPanel1.Controls.Add(BBuscarProducto, 1, 1);
            tableLayoutPanel1.Controls.Add(TPrecioCompra, 3, 1);
            tableLayoutPanel1.Controls.Add(TIdProducto, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 4, 0);
            tableLayoutPanel1.Controls.Add(TPrecioVenta, 4, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(TProducto, 2, 1);
            tableLayoutPanel1.Location = new Point(7, 28);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(1023, 64);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 2;
            label7.Text = "Código:";
            // 
            // TCodProducto
            // 
            TCodProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TCodProducto.BackColor = SystemColors.Window;
            TCodProducto.Location = new Point(3, 25);
            TCodProducto.Margin = new Padding(3, 4, 3, 4);
            TCodProducto.Name = "TCodProducto";
            TCodProducto.Size = new Size(142, 26);
            TCodProducto.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(874, 0);
            label11.Name = "label11";
            label11.Size = new Size(95, 20);
            label11.TabIndex = 22;
            label11.Text = "Cantidad: ";
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            LPrecio.ForeColor = Color.White;
            LPrecio.Location = new Point(498, 0);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(137, 20);
            LPrecio.TabIndex = 24;
            LPrecio.Text = "Precio compra:";
            // 
            // TCantidad
            // 
            TCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TCantidad.Location = new Point(874, 25);
            TCantidad.Margin = new Padding(3, 4, 3, 4);
            TCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            TCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TCantidad.Name = "TCantidad";
            TCantidad.Size = new Size(146, 26);
            TCantidad.TabIndex = 11;
            TCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BBuscarProducto.BackColor = Color.White;
            BBuscarProducto.Cursor = Cursors.Hand;
            BBuscarProducto.FlatAppearance.BorderColor = Color.Black;
            BBuscarProducto.FlatStyle = FlatStyle.Flat;
            BBuscarProducto.ForeColor = Color.White;
            BBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscarProducto.IconColor = Color.Black;
            BBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscarProducto.IconSize = 20;
            BBuscarProducto.Location = new Point(151, 25);
            BBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(53, 31);
            BBuscarProducto.TabIndex = 6;
            BBuscarProducto.TextAlign = ContentAlignment.MiddleRight;
            BBuscarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscarProducto.UseVisualStyleBackColor = false;
            BBuscarProducto.Click += BBuscarProducto_Click;
            // 
            // TPrecioCompra
            // 
            TPrecioCompra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TPrecioCompra.BackColor = SystemColors.Window;
            TPrecioCompra.Location = new Point(498, 25);
            TPrecioCompra.Margin = new Padding(3, 4, 3, 4);
            TPrecioCompra.Name = "TPrecioCompra";
            TPrecioCompra.Size = new Size(173, 26);
            TPrecioCompra.TabIndex = 8;
            // 
            // TIdProducto
            // 
            TIdProducto.Location = new Point(151, 4);
            TIdProducto.Margin = new Padding(3, 4, 3, 4);
            TIdProducto.Name = "TIdProducto";
            TIdProducto.Size = new Size(26, 26);
            TIdProducto.TabIndex = 14;
            TIdProducto.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(677, 0);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 18;
            label9.Text = "Precio venta: ";
            // 
            // TPrecioVenta
            // 
            TPrecioVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TPrecioVenta.BackColor = SystemColors.Window;
            TPrecioVenta.Location = new Point(677, 25);
            TPrecioVenta.Margin = new Padding(3, 4, 3, 4);
            TPrecioVenta.Name = "TPrecioVenta";
            TPrecioVenta.Size = new Size(191, 26);
            TPrecioVenta.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(210, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 16;
            label6.Text = "Producto:";
            // 
            // TProducto
            // 
            TProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TProducto.BackColor = SystemColors.Window;
            TProducto.Location = new Point(210, 25);
            TProducto.Margin = new Padding(3, 4, 3, 4);
            TProducto.Name = "TProducto";
            TProducto.Size = new Size(282, 26);
            TProducto.TabIndex = 7;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { idProducto, producto, precioCompra, precioVenta, cantidad, subTotal, BEliminar });
            dgvData.Location = new Point(14, 260);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(1189, 387);
            dgvData.TabIndex = 59;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "idProducto";
            idProducto.MinimumWidth = 6;
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Visible = false;
            idProducto.Width = 125;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 300;
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "Precio de compra";
            precioCompra.MinimumWidth = 6;
            precioCompra.Name = "precioCompra";
            precioCompra.ReadOnly = true;
            precioCompra.Width = 150;
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "Precio de venta";
            precioVenta.MinimumWidth = 6;
            precioVenta.Name = "precioVenta";
            precioVenta.ReadOnly = true;
            precioVenta.Visible = false;
            precioVenta.Width = 125;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 150;
            // 
            // subTotal
            // 
            subTotal.HeaderText = "Sub Total";
            subTotal.MinimumWidth = 6;
            subTotal.Name = "subTotal";
            subTotal.ReadOnly = true;
            subTotal.Width = 150;
            // 
            // BEliminar
            // 
            BEliminar.HeaderText = "";
            BEliminar.MinimumWidth = 6;
            BEliminar.Name = "BEliminar";
            BEliminar.ReadOnly = true;
            BEliminar.Width = 35;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox4.BackColor = Color.FromArgb(168, 100, 50);
            groupBox4.Controls.Add(tableLayoutPanel4);
            groupBox4.Controls.Add(tableLayoutPanel3);
            groupBox4.Controls.Add(tableLayoutPanel2);
            groupBox4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(14, 655);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(433, 177);
            groupBox4.TabIndex = 60;
            groupBox4.TabStop = false;
            groupBox4.Text = "Información de la compra:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel4.Controls.Add(label14, 0, 0);
            tableLayoutPanel4.Controls.Add(THora, 0, 1);
            tableLayoutPanel4.Location = new Point(10, 99);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 36.17021F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 63.82979F));
            tableLayoutPanel4.Size = new Size(142, 63);
            tableLayoutPanel4.TabIndex = 63;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(56, 20);
            label14.TabIndex = 61;
            label14.Text = "Hora:";
            // 
            // THora
            // 
            THora.BackColor = SystemColors.Window;
            THora.Font = new Font("Microsoft Sans Serif", 11.25F);
            THora.Location = new Point(3, 26);
            THora.Margin = new Padding(3, 4, 3, 4);
            THora.Name = "THora";
            THora.Size = new Size(124, 29);
            THora.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.Controls.Add(CTipoDocumento, 0, 1);
            tableLayoutPanel3.Controls.Add(label15, 0, 0);
            tableLayoutPanel3.Location = new Point(159, 28);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 36.17021F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 63.82979F));
            tableLayoutPanel3.Size = new Size(262, 63);
            tableLayoutPanel3.TabIndex = 63;
            // 
            // CTipoDocumento
            // 
            CTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            CTipoDocumento.FormattingEnabled = true;
            CTipoDocumento.Location = new Point(3, 26);
            CTipoDocumento.Margin = new Padding(3, 4, 3, 4);
            CTipoDocumento.Name = "CTipoDocumento";
            CTipoDocumento.Size = new Size(254, 28);
            CTipoDocumento.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(174, 20);
            label15.TabIndex = 15;
            label15.Text = "Tipo de documento:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.Controls.Add(TFecha, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(10, 28);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 36.17021F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 63.82979F));
            tableLayoutPanel2.Size = new Size(142, 63);
            tableLayoutPanel2.TabIndex = 62;
            // 
            // TFecha
            // 
            TFecha.BackColor = SystemColors.Window;
            TFecha.Font = new Font("Microsoft Sans Serif", 11.25F);
            TFecha.Location = new Point(3, 26);
            TFecha.Margin = new Padding(3, 4, 3, 4);
            TFecha.Name = "TFecha";
            TFecha.Size = new Size(124, 29);
            TFecha.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 59;
            label1.Text = "Fecha:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.BackColor = Color.FromArgb(168, 100, 50);
            groupBox1.Controls.Add(BRegistrar);
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(681, 655);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(521, 177);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pago:";
            // 
            // BRegistrar
            // 
            BRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BRegistrar.BackColor = Color.RoyalBlue;
            BRegistrar.FlatAppearance.BorderColor = Color.Black;
            BRegistrar.FlatStyle = FlatStyle.Flat;
            BRegistrar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BRegistrar.IconChar = FontAwesome.Sharp.IconChar.Truck;
            BRegistrar.IconColor = Color.White;
            BRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BRegistrar.IconSize = 35;
            BRegistrar.ImageAlign = ContentAlignment.TopCenter;
            BRegistrar.Location = new Point(306, 17);
            BRegistrar.Margin = new Padding(3, 4, 3, 4);
            BRegistrar.Name = "BRegistrar";
            BRegistrar.Size = new Size(208, 144);
            BRegistrar.TabIndex = 63;
            BRegistrar.Text = "Registrar compra";
            BRegistrar.TextAlign = ContentAlignment.BottomCenter;
            BRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            BRegistrar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label17, 0, 0);
            tableLayoutPanel5.Controls.Add(TTotal, 0, 1);
            tableLayoutPanel5.Location = new Point(7, 55);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 38.46154F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 61.53846F));
            tableLayoutPanel5.Size = new Size(293, 93);
            tableLayoutPanel5.TabIndex = 62;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(175, 29);
            label17.TabIndex = 3;
            label17.Text = "Total a pagar:";
            // 
            // TTotal
            // 
            TTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TTotal.BackColor = SystemColors.Window;
            TTotal.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TTotal.Location = new Point(3, 43);
            TTotal.Margin = new Padding(3, 4, 3, 4);
            TTotal.Name = "TTotal";
            TTotal.Size = new Size(287, 46);
            TTotal.TabIndex = 19;
            // 
            // label12
            // 
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 0;
            // 
            // label18
            // 
            label18.Location = new Point(0, 0);
            label18.Name = "label18";
            label18.Size = new Size(100, 23);
            label18.TabIndex = 0;
            // 
            // TCambio
            // 
            TCambio.Location = new Point(0, 0);
            TCambio.Name = "TCambio";
            TCambio.Size = new Size(100, 27);
            TCambio.TabIndex = 0;
            // 
            // TPagaCon
            // 
            TPagaCon.Location = new Point(0, 0);
            TPagaCon.Name = "TPagaCon";
            TPagaCon.Size = new Size(100, 27);
            TPagaCon.TabIndex = 0;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 848);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(dgvData);
            Controls.Add(groupBox3);
            Controls.Add(panel2);
            Name = "frmCompras";
            Text = " ";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label3;
        private TextBox TIdProveedor;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label8;
        private Label label5;
        private TextBox TRazonSocial;
        private TextBox TDocumentoProveedor;
        private FontAwesome.Sharp.IconButton BBuscarProveedor;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private TextBox TCodProducto;
        private Label label11;
        private Label LPrecio;
        private NumericUpDown TCantidad;
        private FontAwesome.Sharp.IconButton BBuscarProducto;
        private TextBox TPrecioCompra;
        private TextBox TIdProducto;
        private Label label9;
        private TextBox TPrecioVenta;
        private Label label6;
        private TextBox TProducto;
        private FontAwesome.Sharp.IconButton BAgregar;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subTotal;
        private DataGridViewButtonColumn BEliminar;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label14;
        private ComboBox CTipoDocumento;
        private TextBox THora;
        private Label label15;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox TFecha;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label12;
        private Label label18;
        private TextBox TCambio;
        private TextBox TPagaCon;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox TTotal;
        private Label label17;
        private FontAwesome.Sharp.IconButton BRegistrar;
    }
}