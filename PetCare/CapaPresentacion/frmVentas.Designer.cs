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
            label2 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            label3 = new Label();
            TNombreCompleto = new TextBox();
            TDocumentoCliente = new TextBox();
            BBuscarCliente = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            TFecha = new TextBox();
            dgvData = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            marca = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            BEliminar = new DataGridViewButtonColumn();
            BRegistrar = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            TTotal = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label13 = new Label();
            textBox2 = new TextBox();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            CMedioPago = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            groupBox3 = new GroupBox();
            BAgregar = new FontAwesome.Sharp.IconButton();
            LMarca = new Label();
            TMarca = new TextBox();
            label11 = new Label();
            TCantidad = new NumericUpDown();
            label10 = new Label();
            TStock = new TextBox();
            label9 = new Label();
            TPrecio = new TextBox();
            label6 = new Label();
            TProducto = new TextBox();
            TIdProducto = new TextBox();
            BBuscarProducto = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            TCodProducto = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TCantidad).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(iconPictureBox2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(TNombreCompleto);
            panel2.Controls.Add(TDocumentoCliente);
            panel2.Controls.Add(BBuscarCliente);
            panel2.Location = new Point(23, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1017, 68);
            panel2.TabIndex = 56;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(210, 120, 61);
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(444, 41);
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
            iconPictureBox2.Location = new Point(459, 9);
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
            label8.Location = new Point(757, 13);
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
            iconPictureBox1.Location = new Point(2, 10);
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
            label5.Location = new Point(513, 13);
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
            TNombreCompleto.Location = new Point(757, 32);
            TNombreCompleto.Name = "TNombreCompleto";
            TNombreCompleto.Size = new Size(236, 23);
            TNombreCompleto.TabIndex = 3;
            // 
            // TDocumentoCliente
            // 
            TDocumentoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TDocumentoCliente.BackColor = SystemColors.Window;
            TDocumentoCliente.Location = new Point(513, 32);
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
            BBuscarCliente.Location = new Point(704, 32);
            BBuscarCliente.Name = "BBuscarCliente";
            BBuscarCliente.Size = new Size(47, 23);
            BBuscarCliente.TabIndex = 2;
            BBuscarCliente.TextAlign = ContentAlignment.MiddleRight;
            BBuscarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(210, 120, 61);
            label1.Font = new Font("Microsoft Sans Serif", 11.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(145, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 55;
            label1.Text = "Fecha:";
            // 
            // TFecha
            // 
            TFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TFecha.BackColor = SystemColors.Window;
            TFecha.Font = new Font("Microsoft Sans Serif", 11.25F);
            TFecha.Location = new Point(204, -6);
            TFecha.Name = "TFecha";
            TFecha.Size = new Size(132, 24);
            TFecha.TabIndex = 0;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { idProducto, producto, marca, precio, cantidad, subTotal, BEliminar });
            dgvData.Location = new Point(23, 184);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(1017, 236);
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
            // marca
            // 
            marca.HeaderText = "Marca";
            marca.Name = "marca";
            marca.ReadOnly = true;
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
            // BRegistrar
            // 
            BRegistrar.Cursor = Cursors.Hand;
            BRegistrar.FlatAppearance.BorderColor = Color.Black;
            BRegistrar.Font = new Font("Segoe UI", 12F);
            BRegistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            BRegistrar.IconColor = Color.DodgerBlue;
            BRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BRegistrar.IconSize = 40;
            BRegistrar.Location = new Point(648, 517);
            BRegistrar.Name = "BRegistrar";
            BRegistrar.Size = new Size(144, 51);
            BRegistrar.TabIndex = 14;
            BRegistrar.Text = "Registrar venta";
            BRegistrar.TextAlign = ContentAlignment.TopCenter;
            BRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BRegistrar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(940, 467);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 25;
            label12.Text = "Total a pagar:";
            // 
            // TTotal
            // 
            TTotal.BackColor = SystemColors.Control;
            TTotal.Location = new Point(915, 514);
            TTotal.Name = "TTotal";
            TTotal.Size = new Size(144, 23);
            TTotal.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(883, 452);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 27;
            label4.Text = "Paga con:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(883, 485);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Location = new Point(826, 467);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 29;
            label13.Text = "Cambio:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(798, 560);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 13;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox4.BackColor = Color.FromArgb(168, 100, 50);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(TFecha);
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(CMedioPago);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label16);
            groupBox4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(23, 548);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(499, 76);
            groupBox4.TabIndex = 57;
            groupBox4.TabStop = false;
            groupBox4.Text = "Información venta: ";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(273, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 24);
            comboBox1.TabIndex = 58;
            // 
            // CMedioPago
            // 
            CMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
            CMedioPago.FormattingEnabled = true;
            CMedioPago.Location = new Point(14, 42);
            CMedioPago.Name = "CMedioPago";
            CMedioPago.Size = new Size(253, 24);
            CMedioPago.TabIndex = 16;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(273, 23);
            label15.Name = "label15";
            label15.Size = new Size(145, 16);
            label15.TabIndex = 15;
            label15.Text = "Tipo de documento:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(16, 24);
            label16.Name = "label16";
            label16.Size = new Size(116, 16);
            label16.TabIndex = 2;
            label16.Text = "Medio de pago:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.FromArgb(168, 100, 50);
            groupBox3.Controls.Add(BAgregar);
            groupBox3.Controls.Add(LMarca);
            groupBox3.Controls.Add(TMarca);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(TCantidad);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(TStock);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(TPrecio);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(TProducto);
            groupBox3.Controls.Add(TIdProducto);
            groupBox3.Controls.Add(BBuscarProducto);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(TCodProducto);
            groupBox3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(23, 95);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1017, 83);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información del Producto:";
            // 
            // BAgregar
            // 
            BAgregar.BackColor = Color.OrangeRed;
            BAgregar.FlatAppearance.BorderColor = Color.Black;
            BAgregar.FlatStyle = FlatStyle.Flat;
            BAgregar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregar.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            BAgregar.IconColor = Color.White;
            BAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregar.IconSize = 32;
            BAgregar.ImageAlign = ContentAlignment.TopCenter;
            BAgregar.Location = new Point(892, 15);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(114, 59);
            BAgregar.TabIndex = 11;
            BAgregar.Text = "Agregar";
            BAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            BAgregar.UseVisualStyleBackColor = false;
            // 
            // LMarca
            // 
            LMarca.AutoSize = true;
            LMarca.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            LMarca.ForeColor = Color.White;
            LMarca.Location = new Point(432, 24);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(54, 16);
            LMarca.TabIndex = 24;
            LMarca.Text = "Marca:";
            // 
            // TMarca
            // 
            TMarca.BackColor = SystemColors.Window;
            TMarca.Location = new Point(432, 42);
            TMarca.Name = "TMarca";
            TMarca.Size = new Size(142, 22);
            TMarca.TabIndex = 7;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(787, 24);
            label11.Name = "label11";
            label11.Size = new Size(77, 16);
            label11.TabIndex = 22;
            label11.Text = "Cantidad: ";
            // 
            // TCantidad
            // 
            TCantidad.Location = new Point(787, 42);
            TCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            TCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TCantidad.Name = "TCantidad";
            TCantidad.Size = new Size(90, 22);
            TCantidad.TabIndex = 10;
            TCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(693, 25);
            label10.Name = "label10";
            label10.Size = new Size(50, 16);
            label10.TabIndex = 20;
            label10.Text = "Stock:";
            // 
            // TStock
            // 
            TStock.BackColor = SystemColors.Window;
            TStock.Location = new Point(693, 42);
            TStock.Name = "TStock";
            TStock.Size = new Size(88, 22);
            TStock.TabIndex = 9;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(580, 25);
            label9.Name = "label9";
            label9.Size = new Size(60, 16);
            label9.TabIndex = 18;
            label9.Text = "Precio: ";
            // 
            // TPrecio
            // 
            TPrecio.BackColor = SystemColors.Window;
            TPrecio.Location = new Point(580, 42);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(107, 22);
            TPrecio.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(195, 24);
            label6.Name = "label6";
            label6.Size = new Size(73, 16);
            label6.TabIndex = 16;
            label6.Text = "Producto:";
            // 
            // TProducto
            // 
            TProducto.BackColor = SystemColors.Window;
            TProducto.Location = new Point(195, 42);
            TProducto.Name = "TProducto";
            TProducto.Size = new Size(231, 22);
            TProducto.TabIndex = 6;
            // 
            // TIdProducto
            // 
            TIdProducto.Location = new Point(164, 18);
            TIdProducto.Name = "TIdProducto";
            TIdProducto.Size = new Size(23, 22);
            TIdProducto.TabIndex = 14;
            TIdProducto.Visible = false;
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.BackColor = Color.White;
            BBuscarProducto.Cursor = Cursors.Hand;
            BBuscarProducto.FlatAppearance.BorderColor = Color.Black;
            BBuscarProducto.FlatStyle = FlatStyle.Flat;
            BBuscarProducto.ForeColor = Color.White;
            BBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscarProducto.IconColor = Color.Black;
            BBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscarProducto.IconSize = 20;
            BBuscarProducto.Location = new Point(142, 42);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(47, 23);
            BBuscarProducto.TabIndex = 5;
            BBuscarProducto.TextAlign = ContentAlignment.MiddleRight;
            BBuscarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 24);
            label7.Name = "label7";
            label7.Size = new Size(61, 16);
            label7.TabIndex = 2;
            label7.Text = "Código:";
            // 
            // TCodProducto
            // 
            TCodProducto.BackColor = SystemColors.Window;
            TCodProducto.Location = new Point(10, 42);
            TCodProducto.Name = "TCodProducto";
            TCodProducto.Size = new Size(126, 22);
            TCodProducto.TabIndex = 4;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 636);
            Controls.Add(groupBox4);
            Controls.Add(panel2);
            Controls.Add(groupBox3);
            Controls.Add(label13);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(BRegistrar);
            Controls.Add(label12);
            Controls.Add(TTotal);
            Controls.Add(dgvData);
            Name = "frmVentas";
            Text = "frmVentas";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox TDocumentoCliente;
        private DataGridView dgvData;
        private FontAwesome.Sharp.IconButton BRegistrar;
        private Label label12;
        private TextBox TTotal;
        private Label label4;
        private TextBox textBox1;
        private Label label13;
        private TextBox textBox2;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private TextBox TFecha;
        private FontAwesome.Sharp.IconButton BBuscarCliente;
        private Label label8;
        private TextBox TNombreCompleto;
        private GroupBox groupBox4;
        private Label label15;
        private Label label16;
        private ComboBox CMedioPago;
        private ComboBox comboBox1;
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
        private Label LMarca;
        private TextBox TMarca;
        private FontAwesome.Sharp.IconButton BAgregar;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subTotal;
        private DataGridViewButtonColumn BEliminar;
    }
}