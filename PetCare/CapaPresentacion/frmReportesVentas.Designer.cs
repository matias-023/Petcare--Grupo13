namespace CapaPresentacion
{
    partial class frmReportesVentas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            BBuscarReporte = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label3 = new Label();
            txtfechafin = new DateTimePicker();
            txtfechainicio = new DateTimePicker();
            CBusqueda = new ComboBox();
            TBusqueda = new TextBox();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            BDescargarExcel = new FontAwesome.Sharp.IconButton();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label1 = new Label();
            dgvDetalle = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precioVta = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label9 = new Label();
            dgvData = new DataGridView();
            idVenta = new DataGridViewTextBoxColumn();
            verDetalle = new DataGridViewButtonColumn();
            fechaRegistro = new DataGridViewTextBoxColumn();
            horaRegistro = new DataGridViewTextBoxColumn();
            tipoDocumento = new DataGridViewTextBoxColumn();
            numeroVenta = new DataGridViewTextBoxColumn();
            documentoUsuario = new DataGridViewTextBoxColumn();
            nombreUsuario = new DataGridViewTextBoxColumn();
            documentoCliente = new DataGridViewTextBoxColumn();
            nombreCliente = new DataGridViewTextBoxColumn();
            montoTotal = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            LDetalleVenta = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // BBuscarReporte
            // 
            BBuscarReporte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BBuscarReporte.Font = new Font("Microsoft Sans Serif", 12F);
            BBuscarReporte.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscarReporte.IconColor = Color.Black;
            BBuscarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscarReporte.IconSize = 18;
            BBuscarReporte.Location = new Point(886, 13);
            BBuscarReporte.Name = "BBuscarReporte";
            BBuscarReporte.Size = new Size(116, 32);
            BBuscarReporte.TabIndex = 3;
            BBuscarReporte.Text = "Buscar";
            BBuscarReporte.TextAlign = ContentAlignment.MiddleRight;
            BBuscarReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscarReporte.UseVisualStyleBackColor = true;
            BBuscarReporte.Click += BBuscarReporte_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(210, 120, 61);
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(643, 21);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 18);
            label4.TabIndex = 43;
            label4.Text = "Fecha Fin:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(210, 120, 61);
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(375, 21);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 42;
            label3.Text = "Fecha inicio:";
            // 
            // txtfechafin
            // 
            txtfechafin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtfechafin.CustomFormat = "dd/MM/yyyy";
            txtfechafin.Font = new Font("Microsoft Sans Serif", 13F);
            txtfechafin.Format = DateTimePickerFormat.Short;
            txtfechafin.Location = new Point(738, 18);
            txtfechafin.Margin = new Padding(4, 2, 4, 2);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new Size(132, 27);
            txtfechafin.TabIndex = 2;
            // 
            // txtfechainicio
            // 
            txtfechainicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtfechainicio.CalendarMonthBackground = Color.FromArgb(210, 120, 61);
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Font = new Font("Microsoft Sans Serif", 13F);
            txtfechainicio.Format = DateTimePickerFormat.Short;
            txtfechainicio.Location = new Point(487, 18);
            txtfechainicio.Margin = new Padding(4, 2, 4, 2);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(137, 27);
            txtfechainicio.TabIndex = 1;
            // 
            // CBusqueda
            // 
            CBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.Font = new Font("Microsoft Sans Serif", 12F);
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(410, 14);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(227, 28);
            CBusqueda.TabIndex = 5;
            // 
            // TBusqueda
            // 
            TBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TBusqueda.Font = new Font("Microsoft Sans Serif", 12F);
            TBusqueda.Location = new Point(643, 15);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(250, 26);
            TBusqueda.TabIndex = 6;
            TBusqueda.KeyDown += TBusqueda_KeyDown;
            // 
            // BLimpiarBusqueda
            // 
            BLimpiarBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BLimpiarBusqueda.BackColor = Color.White;
            BLimpiarBusqueda.Cursor = Cursors.Hand;
            BLimpiarBusqueda.FlatAppearance.BorderColor = Color.Black;
            BLimpiarBusqueda.FlatStyle = FlatStyle.Flat;
            BLimpiarBusqueda.ForeColor = Color.White;
            BLimpiarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Broom;
            BLimpiarBusqueda.IconColor = Color.Black;
            BLimpiarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BLimpiarBusqueda.IconSize = 20;
            BLimpiarBusqueda.Location = new Point(952, 12);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(50, 29);
            BLimpiarBusqueda.TabIndex = 8;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            BLimpiarBusqueda.Click += BLimpiarBusqueda_Click;
            // 
            // BDescargarExcel
            // 
            BDescargarExcel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BDescargarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            BDescargarExcel.IconColor = Color.Black;
            BDescargarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BDescargarExcel.IconSize = 18;
            BDescargarExcel.Location = new Point(28, 7);
            BDescargarExcel.Name = "BDescargarExcel";
            BDescargarExcel.Size = new Size(168, 35);
            BDescargarExcel.TabIndex = 4;
            BDescargarExcel.Text = "Descargar Excel";
            BDescargarExcel.TextAlign = ContentAlignment.MiddleRight;
            BDescargarExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            BDescargarExcel.UseVisualStyleBackColor = true;
            BDescargarExcel.Click += BDescargarExcel_Click;
            // 
            // BBusqueda
            // 
            BBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BBusqueda.BackColor = Color.White;
            BBusqueda.Cursor = Cursors.Hand;
            BBusqueda.FlatAppearance.BorderColor = Color.Black;
            BBusqueda.FlatStyle = FlatStyle.Flat;
            BBusqueda.ForeColor = Color.White;
            BBusqueda.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBusqueda.IconColor = Color.Black;
            BBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBusqueda.IconSize = 20;
            BBusqueda.Location = new Point(899, 12);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(47, 29);
            BBusqueda.TabIndex = 7;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
            BBusqueda.Click += BBusqueda_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtfechainicio);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BBuscarReporte);
            panel2.Controls.Add(txtfechafin);
            panel2.Location = new Point(23, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1017, 55);
            panel2.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 0;
            label1.Text = "Reporte de ventas:";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { codigo, nombre, cantidad, precioVta, subTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalle.Location = new Point(3, 235);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvDetalle.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetalle.RowTemplate.Height = 28;
            dgvDetalle.Size = new Size(1011, 175);
            dgvDetalle.TabIndex = 58;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.Width = 125;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.Width = 150;
            // 
            // precioVta
            // 
            precioVta.HeaderText = "Precio Vta";
            precioVta.Name = "precioVta";
            precioVta.Width = 150;
            // 
            // subTotal
            // 
            subTotal.HeaderText = "Sub Total";
            subTotal.Name = "subTotal";
            subTotal.Width = 175;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(210, 120, 61);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(BDescargarExcel);
            panel1.Controls.Add(CBusqueda);
            panel1.Controls.Add(TBusqueda);
            panel1.Controls.Add(BLimpiarBusqueda);
            panel1.Controls.Add(BBusqueda);
            panel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(23, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 52);
            panel1.TabIndex = 56;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(210, 120, 61);
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(314, 18);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 54;
            label9.Text = "Buscar por:";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { idVenta, verDetalle, fechaRegistro, horaRegistro, tipoDocumento, numeroVenta, documentoUsuario, nombreUsuario, documentoCliente, nombreCliente, montoTotal });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvData.DefaultCellStyle = dataGridViewCellStyle5;
            dgvData.Location = new Point(3, 3);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(1011, 179);
            dgvData.TabIndex = 57;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellPainting += dgvData_CellPainting;
            // 
            // idVenta
            // 
            idVenta.HeaderText = "idVenta";
            idVenta.Name = "idVenta";
            idVenta.Visible = false;
            // 
            // verDetalle
            // 
            verDetalle.HeaderText = "";
            verDetalle.MinimumWidth = 6;
            verDetalle.Name = "verDetalle";
            verDetalle.Resizable = DataGridViewTriState.True;
            verDetalle.SortMode = DataGridViewColumnSortMode.Automatic;
            verDetalle.Width = 35;
            // 
            // fechaRegistro
            // 
            fechaRegistro.HeaderText = "Fecha";
            fechaRegistro.MinimumWidth = 6;
            fechaRegistro.Name = "fechaRegistro";
            // 
            // horaRegistro
            // 
            horaRegistro.HeaderText = "Hora";
            horaRegistro.Name = "horaRegistro";
            // 
            // tipoDocumento
            // 
            tipoDocumento.HeaderText = "Tipo Documento";
            tipoDocumento.MinimumWidth = 6;
            tipoDocumento.Name = "tipoDocumento";
            tipoDocumento.Width = 125;
            // 
            // numeroVenta
            // 
            numeroVenta.HeaderText = "Nro de Venta";
            numeroVenta.MinimumWidth = 6;
            numeroVenta.Name = "numeroVenta";
            numeroVenta.Width = 125;
            // 
            // documentoUsuario
            // 
            documentoUsuario.HeaderText = "Documento Usuario";
            documentoUsuario.Name = "documentoUsuario";
            documentoUsuario.Width = 125;
            // 
            // nombreUsuario
            // 
            nombreUsuario.HeaderText = "Nombre Usuario";
            nombreUsuario.MinimumWidth = 6;
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.Width = 150;
            // 
            // documentoCliente
            // 
            documentoCliente.HeaderText = "Documento Cliente";
            documentoCliente.MinimumWidth = 6;
            documentoCliente.Name = "documentoCliente";
            documentoCliente.Width = 125;
            // 
            // nombreCliente
            // 
            nombreCliente.HeaderText = "Nombre Cliente";
            nombreCliente.MinimumWidth = 6;
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Width = 150;
            // 
            // montoTotal
            // 
            montoTotal.HeaderText = "Monto Total";
            montoTotal.MinimumWidth = 6;
            montoTotal.Name = "montoTotal";
            montoTotal.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvData, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvDetalle, 0, 2);
            tableLayoutPanel1.Location = new Point(23, 137);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6222763F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.5835342F));
            tableLayoutPanel1.Size = new Size(1017, 413);
            tableLayoutPanel1.TabIndex = 57;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(210, 120, 61);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(LDetalleVenta);
            panel3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(3, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(1011, 41);
            panel3.TabIndex = 59;
            // 
            // LDetalleVenta
            // 
            LDetalleVenta.AutoSize = true;
            LDetalleVenta.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LDetalleVenta.ForeColor = Color.White;
            LDetalleVenta.Location = new Point(16, 8);
            LDetalleVenta.Name = "LDetalleVenta";
            LDetalleVenta.Size = new Size(166, 24);
            LDetalleVenta.TabIndex = 1;
            LDetalleVenta.Text = "Detalle de venta:";
            // 
            // frmReportesVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 562);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmReportesVentas";
            Text = "frmReportesVentas";
            Load += frmReportesVentas_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton BBuscarReporte;
        private Label label4;
        private Label label3;
        private DateTimePicker txtfechafin;
        private DateTimePicker txtfechainicio;
        private ComboBox CBusqueda;
        private TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private FontAwesome.Sharp.IconButton BDescargarExcel;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label9;
        private DataGridView dgvData;
        private DataGridView dgvDetalle;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label LDetalleVenta;
        private DataGridViewTextBoxColumn idVenta;
        private DataGridViewButtonColumn verDetalle;
        private DataGridViewTextBoxColumn fechaRegistro;
        private DataGridViewTextBoxColumn horaRegistro;
        private DataGridViewTextBoxColumn tipoDocumento;
        private DataGridViewTextBoxColumn numeroVenta;
        private DataGridViewTextBoxColumn documentoUsuario;
        private DataGridViewTextBoxColumn nombreUsuario;
        private DataGridViewTextBoxColumn documentoCliente;
        private DataGridViewTextBoxColumn nombreCliente;
        private DataGridViewTextBoxColumn montoTotal;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precioVta;
        private DataGridViewTextBoxColumn subTotal;
    }
}