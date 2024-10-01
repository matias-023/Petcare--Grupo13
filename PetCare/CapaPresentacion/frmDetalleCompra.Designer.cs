namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            TIdCompra = new TextBox();
            dgvData = new DataGridView();
            producto = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label1 = new Label();
            TCodigoVenta = new TextBox();
            BBuscar = new FontAwesome.Sharp.IconButton();
            label16 = new Label();
            BLimpiar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label12 = new Label();
            label15 = new Label();
            TNombreUsuario = new TextBox();
            TDocumentoUsuario = new TextBox();
            label14 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label13 = new Label();
            label19 = new Label();
            TRazonSocialProv = new TextBox();
            TDocumentoProv = new TextBox();
            label5 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            TFecha = new TextBox();
            label26 = new Label();
            label2 = new Label();
            label24 = new Label();
            THora = new TextBox();
            TTipoDocumento = new TextBox();
            label25 = new Label();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            panel5 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label28 = new Label();
            TMontoTotal = new TextBox();
            label29 = new Label();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            BDescargar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
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
            // TIdCompra
            // 
            TIdCompra.Location = new Point(422, 24);
            TIdCompra.Name = "TIdCompra";
            TIdCompra.Size = new Size(59, 23);
            TIdCompra.TabIndex = 13;
            TIdCompra.Visible = false;
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
            dgvData.Size = new Size(1040, 331);
            dgvData.TabIndex = 12;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 390;
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "Precio compra";
            precioCompra.MinimumWidth = 6;
            precioCompra.Name = "precioCompra";
            precioCompra.ReadOnly = true;
            precioCompra.Width = 350;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 255;
            // 
            // subTotal
            // 
            subTotal.HeaderText = "Sub Total";
            subTotal.MinimumWidth = 6;
            subTotal.Name = "subTotal";
            subTotal.ReadOnly = true;
            subTotal.Width = 300;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TCodigoVenta);
            panel2.Controls.Add(TIdCompra);
            panel2.Controls.Add(BBuscar);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(BLimpiar);
            panel2.Location = new Point(17, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1040, 68);
            panel2.TabIndex = 58;
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
            label1.Size = new Size(111, 15);
            label1.TabIndex = 62;
            label1.Text = "Código de compra:";
            // 
            // TCodigoVenta
            // 
            TCodigoVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TCodigoVenta.Location = new Point(632, 25);
            TCodigoVenta.Name = "TCodigoVenta";
            TCodigoVenta.Size = new Size(172, 23);
            TCodigoVenta.TabIndex = 59;
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
            BBuscar.TabIndex = 60;
            BBuscar.Text = "Buscar";
            BBuscar.TextAlign = ContentAlignment.MiddleRight;
            BBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(16, 22);
            label16.Name = "label16";
            label16.Size = new Size(250, 25);
            label16.TabIndex = 0;
            label16.Text = "Ver detalle de compra:";
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
            BLimpiar.TabIndex = 61;
            BLimpiar.Text = "Limpiar";
            BLimpiar.TextAlign = ContentAlignment.MiddleRight;
            BLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiar.UseVisualStyleBackColor = true;
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
            panel1.Size = new Size(471, 68);
            panel1.TabIndex = 59;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.4255867F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.5744133F));
            tableLayoutPanel1.Controls.Add(label12, 1, 0);
            tableLayoutPanel1.Controls.Add(label15, 0, 0);
            tableLayoutPanel1.Controls.Add(TNombreUsuario, 1, 1);
            tableLayoutPanel1.Controls.Add(TDocumentoUsuario, 0, 1);
            tableLayoutPanel1.Location = new Point(84, 7);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
            tableLayoutPanel1.Size = new Size(372, 50);
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
            // TNombreUsuario
            // 
            TNombreUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TNombreUsuario.Font = new Font("Microsoft Sans Serif", 9.75F);
            TNombreUsuario.Location = new Point(149, 19);
            TNombreUsuario.Name = "TNombreUsuario";
            TNombreUsuario.Size = new Size(220, 22);
            TNombreUsuario.TabIndex = 8;
            // 
            // TDocumentoUsuario
            // 
            TDocumentoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TDocumentoUsuario.Font = new Font("Microsoft Sans Serif", 9.75F);
            TDocumentoUsuario.Location = new Point(3, 19);
            TDocumentoUsuario.Name = "TDocumentoUsuario";
            TDocumentoUsuario.Size = new Size(140, 22);
            TDocumentoUsuario.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(168, 100, 50);
            label14.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(6, 39);
            label14.Name = "label14";
            label14.Size = new Size(67, 18);
            label14.TabIndex = 63;
            label14.Text = "Usuario";
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
            panel3.Controls.Add(label5);
            panel3.Controls.Add(iconPictureBox2);
            panel3.Location = new Point(494, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(563, 68);
            panel3.TabIndex = 60;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.1282043F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.8717957F));
            tableLayoutPanel2.Controls.Add(label13, 1, 0);
            tableLayoutPanel2.Controls.Add(label19, 0, 0);
            tableLayoutPanel2.Controls.Add(TRazonSocialProv, 1, 1);
            tableLayoutPanel2.Controls.Add(TDocumentoProv, 0, 1);
            tableLayoutPanel2.Location = new Point(92, 7);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
            tableLayoutPanel2.Size = new Size(459, 50);
            tableLayoutPanel2.TabIndex = 65;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(141, 0);
            label13.Name = "label13";
            label13.Size = new Size(101, 16);
            label13.TabIndex = 61;
            label13.Text = "Razon social:";
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
            // TRazonSocialProv
            // 
            TRazonSocialProv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TRazonSocialProv.Font = new Font("Microsoft Sans Serif", 9.75F);
            TRazonSocialProv.Location = new Point(141, 19);
            TRazonSocialProv.Name = "TRazonSocialProv";
            TRazonSocialProv.Size = new Size(315, 22);
            TRazonSocialProv.TabIndex = 8;
            // 
            // TDocumentoProv
            // 
            TDocumentoProv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TDocumentoProv.Font = new Font("Microsoft Sans Serif", 9.75F);
            TDocumentoProv.Location = new Point(3, 19);
            TDocumentoProv.Name = "TDocumentoProv";
            TDocumentoProv.Size = new Size(132, 22);
            TDocumentoProv.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(168, 100, 50);
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1, 40);
            label5.Name = "label5";
            label5.Size = new Size(86, 18);
            label5.TabIndex = 61;
            label5.Text = "Proveedor";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(168, 100, 50);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.Location = new Point(27, 7);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.TabIndex = 60;
            iconPictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(168, 100, 50);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(tableLayoutPanel3);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(iconPictureBox5);
            panel4.Location = new Point(17, 168);
            panel4.Name = "panel4";
            panel4.Size = new Size(584, 68);
            panel4.TabIndex = 61;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.0629921F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.9370079F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 224F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(TFecha, 0, 1);
            tableLayoutPanel3.Controls.Add(label26, 2, 0);
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(label24, 0, 0);
            tableLayoutPanel3.Controls.Add(THora, 1, 1);
            tableLayoutPanel3.Controls.Add(TTipoDocumento, 2, 1);
            tableLayoutPanel3.Location = new Point(84, 7);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
            tableLayoutPanel3.Size = new Size(477, 50);
            tableLayoutPanel3.TabIndex = 64;
            // 
            // TFecha
            // 
            TFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TFecha.Font = new Font("Microsoft Sans Serif", 9.75F);
            TFecha.Location = new Point(3, 19);
            TFecha.Name = "TFecha";
            TFecha.Size = new Size(110, 22);
            TFecha.TabIndex = 63;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label26.ForeColor = Color.White;
            label26.Location = new Point(255, 0);
            label26.Name = "label26";
            label26.Size = new Size(145, 16);
            label26.TabIndex = 62;
            label26.Text = "Tipo de documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(119, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 16);
            label2.TabIndex = 61;
            label2.Text = "Hora:";
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
            THora.Location = new Point(119, 19);
            THora.Name = "THora";
            THora.Size = new Size(130, 22);
            THora.TabIndex = 8;
            // 
            // TTipoDocumento
            // 
            TTipoDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TTipoDocumento.Font = new Font("Microsoft Sans Serif", 9.75F);
            TTipoDocumento.Location = new Point(255, 19);
            TTipoDocumento.Name = "TTipoDocumento";
            TTipoDocumento.Size = new Size(219, 22);
            TTipoDocumento.TabIndex = 5;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.FromArgb(168, 100, 50);
            label25.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.White;
            label25.Location = new Point(5, 37);
            label25.Name = "label25";
            label25.Size = new Size(68, 18);
            label25.TabIndex = 63;
            label25.Text = "Compra";
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.FromArgb(168, 100, 50);
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Truck;
            iconPictureBox5.IconColor = Color.White;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.Location = new Point(23, 7);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(32, 32);
            iconPictureBox5.TabIndex = 62;
            iconPictureBox5.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(168, 100, 50);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tableLayoutPanel4);
            panel5.Controls.Add(label29);
            panel5.Controls.Add(iconPictureBox6);
            panel5.Location = new Point(607, 168);
            panel5.Name = "panel5";
            panel5.Size = new Size(450, 68);
            panel5.TabIndex = 62;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(label28, 0, 0);
            tableLayoutPanel4.Controls.Add(TMontoTotal, 0, 1);
            tableLayoutPanel4.Location = new Point(68, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 36.53846F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 63.46154F));
            tableLayoutPanel4.Size = new Size(370, 52);
            tableLayoutPanel4.TabIndex = 66;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label28.ForeColor = Color.White;
            label28.Location = new Point(3, 0);
            label28.Name = "label28";
            label28.Size = new Size(87, 16);
            label28.TabIndex = 62;
            label28.Text = "Monto total:";
            // 
            // TMontoTotal
            // 
            TMontoTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TMontoTotal.Font = new Font("Microsoft Sans Serif", 11.25F);
            TMontoTotal.Location = new Point(3, 21);
            TMontoTotal.Name = "TMontoTotal";
            TMontoTotal.Size = new Size(364, 24);
            TMontoTotal.TabIndex = 61;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.FromArgb(168, 100, 50);
            label29.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.White;
            label29.Location = new Point(10, 36);
            label29.Name = "label29";
            label29.Size = new Size(52, 18);
            label29.TabIndex = 65;
            label29.Text = "Pago:";
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.FromArgb(168, 100, 50);
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            iconPictureBox6.IconColor = Color.White;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.Location = new Point(18, 5);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(32, 32);
            iconPictureBox6.TabIndex = 64;
            iconPictureBox6.TabStop = false;
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
            BDescargar.Location = new Point(864, 579);
            BDescargar.Name = "BDescargar";
            BDescargar.Size = new Size(193, 49);
            BDescargar.TabIndex = 63;
            BDescargar.Text = "Descargar en PDF";
            BDescargar.TextAlign = ContentAlignment.MiddleRight;
            BDescargar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BDescargar.UseVisualStyleBackColor = false;
            // 
            // frmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 636);
            Controls.Add(BDescargar);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvData);
            Name = "frmDetalleCompra";
            Text = "frmDetalleCompra";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
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
        private GroupBox groupBox3;
        private TextBox TDocUsuario;
        private TextBox TTipoDocumento;
        private TextBox TIdCompra;
        private DataGridView dgvData;
        private Label label3;
        private TextBox TTotal;
        private Panel panel2;
        private Label label16;
        private Label label1;
        private TextBox TCodigoVenta;
        private FontAwesome.Sharp.IconButton BBuscar;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label12;
        private Label label15;
        private TextBox TNombreUsuario;
        private TextBox TDocumentoUsuario;
        private Label label14;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label13;
        private Label label19;
        private TextBox TRazonSocialProv;
        private TextBox TDocumentoProv;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label26;
        private Label label2;
        private Label label24;
        private TextBox THora;
        private Label label25;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private TextBox TFecha;
        private Panel panel5;
        private Label label29;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label28;
        private TextBox TMontoTotal;
        private FontAwesome.Sharp.IconButton BDescargar;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subTotal;
    }
}