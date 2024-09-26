namespace CapaPresentacion
{
    partial class frmReportesCompras
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            BDescargarExcelRegCom = new FontAwesome.Sharp.IconButton();
            BBuscar = new FontAwesome.Sharp.IconButton();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            TBusqueda = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            CBusqueda = new ComboBox();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            VerDetalleCom = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(210, 120, 61);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(168, 114);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(128, 30);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(210, 120, 61);
            label1.Location = new Point(15, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1505, 143);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(210, 120, 61);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(255, 38);
            label2.TabIndex = 2;
            label2.Text = "Reporte Compras";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(399, 112);
            dateTimePicker2.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(128, 30);
            dateTimePicker2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(210, 120, 61);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 118);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 4;
            label3.Text = "Fecha inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(210, 120, 61);
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(302, 116);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 5;
            label4.Text = "Fecha Fin:";
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
            BBusqueda.Location = new Point(1299, 216);
            BBusqueda.Margin = new Padding(3, 4, 3, 4);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(54, 39);
            BBusqueda.TabIndex = 16;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(210, 120, 61);
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1003, 118);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 28;
            label5.Text = "Proveedor:";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(15, 201);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(1549, 656);
            label6.TabIndex = 29;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, DocumentoProveedor, RazonSocial, VerDetalleCom });
            dataGridView1.Location = new Point(39, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1429, 488);
            dataGridView1.TabIndex = 30;
            // 
            // BDescargarExcelRegCom
            // 
            BDescargarExcelRegCom.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            BDescargarExcelRegCom.IconColor = Color.Black;
            BDescargarExcelRegCom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BDescargarExcelRegCom.IconSize = 18;
            BDescargarExcelRegCom.Location = new Point(52, 224);
            BDescargarExcelRegCom.Margin = new Padding(3, 4, 3, 4);
            BDescargarExcelRegCom.Name = "BDescargarExcelRegCom";
            BDescargarExcelRegCom.Size = new Size(166, 31);
            BDescargarExcelRegCom.TabIndex = 31;
            BDescargarExcelRegCom.Text = "Descargar Excel";
            BDescargarExcelRegCom.TextAlign = ContentAlignment.MiddleRight;
            BDescargarExcelRegCom.TextImageRelation = TextImageRelation.ImageBeforeText;
            BDescargarExcelRegCom.UseVisualStyleBackColor = true;
            // 
            // BBuscar
            // 
            BBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscar.IconColor = Color.Black;
            BBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscar.IconSize = 18;
            BBuscar.Location = new Point(1312, 116);
            BBuscar.Margin = new Padding(3, 4, 3, 4);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(105, 31);
            BBuscar.TabIndex = 32;
            BBuscar.Text = "Buscar";
            BBuscar.TextAlign = ContentAlignment.MiddleRight;
            BBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscar.UseVisualStyleBackColor = true;
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
            BLimpiarBusqueda.Location = new Point(1359, 216);
            BLimpiarBusqueda.Margin = new Padding(3, 4, 3, 4);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(57, 39);
            BLimpiarBusqueda.TabIndex = 33;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            // 
            // TBusqueda
            // 
            TBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TBusqueda.Location = new Point(1047, 221);
            TBusqueda.Margin = new Padding(3, 4, 3, 4);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(246, 30);
            TBusqueda.TabIndex = 34;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(843, 221);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 31);
            comboBox1.TabIndex = 35;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(752, 231);
            label7.Name = "label7";
            label7.Size = new Size(85, 18);
            label7.TabIndex = 36;
            label7.Text = "Buscar por:";
            // 
            // CBusqueda
            // 
            CBusqueda.Anchor = AnchorStyles.None;
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(1108, 117);
            CBusqueda.Margin = new Padding(3, 4, 3, 4);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(198, 31);
            CBusqueda.TabIndex = 37;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.MinimumWidth = 6;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Width = 125;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "TipoDocumento";
            TipoDocumento.MinimumWidth = 6;
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.Width = 125;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "NumeroDocumento";
            NumeroDocumento.MinimumWidth = 6;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.Width = 125;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.Width = 125;
            // 
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "Documento Proveedor";
            DocumentoProveedor.MinimumWidth = 6;
            DocumentoProveedor.Name = "DocumentoProveedor";
            DocumentoProveedor.Width = 125;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.MinimumWidth = 6;
            RazonSocial.Name = "RazonSocial";
            RazonSocial.Width = 125;
            // 
            // VerDetalleCom
            // 
            VerDetalleCom.HeaderText = "Ver Detalle";
            VerDetalleCom.MinimumWidth = 6;
            VerDetalleCom.Name = "VerDetalleCom";
            VerDetalleCom.Resizable = DataGridViewTriState.True;
            VerDetalleCom.SortMode = DataGridViewColumnSortMode.Automatic;
            VerDetalleCom.Text = "Ver Compra";
            VerDetalleCom.Width = 125;
            // 
            // frmReportesCompras
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1577, 861);
            Controls.Add(CBusqueda);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(TBusqueda);
            Controls.Add(BLimpiarBusqueda);
            Controls.Add(BBuscar);
            Controls.Add(BDescargarExcelRegCom);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(BBusqueda);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmReportesCompras";
            Text = "frmReportesCompras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton BDescargarExcelRegCom;
        private FontAwesome.Sharp.IconButton BBuscar;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private TextBox TBusqueda;
        private ComboBox comboBox1;
        private Label label7;
        private ComboBox CBusqueda;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewButtonColumn VerDetalleCom;
    }
}