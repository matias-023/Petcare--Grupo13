namespace CapaPresentacion
{
    partial class frmDetalleVenta
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
            TTipoDocumento = new TextBox();
            TFecha = new TextBox();
            TIdVenta = new TextBox();
            dgvData = new DataGridView();
            producto = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            TTotal = new TextBox();
            TMontoPago = new TextBox();
            TMontoCambio = new TextBox();
            BDescargar = new FontAwesome.Sharp.IconButton();
            TNombreCajero = new TextBox();
            TDocumentoCajero = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label17 = new Label();
            label18 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox7 = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            label20 = new Label();
            textBox8 = new TextBox();
            label21 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label22 = new Label();
            label23 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox11 = new TextBox();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            BLimpiar = new FontAwesome.Sharp.IconButton();
            BBuscar = new FontAwesome.Sharp.IconButton();
            TCodigoVenta = new TextBox();
            label16 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label12 = new Label();
            label15 = new Label();
            label14 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label13 = new Label();
            label19 = new Label();
            TNombreCliente = new TextBox();
            TDocumentoCliente = new TextBox();
            label4 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label27 = new Label();
            label26 = new Label();
            label3 = new Label();
            TMedioPago = new TextBox();
            label24 = new Label();
            THora = new TextBox();
            label25 = new Label();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            panel5 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label7 = new Label();
            label10 = new Label();
            label28 = new Label();
            label29 = new Label();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            panel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            SuspendLayout();
            // 
            // TTipoDocumento
            // 
            TTipoDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TTipoDocumento.Font = new Font("Microsoft Sans Serif", 9.75F);
            TTipoDocumento.Location = new Point(370, 19);
            TTipoDocumento.Name = "TTipoDocumento";
            TTipoDocumento.Size = new Size(242, 22);
            TTipoDocumento.TabIndex = 5;
            // 
            // TFecha
            // 
            TFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TFecha.Font = new Font("Microsoft Sans Serif", 9.75F);
            TFecha.Location = new Point(3, 19);
            TFecha.Name = "TFecha";
            TFecha.Size = new Size(156, 22);
            TFecha.TabIndex = 4;
            // 
            // TIdVenta
            // 
            TIdVenta.Location = new Point(428, 26);
            TIdVenta.Name = "TIdVenta";
            TIdVenta.Size = new Size(59, 23);
            TIdVenta.TabIndex = 13;
            TIdVenta.Visible = false;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { producto, precioCompra, cantidad, subTotal });
            dgvData.Location = new Point(17, 242);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(1040, 308);
            dgvData.TabIndex = 15;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 245;
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "Precio compra";
            precioCompra.MinimumWidth = 6;
            precioCompra.Name = "precioCompra";
            precioCompra.ReadOnly = true;
            precioCompra.Width = 150;
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
            // TTotal
            // 
            TTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TTotal.Font = new Font("Microsoft Sans Serif", 11.25F);
            TTotal.Location = new Point(3, 23);
            TTotal.Name = "TTotal";
            TTotal.Size = new Size(274, 24);
            TTotal.TabIndex = 16;
            // 
            // TMontoPago
            // 
            TMontoPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TMontoPago.Font = new Font("Microsoft Sans Serif", 11.25F);
            TMontoPago.Location = new Point(283, 23);
            TMontoPago.Name = "TMontoPago";
            TMontoPago.Size = new Size(212, 24);
            TMontoPago.TabIndex = 20;
            // 
            // TMontoCambio
            // 
            TMontoCambio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TMontoCambio.Font = new Font("Microsoft Sans Serif", 11.25F);
            TMontoCambio.Location = new Point(501, 23);
            TMontoCambio.Name = "TMontoCambio";
            TMontoCambio.Size = new Size(230, 24);
            TMontoCambio.TabIndex = 22;
            // 
            // BDescargar
            // 
            BDescargar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BDescargar.BackColor = Color.Firebrick;
            BDescargar.FlatAppearance.BorderColor = Color.Black;
            BDescargar.FlatStyle = FlatStyle.Flat;
            BDescargar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BDescargar.ForeColor = Color.White;
            BDescargar.IconChar = FontAwesome.Sharp.IconChar.File;
            BDescargar.IconColor = Color.White;
            BDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BDescargar.IconSize = 18;
            BDescargar.Location = new Point(834, 7);
            BDescargar.Name = "BDescargar";
            BDescargar.Size = new Size(193, 49);
            BDescargar.TabIndex = 23;
            BDescargar.Text = "Descargar en PDF";
            BDescargar.TextAlign = ContentAlignment.MiddleRight;
            BDescargar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BDescargar.UseVisualStyleBackColor = false;
            // 
            // TNombreCajero
            // 
            TNombreCajero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TNombreCajero.Font = new Font("Microsoft Sans Serif", 9.75F);
            TNombreCajero.Location = new Point(149, 19);
            TNombreCajero.Name = "TNombreCajero";
            TNombreCajero.Size = new Size(267, 22);
            TNombreCajero.TabIndex = 8;
            // 
            // TDocumentoCajero
            // 
            TDocumentoCajero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TDocumentoCajero.Font = new Font("Microsoft Sans Serif", 9.75F);
            TDocumentoCajero.Location = new Point(3, 19);
            TDocumentoCajero.Name = "TDocumentoCajero";
            TDocumentoCajero.Size = new Size(140, 22);
            TDocumentoCajero.TabIndex = 7;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(0, 0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 0;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // label17
            // 
            label17.Location = new Point(0, 0);
            label17.Name = "label17";
            label17.Size = new Size(100, 23);
            label17.TabIndex = 0;
            // 
            // label18
            // 
            label18.Location = new Point(0, 0);
            label18.Name = "label18";
            label18.Size = new Size(100, 23);
            label18.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(0, 0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(0, 0);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(75, 23);
            iconButton1.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(0, 0);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 0;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(0, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(75, 23);
            iconButton2.TabIndex = 0;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(0, 0);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(75, 23);
            iconButton3.TabIndex = 0;
            // 
            // label20
            // 
            label20.Location = new Point(0, 0);
            label20.Name = "label20";
            label20.Size = new Size(100, 23);
            label20.TabIndex = 0;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(0, 0);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 0;
            // 
            // label21
            // 
            label21.Location = new Point(0, 0);
            label21.Name = "label21";
            label21.Size = new Size(100, 23);
            label21.TabIndex = 0;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = SystemColors.Control;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.Location = new Point(0, 0);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(32, 32);
            iconPictureBox3.TabIndex = 0;
            iconPictureBox3.TabStop = false;
            // 
            // label22
            // 
            label22.Location = new Point(0, 0);
            label22.Name = "label22";
            label22.Size = new Size(100, 23);
            label22.TabIndex = 0;
            // 
            // label23
            // 
            label23.Location = new Point(0, 0);
            label23.Name = "label23";
            label23.Size = new Size(100, 23);
            label23.TabIndex = 0;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(0, 0);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 0;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(0, 0);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 0;
            // 
            // iconButton4
            // 
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(0, 0);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(75, 23);
            iconButton4.TabIndex = 0;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(0, 0);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 0;
            // 
            // iconButton5
            // 
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.Location = new Point(0, 0);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(75, 23);
            iconButton5.TabIndex = 0;
            // 
            // iconButton6
            // 
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton6.IconColor = Color.Black;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.Location = new Point(0, 0);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(75, 23);
            iconButton6.TabIndex = 0;
            // 
            // BLimpiar
            // 
            BLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BLimpiar.Font = new Font("Microsoft Sans Serif", 9F);
            BLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            BLimpiar.IconColor = Color.Black;
            BLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BLimpiar.IconSize = 18;
            BLimpiar.Location = new Point(908, 25);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(91, 23);
            BLimpiar.TabIndex = 10;
            BLimpiar.Text = "Limpiar";
            BLimpiar.TextAlign = ContentAlignment.MiddleRight;
            BLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiar.UseVisualStyleBackColor = true;
            // 
            // BBuscar
            // 
            BBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BBuscar.Font = new Font("Microsoft Sans Serif", 9F);
            BBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscar.IconColor = Color.Black;
            BBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscar.IconSize = 18;
            BBuscar.Location = new Point(810, 25);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(92, 23);
            BBuscar.TabIndex = 9;
            BBuscar.Text = "Buscar";
            BBuscar.TextAlign = ContentAlignment.MiddleRight;
            BBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // TCodigoVenta
            // 
            TCodigoVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TCodigoVenta.Location = new Point(632, 25);
            TCodigoVenta.Name = "TCodigoVenta";
            TCodigoVenta.Size = new Size(172, 23);
            TCodigoVenta.TabIndex = 8;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(16, 22);
            label16.Name = "label16";
            label16.Size = new Size(231, 25);
            label16.TabIndex = 0;
            label16.Text = "Ver detalle de venta:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TIdVenta);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(TCodigoVenta);
            panel2.Controls.Add(BBuscar);
            panel2.Controls.Add(BLimpiar);
            panel2.Location = new Point(17, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1040, 68);
            panel2.TabIndex = 57;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(210, 120, 61);
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(517, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 55;
            label1.Text = "Código de venta:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(168, 100, 50);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(iconPictureBox4);
            panel1.Location = new Point(17, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 68);
            panel1.TabIndex = 58;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.08353F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.9164658F));
            tableLayoutPanel1.Controls.Add(label12, 1, 0);
            tableLayoutPanel1.Controls.Add(label15, 0, 0);
            tableLayoutPanel1.Controls.Add(TNombreCajero, 1, 1);
            tableLayoutPanel1.Controls.Add(TDocumentoCajero, 0, 1);
            tableLayoutPanel1.Location = new Point(84, 7);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
            tableLayoutPanel1.Size = new Size(419, 50);
            tableLayoutPanel1.TabIndex = 64;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(149, 0);
            label12.Name = "label12";
            label12.Size = new Size(134, 16);
            label12.TabIndex = 61;
            label12.Text = "Nombre completo:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(89, 16);
            label15.TabIndex = 60;
            label15.Text = "Documento:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(168, 100, 50);
            label14.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(10, 39);
            label14.Name = "label14";
            label14.Size = new Size(58, 18);
            label14.TabIndex = 63;
            label14.Text = "Cajero";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(168, 100, 50);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            iconPictureBox4.IconColor = Color.White;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.Location = new Point(23, 7);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(32, 32);
            iconPictureBox4.TabIndex = 62;
            iconPictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(168, 100, 50);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(iconPictureBox2);
            panel3.Location = new Point(541, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(516, 68);
            panel3.TabIndex = 59;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.5769234F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.42308F));
            tableLayoutPanel2.Controls.Add(label13, 1, 0);
            tableLayoutPanel2.Controls.Add(label19, 0, 0);
            tableLayoutPanel2.Controls.Add(TNombreCliente, 1, 1);
            tableLayoutPanel2.Controls.Add(TDocumentoCliente, 0, 1);
            tableLayoutPanel2.Location = new Point(77, 7);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
            tableLayoutPanel2.Size = new Size(416, 50);
            tableLayoutPanel2.TabIndex = 65;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(151, 0);
            label13.Name = "label13";
            label13.Size = new Size(134, 16);
            label13.TabIndex = 61;
            label13.Text = "Nombre completo:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label19.ForeColor = Color.White;
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(89, 16);
            label19.TabIndex = 60;
            label19.Text = "Documento:";
            // 
            // TNombreCliente
            // 
            TNombreCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TNombreCliente.Font = new Font("Microsoft Sans Serif", 9.75F);
            TNombreCliente.Location = new Point(151, 19);
            TNombreCliente.Name = "TNombreCliente";
            TNombreCliente.Size = new Size(262, 22);
            TNombreCliente.TabIndex = 8;
            // 
            // TDocumentoCliente
            // 
            TDocumentoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TDocumentoCliente.Font = new Font("Microsoft Sans Serif", 9.75F);
            TDocumentoCliente.Location = new Point(3, 19);
            TDocumentoCliente.Name = "TDocumentoCliente";
            TDocumentoCliente.Size = new Size(142, 22);
            TDocumentoCliente.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(168, 100, 50);
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 39);
            label4.Name = "label4";
            label4.Size = new Size(60, 18);
            label4.TabIndex = 61;
            label4.Text = "Cliente";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(168, 100, 50);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.Location = new Point(24, 7);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.TabIndex = 60;
            iconPictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(168, 100, 50);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(tableLayoutPanel3);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(iconPictureBox5);
            panel4.Location = new Point(17, 168);
            panel4.Name = "panel4";
            panel4.Size = new Size(1040, 68);
            panel4.TabIndex = 60;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.14169F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.85831F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 248F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 317F));
            tableLayoutPanel3.Controls.Add(label27, 3, 0);
            tableLayoutPanel3.Controls.Add(label26, 2, 0);
            tableLayoutPanel3.Controls.Add(label3, 1, 0);
            tableLayoutPanel3.Controls.Add(TMedioPago, 3, 1);
            tableLayoutPanel3.Controls.Add(label24, 0, 0);
            tableLayoutPanel3.Controls.Add(THora, 1, 1);
            tableLayoutPanel3.Controls.Add(TTipoDocumento, 2, 1);
            tableLayoutPanel3.Controls.Add(TFecha, 0, 1);
            tableLayoutPanel3.Location = new Point(84, 7);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
            tableLayoutPanel3.Size = new Size(933, 50);
            tableLayoutPanel3.TabIndex = 64;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label27.ForeColor = Color.White;
            label27.Location = new Point(618, 0);
            label27.Name = "label27";
            label27.Size = new Size(116, 16);
            label27.TabIndex = 63;
            label27.Text = "Medio de pago:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label26.ForeColor = Color.White;
            label26.Location = new Point(370, 0);
            label26.Name = "label26";
            label26.Size = new Size(145, 16);
            label26.TabIndex = 62;
            label26.Text = "Tipo de documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(165, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 16);
            label3.TabIndex = 61;
            label3.Text = "Hora:";
            // 
            // TMedioPago
            // 
            TMedioPago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TMedioPago.Font = new Font("Microsoft Sans Serif", 9.75F);
            TMedioPago.Location = new Point(618, 19);
            TMedioPago.Name = "TMedioPago";
            TMedioPago.Size = new Size(312, 22);
            TMedioPago.TabIndex = 6;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label24.ForeColor = Color.White;
            label24.Location = new Point(3, 0);
            label24.Name = "label24";
            label24.Size = new Size(54, 16);
            label24.TabIndex = 60;
            label24.Text = "Fecha:";
            // 
            // THora
            // 
            THora.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            THora.Font = new Font("Microsoft Sans Serif", 9.75F);
            THora.Location = new Point(165, 19);
            THora.Name = "THora";
            THora.Size = new Size(199, 22);
            THora.TabIndex = 8;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.FromArgb(168, 100, 50);
            label25.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.White;
            label25.Location = new Point(12, 39);
            label25.Name = "label25";
            label25.Size = new Size(50, 18);
            label25.TabIndex = 63;
            label25.Text = "Venta";
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.FromArgb(168, 100, 50);
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Box;
            iconPictureBox5.IconColor = Color.White;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.Location = new Point(21, 7);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(32, 32);
            iconPictureBox5.TabIndex = 62;
            iconPictureBox5.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(168, 100, 50);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tableLayoutPanel4);
            panel5.Controls.Add(label29);
            panel5.Controls.Add(iconPictureBox6);
            panel5.Controls.Add(BDescargar);
            panel5.Location = new Point(17, 556);
            panel5.Name = "panel5";
            panel5.Size = new Size(1040, 68);
            panel5.TabIndex = 61;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.75F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(label7, 2, 0);
            tableLayoutPanel4.Controls.Add(label10, 1, 0);
            tableLayoutPanel4.Controls.Add(label28, 0, 0);
            tableLayoutPanel4.Controls.Add(TTotal, 0, 1);
            tableLayoutPanel4.Controls.Add(TMontoPago, 1, 1);
            tableLayoutPanel4.Controls.Add(TMontoCambio, 2, 1);
            tableLayoutPanel4.Location = new Point(84, 7);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 62F));
            tableLayoutPanel4.Size = new Size(734, 50);
            tableLayoutPanel4.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(501, 0);
            label7.Name = "label7";
            label7.Size = new Size(108, 16);
            label7.TabIndex = 62;
            label7.Text = "Monto cambio:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(283, 0);
            label10.Name = "label10";
            label10.Size = new Size(93, 16);
            label10.TabIndex = 61;
            label10.Text = "Monto pago:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label28.ForeColor = Color.White;
            label28.Location = new Point(3, 0);
            label28.Name = "label28";
            label28.Size = new Size(87, 16);
            label28.TabIndex = 60;
            label28.Text = "Monto total:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.FromArgb(168, 100, 50);
            label29.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.White;
            label29.Location = new Point(11, 38);
            label29.Name = "label29";
            label29.Size = new Size(52, 18);
            label29.TabIndex = 63;
            label29.Text = "Pago:";
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.FromArgb(168, 100, 50);
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            iconPictureBox6.IconColor = Color.White;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.Location = new Point(19, 7);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(32, 32);
            iconPictureBox6.TabIndex = 62;
            iconPictureBox6.TabStop = false;
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 636);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvData);
            Name = "frmDetalleVenta";
            Text = "frmDetalleVenta";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TTipoDocumento;
        private TextBox TFecha;
        private TextBox TIdVenta;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subTotal;
        private TextBox TTotal;
        private TextBox TMontoPago;
        private TextBox TMontoCambio;
        private FontAwesome.Sharp.IconButton BDescargar;
        private TextBox TNombreCajero;
        private TextBox TDocumentoCajero;
        private Label label5;
        private TextBox textBox4;
        private Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label17;
        private Label label18;
        private TextBox textBox5;
        private TextBox textBox6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox7;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label20;
        private TextBox textBox8;
        private Label label21;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label22;
        private Label label23;
        private TextBox textBox9;
        private TextBox textBox10;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox11;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private FontAwesome.Sharp.IconButton BBuscar;
        private TextBox TCodigoVenta;
        private Label label16;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Label label14;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label15;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label13;
        private Label label19;
        private TextBox TNombreCliente;
        private TextBox TDocumentoCliente;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label24;
        private TextBox THora;
        private Label label25;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Label label26;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label7;
        private Label label10;
        private Label label28;
        private Label label29;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Label label27;
        private TextBox TMedioPago;
    }
}