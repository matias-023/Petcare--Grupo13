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
            panel1 = new Panel();
            label9 = new Label();
            dgvData = new DataGridView();
            fechaRegistro = new DataGridViewTextBoxColumn();
            tipoDocumento = new DataGridViewTextBoxColumn();
            numeroDocumento = new DataGridViewTextBoxColumn();
            montoTotal = new DataGridViewTextBoxColumn();
            usuarioRegistro = new DataGridViewTextBoxColumn();
            documentoCliente = new DataGridViewTextBoxColumn();
            nombreCliente = new DataGridViewTextBoxColumn();
            codigoProducto = new DataGridViewTextBoxColumn();
            nombreProducto = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // BBuscarReporte
            // 
            BBuscarReporte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BBuscarReporte.Font = new Font("Microsoft Sans Serif", 9F);
            BBuscarReporte.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscarReporte.IconColor = Color.Black;
            BBuscarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscarReporte.IconSize = 18;
            BBuscarReporte.Location = new Point(1030, 33);
            BBuscarReporte.Margin = new Padding(3, 4, 3, 4);
            BBuscarReporte.Name = "BBuscarReporte";
            BBuscarReporte.Size = new Size(105, 31);
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
            label4.Location = new Point(777, 35);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 24);
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
            label3.Location = new Point(499, 37);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 42;
            label3.Text = "Fecha inicio:";
            // 
            // txtfechafin
            // 
            txtfechafin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtfechafin.CustomFormat = "dd/MM/yyyy";
            txtfechafin.Font = new Font("Microsoft Sans Serif", 9F);
            txtfechafin.Format = DateTimePickerFormat.Short;
            txtfechafin.Location = new Point(895, 36);
            txtfechafin.Margin = new Padding(5, 3, 5, 3);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new Size(127, 24);
            txtfechafin.TabIndex = 2;
            // 
            // txtfechainicio
            // 
            txtfechainicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtfechainicio.CalendarMonthBackground = Color.FromArgb(210, 120, 61);
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Font = new Font("Microsoft Sans Serif", 9F);
            txtfechainicio.Format = DateTimePickerFormat.Short;
            txtfechainicio.Location = new Point(640, 37);
            txtfechainicio.Margin = new Padding(5, 3, 5, 3);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(127, 24);
            txtfechainicio.TabIndex = 1;
            // 
            // CBusqueda
            // 
            CBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(529, 19);
            CBusqueda.Margin = new Padding(3, 4, 3, 4);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(198, 26);
            CBusqueda.TabIndex = 5;
            // 
            // TBusqueda
            // 
            TBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TBusqueda.Location = new Point(735, 20);
            TBusqueda.Margin = new Padding(3, 4, 3, 4);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(246, 24);
            TBusqueda.TabIndex = 6;
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
            BLimpiarBusqueda.Location = new Point(1054, 13);
            BLimpiarBusqueda.Margin = new Padding(3, 4, 3, 4);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(57, 39);
            BLimpiarBusqueda.TabIndex = 8;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            BLimpiarBusqueda.Click += BLimpiarBusqueda_Click;
            // 
            // BDescargarExcel
            // 
            BDescargarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            BDescargarExcel.IconColor = Color.Black;
            BDescargarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BDescargarExcel.IconSize = 18;
            BDescargarExcel.Location = new Point(40, 20);
            BDescargarExcel.Margin = new Padding(3, 4, 3, 4);
            BDescargarExcel.Name = "BDescargarExcel";
            BDescargarExcel.Size = new Size(166, 31);
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
            BBusqueda.Location = new Point(993, 13);
            BBusqueda.Margin = new Padding(3, 4, 3, 4);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(54, 39);
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
            panel2.Location = new Point(26, 27);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1162, 90);
            panel2.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(262, 31);
            label1.TabIndex = 0;
            label1.Text = "Reporte de ventas:";
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
            panel1.Location = new Point(26, 147);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 69);
            panel1.TabIndex = 56;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(210, 120, 61);
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(443, 24);
            label9.Name = "label9";
            label9.Size = new Size(85, 18);
            label9.TabIndex = 54;
            label9.Text = "Buscar por:";
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { fechaRegistro, tipoDocumento, numeroDocumento, montoTotal, usuarioRegistro, documentoCliente, nombreCliente, codigoProducto, nombreProducto, categoria, precioVenta, cantidad, subTotal });
            dgvData.Location = new Point(26, 224);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(1162, 509);
            dgvData.TabIndex = 57;
            // 
            // fechaRegistro
            // 
            fechaRegistro.HeaderText = "Fecha Registro";
            fechaRegistro.MinimumWidth = 6;
            fechaRegistro.Name = "fechaRegistro";
            fechaRegistro.Width = 125;
            // 
            // tipoDocumento
            // 
            tipoDocumento.HeaderText = "Tipo Documento";
            tipoDocumento.MinimumWidth = 6;
            tipoDocumento.Name = "tipoDocumento";
            tipoDocumento.Width = 125;
            // 
            // numeroDocumento
            // 
            numeroDocumento.HeaderText = "Numero Documento";
            numeroDocumento.MinimumWidth = 6;
            numeroDocumento.Name = "numeroDocumento";
            numeroDocumento.Width = 125;
            // 
            // montoTotal
            // 
            montoTotal.HeaderText = "Monto Total";
            montoTotal.MinimumWidth = 6;
            montoTotal.Name = "montoTotal";
            montoTotal.Width = 125;
            // 
            // usuarioRegistro
            // 
            usuarioRegistro.HeaderText = "Usuario Registrado";
            usuarioRegistro.MinimumWidth = 6;
            usuarioRegistro.Name = "usuarioRegistro";
            usuarioRegistro.Width = 125;
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
            nombreCliente.Width = 125;
            // 
            // codigoProducto
            // 
            codigoProducto.HeaderText = "Codigo Producto";
            codigoProducto.MinimumWidth = 6;
            codigoProducto.Name = "codigoProducto";
            codigoProducto.Width = 125;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Nombre Producto";
            nombreProducto.MinimumWidth = 6;
            nombreProducto.Name = "nombreProducto";
            nombreProducto.Width = 125;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            categoria.Width = 125;
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "Precio Venta";
            precioVenta.MinimumWidth = 6;
            precioVenta.Name = "precioVenta";
            precioVenta.Width = 125;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.Width = 125;
            // 
            // subTotal
            // 
            subTotal.HeaderText = "subTotal";
            subTotal.MinimumWidth = 6;
            subTotal.Name = "subTotal";
            subTotal.Width = 125;
            // 
            // frmReportesVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 749);
            Controls.Add(dgvData);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmReportesVentas";
            Text = "frmReportesVentas";
            Load += frmReportesVentas_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
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
        private DataGridViewTextBoxColumn fechaRegistro;
        private DataGridViewTextBoxColumn tipoDocumento;
        private DataGridViewTextBoxColumn numeroDocumento;
        private DataGridViewTextBoxColumn montoTotal;
        private DataGridViewTextBoxColumn usuarioRegistro;
        private DataGridViewTextBoxColumn documentoCliente;
        private DataGridViewTextBoxColumn nombreCliente;
        private DataGridViewTextBoxColumn codigoProducto;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subTotal;
    }
}