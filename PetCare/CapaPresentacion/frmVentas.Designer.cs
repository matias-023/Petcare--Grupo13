namespace CapaPresentacion
{
    partial class frmVentas
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
            TIdCliente = new TextBox();
            label2 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            label3 = new Label();
            TNombreCompleto = new TextBox();
            TDocumentoCliente = new TextBox();
            BBuscarCliente = new FontAwesome.Sharp.IconButton();
            TFecha = new TextBox();
            dgvData = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            BEliminar = new DataGridViewButtonColumn();
            TTotal = new TextBox();
            TCambio = new TextBox();
            TPagaCon = new TextBox();
            groupBox4 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label14 = new Label();
            CTipoDocumento = new ComboBox();
            THora = new TextBox();
            label15 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            CMedioPago = new ComboBox();
            label16 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            TCodProducto = new TextBox();
            label11 = new Label();
            TCantidad = new NumericUpDown();
            BBuscarProducto = new FontAwesome.Sharp.IconButton();
            TStock = new TextBox();
            label10 = new Label();
            TIdProducto = new TextBox();
            label9 = new Label();
            TPrecio = new TextBox();
            label6 = new Label();
            TProducto = new TextBox();
            BAgregar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label17 = new Label();
            BRegistrar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            label12 = new Label();
            label18 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TCantidad).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TIdCliente);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(iconPictureBox2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(TNombreCompleto);
            panel2.Controls.Add(TDocumentoCliente);
            panel2.Controls.Add(BBuscarCliente);
            panel2.Location = new Point(12, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1040, 68);
            panel2.TabIndex = 56;
            // 
            // TIdCliente
            // 
            TIdCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TIdCliente.BackColor = SystemColors.Window;
            TIdCliente.Location = new Point(972, 6);
            TIdCliente.Name = "TIdCliente";
            TIdCliente.Size = new Size(44, 23);
            TIdCliente.TabIndex = 57;
            TIdCliente.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(210, 120, 61);
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(467, 41);
            label2.Name = "label2";
            label2.Size = new Size(60, 18);
            label2.TabIndex = 56;
            label2.Text = "Cliente";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox2.BackColor = Color.FromArgb(210, 120, 61);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.Location = new Point(482, 9);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.TabIndex = 16;
            iconPictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(780, 13);
            label8.Name = "label8";
            label8.Size = new Size(134, 16);
            label8.TabIndex = 15;
            label8.Text = "Nombre completo:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(210, 120, 61);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 50;
            iconPictureBox1.Location = new Point(4, 14);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(50, 50);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(536, 13);
            label5.Name = "label5";
            label5.Size = new Size(167, 16);
            label5.TabIndex = 2;
            label5.Text = "Número de documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(56, 23);
            label3.Name = "label3";
            label3.Size = new Size(180, 25);
            label3.TabIndex = 0;
            label3.Text = "Registrar venta:";
            // 
            // TNombreCompleto
            // 
            TNombreCompleto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TNombreCompleto.BackColor = SystemColors.Window;
            TNombreCompleto.Location = new Point(780, 32);
            TNombreCompleto.Name = "TNombreCompleto";
            TNombreCompleto.Size = new Size(236, 23);
            TNombreCompleto.TabIndex = 3;
            // 
            // TDocumentoCliente
            // 
            TDocumentoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TDocumentoCliente.BackColor = SystemColors.Window;
            TDocumentoCliente.Location = new Point(536, 32);
            TDocumentoCliente.Name = "TDocumentoCliente";
            TDocumentoCliente.Size = new Size(185, 23);
            TDocumentoCliente.TabIndex = 1;
            // 
            // BBuscarCliente
            // 
            BBuscarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BBuscarCliente.BackColor = Color.White;
            BBuscarCliente.Cursor = Cursors.Hand;
            BBuscarCliente.FlatAppearance.BorderColor = Color.Black;
            BBuscarCliente.FlatStyle = FlatStyle.Flat;
            BBuscarCliente.ForeColor = Color.White;
            BBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscarCliente.IconColor = Color.Black;
            BBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscarCliente.IconSize = 22;
            BBuscarCliente.Location = new Point(727, 32);
            BBuscarCliente.Name = "BBuscarCliente";
            BBuscarCliente.Size = new Size(47, 23);
            BBuscarCliente.TabIndex = 2;
            BBuscarCliente.TextAlign = ContentAlignment.MiddleRight;
            BBuscarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscarCliente.UseVisualStyleBackColor = false;
            BBuscarCliente.Click += BBuscarCliente_Click;
            // 
            // TFecha
            // 
            TFecha.BackColor = SystemColors.Window;
            TFecha.Font = new Font("Microsoft Sans Serif", 11.25F);
            TFecha.Location = new Point(3, 20);
            TFecha.Name = "TFecha";
            TFecha.Size = new Size(109, 24);
            TFecha.TabIndex = 14;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { idProducto, producto, precio, cantidad, subTotal, BEliminar });
            dgvData.Location = new Point(12, 195);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(1040, 290);
            dgvData.TabIndex = 10;
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
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 150;
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
            // TTotal
            // 
            TTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TTotal.BackColor = SystemColors.Window;
            TTotal.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TTotal.Location = new Point(3, 29);
            TTotal.Name = "TTotal";
            TTotal.Size = new Size(276, 38);
            TTotal.TabIndex = 19;
            // 
            // TCambio
            // 
            TCambio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TCambio.Location = new Point(3, 75);
            TCambio.Name = "TCambio";
            TCambio.Size = new Size(155, 22);
            TCambio.TabIndex = 21;
            // 
            // TPagaCon
            // 
            TPagaCon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TPagaCon.BackColor = SystemColors.Control;
            TPagaCon.Location = new Point(3, 20);
            TPagaCon.Name = "TPagaCon";
            TPagaCon.Size = new Size(155, 22);
            TPagaCon.TabIndex = 20;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox4.BackColor = Color.FromArgb(168, 100, 50);
            groupBox4.Controls.Add(tableLayoutPanel3);
            groupBox4.Controls.Add(tableLayoutPanel2);
            groupBox4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(12, 491);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(379, 133);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Información de la venta: ";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.87348F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.12652F));
            tableLayoutPanel3.Controls.Add(label14, 0, 0);
            tableLayoutPanel3.Controls.Add(CTipoDocumento, 1, 1);
            tableLayoutPanel3.Controls.Add(THora, 0, 1);
            tableLayoutPanel3.Controls.Add(label15, 1, 0);
            tableLayoutPanel3.Location = new Point(9, 74);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 36.17021F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 63.82979F));
            tableLayoutPanel3.Size = new Size(361, 47);
            tableLayoutPanel3.TabIndex = 63;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(45, 16);
            label14.TabIndex = 61;
            label14.Text = "Hora:";
            // 
            // CTipoDocumento
            // 
            CTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            CTipoDocumento.FormattingEnabled = true;
            CTipoDocumento.Location = new Point(118, 20);
            CTipoDocumento.Name = "CTipoDocumento";
            CTipoDocumento.Size = new Size(239, 24);
            CTipoDocumento.TabIndex = 17;
            // 
            // THora
            // 
            THora.BackColor = SystemColors.Window;
            THora.Font = new Font("Microsoft Sans Serif", 11.25F);
            THora.Location = new Point(3, 20);
            THora.Name = "THora";
            THora.Size = new Size(109, 24);
            THora.TabIndex = 16;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(118, 0);
            label15.Name = "label15";
            label15.Size = new Size(145, 16);
            label15.TabIndex = 15;
            label15.Text = "Tipo de documento:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.87348F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.12652F));
            tableLayoutPanel2.Controls.Add(TFecha, 0, 1);
            tableLayoutPanel2.Controls.Add(CMedioPago, 1, 1);
            tableLayoutPanel2.Controls.Add(label16, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(9, 21);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 36.17021F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 63.82979F));
            tableLayoutPanel2.Size = new Size(361, 47);
            tableLayoutPanel2.TabIndex = 62;
            // 
            // CMedioPago
            // 
            CMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
            CMedioPago.FormattingEnabled = true;
            CMedioPago.Location = new Point(118, 20);
            CMedioPago.Name = "CMedioPago";
            CMedioPago.Size = new Size(239, 24);
            CMedioPago.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(118, 0);
            label16.Name = "label16";
            label16.Size = new Size(116, 16);
            label16.TabIndex = 2;
            label16.Text = "Medio de pago:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 16);
            label1.TabIndex = 59;
            label1.Text = "Fecha:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.FromArgb(168, 100, 50);
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Controls.Add(BAgregar);
            groupBox3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(12, 95);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1040, 94);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información del Producto:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4247208F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.179015F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.865242F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8933983F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.61549F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.0221272F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label7, 0, 0);
            tableLayoutPanel1.Controls.Add(TCodProducto, 0, 1);
            tableLayoutPanel1.Controls.Add(label11, 5, 0);
            tableLayoutPanel1.Controls.Add(TCantidad, 5, 1);
            tableLayoutPanel1.Controls.Add(BBuscarProducto, 1, 1);
            tableLayoutPanel1.Controls.Add(TStock, 4, 1);
            tableLayoutPanel1.Controls.Add(label10, 4, 0);
            tableLayoutPanel1.Controls.Add(TIdProducto, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 3, 0);
            tableLayoutPanel1.Controls.Add(TPrecio, 3, 1);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(TProducto, 2, 1);
            tableLayoutPanel1.Location = new Point(6, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.Size = new Size(895, 48);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 16);
            label7.TabIndex = 2;
            label7.Text = "Código:";
            // 
            // TCodProducto
            // 
            TCodProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TCodProducto.BackColor = SystemColors.Window;
            TCodProducto.Location = new Point(3, 19);
            TCodProducto.Name = "TCodProducto";
            TCodProducto.Size = new Size(132, 22);
            TCodProducto.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(735, 0);
            label11.Name = "label11";
            label11.Size = new Size(77, 16);
            label11.TabIndex = 22;
            label11.Text = "Cantidad: ";
            // 
            // TCantidad
            // 
            TCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TCantidad.Location = new Point(735, 19);
            TCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            TCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TCantidad.Name = "TCantidad";
            TCantidad.Size = new Size(157, 22);
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
            BBuscarProducto.Location = new Point(141, 19);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(49, 23);
            BBuscarProducto.TabIndex = 6;
            BBuscarProducto.TextAlign = ContentAlignment.MiddleRight;
            BBuscarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscarProducto.UseVisualStyleBackColor = false;
            BBuscarProducto.Click += BBuscarProducto_Click;
            // 
            // TStock
            // 
            TStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TStock.BackColor = SystemColors.Window;
            TStock.Location = new Point(623, 19);
            TStock.Name = "TStock";
            TStock.Size = new Size(106, 22);
            TStock.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(623, 0);
            label10.Name = "label10";
            label10.Size = new Size(50, 16);
            label10.TabIndex = 20;
            label10.Text = "Stock:";
            // 
            // TIdProducto
            // 
            TIdProducto.Location = new Point(141, 3);
            TIdProducto.Name = "TIdProducto";
            TIdProducto.Size = new Size(23, 22);
            TIdProducto.TabIndex = 14;
            TIdProducto.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(463, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 16);
            label9.TabIndex = 18;
            label9.Text = "Precio: ";
            // 
            // TPrecio
            // 
            TPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TPrecio.BackColor = SystemColors.Window;
            TPrecio.Location = new Point(463, 19);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(154, 22);
            TPrecio.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(196, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 16);
            label6.TabIndex = 16;
            label6.Text = "Producto:";
            // 
            // TProducto
            // 
            TProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TProducto.BackColor = SystemColors.Window;
            TProducto.Location = new Point(196, 19);
            TProducto.Name = "TProducto";
            TProducto.Size = new Size(261, 22);
            TProducto.TabIndex = 7;
            // 
            // BAgregar
            // 
            BAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BAgregar.BackColor = Color.OrangeRed;
            BAgregar.FlatAppearance.BorderColor = Color.Black;
            BAgregar.FlatStyle = FlatStyle.Flat;
            BAgregar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregar.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            BAgregar.IconColor = Color.White;
            BAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregar.IconSize = 32;
            BAgregar.ImageAlign = ContentAlignment.TopCenter;
            BAgregar.Location = new Point(907, 16);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(127, 66);
            BAgregar.TabIndex = 12;
            BAgregar.Text = "Agregar";
            BAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            BAgregar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.BackColor = Color.FromArgb(168, 100, 50);
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Controls.Add(BRegistrar);
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(397, 491);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 133);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pago:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(TTotal, 0, 1);
            tableLayoutPanel5.Controls.Add(label17, 0, 0);
            tableLayoutPanel5.Location = new Point(12, 33);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 38.46154F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 61.53846F));
            tableLayoutPanel5.Size = new Size(282, 70);
            tableLayoutPanel5.TabIndex = 62;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(138, 24);
            label17.TabIndex = 3;
            label17.Text = "Total a pagar:";
            // 
            // BRegistrar
            // 
            BRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BRegistrar.BackColor = Color.RoyalBlue;
            BRegistrar.FlatAppearance.BorderColor = Color.Black;
            BRegistrar.FlatStyle = FlatStyle.Flat;
            BRegistrar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BRegistrar.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            BRegistrar.IconColor = Color.White;
            BRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BRegistrar.IconSize = 35;
            BRegistrar.ImageAlign = ContentAlignment.TopCenter;
            BRegistrar.Location = new Point(467, 16);
            BRegistrar.Name = "BRegistrar";
            BRegistrar.Size = new Size(182, 108);
            BRegistrar.TabIndex = 22;
            BRegistrar.Text = "Registrar venta";
            BRegistrar.TextAlign = ContentAlignment.BottomCenter;
            BRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            BRegistrar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(label12, 0, 0);
            tableLayoutPanel4.Controls.Add(label18, 0, 3);
            tableLayoutPanel4.Controls.Add(TCambio, 0, 4);
            tableLayoutPanel4.Controls.Add(TPagaCon, 0, 1);
            tableLayoutPanel4.Location = new Point(300, 21);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 35.5555573F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 64.44444F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel4.Size = new Size(161, 100);
            tableLayoutPanel4.TabIndex = 61;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(77, 16);
            label12.TabIndex = 59;
            label12.Text = "Paga con:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label18.ForeColor = Color.White;
            label18.Location = new Point(3, 58);
            label18.Name = "label18";
            label18.Size = new Size(64, 13);
            label18.TabIndex = 60;
            label18.Text = "Cambio:";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 636);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(panel2);
            Controls.Add(groupBox3);
            Controls.Add(dgvData);
            Name = "frmVentas";
            Text = "frmVentas";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private TextBox TDocumentoCliente;
        private DataGridView dgvData;
        private TextBox TTotal;
        private TextBox TCambio;
        private TextBox TPagaCon;
        private Panel panel2;
        private Label label3;
        private TextBox TFecha;
        private FontAwesome.Sharp.IconButton BBuscarCliente;
        private Label label8;
        private TextBox TNombreCompleto;
        private GroupBox groupBox4;
        private Label label15;
        private Label label16;
        private ComboBox CMedioPago;
        private ComboBox CTipoDocumento;
        private GroupBox groupBox3;
        private Label label11;
        private NumericUpDown TCantidad;
        private Label label10;
        private TextBox TStock;
        private Label label9;
        private TextBox TPrecio;
        private Label label6;
        private TextBox TProducto;
        private TextBox TIdProducto;
        private FontAwesome.Sharp.IconButton BBuscarProducto;
        private Label label7;
        private TextBox TCodProducto;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label2;
        private FontAwesome.Sharp.IconButton BAgregar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label14;
        private TextBox THora;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private Label label17;
        private Label label18;
        private Label label12;
        private FontAwesome.Sharp.IconButton BRegistrar;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox TIdCliente;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subTotal;
        private DataGridViewButtonColumn BEliminar;
    }
}