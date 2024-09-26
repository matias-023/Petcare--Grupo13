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
            BBuscar = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            TBusqueda = new TextBox();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            BDescargarExcelRegCom = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            DocumentoCliente = new DataGridViewTextBoxColumn();
            nombreCliente = new DataGridViewTextBoxColumn();
            VerDetalleVen = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BBuscar
            // 
            BBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscar.IconColor = Color.Black;
            BBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscar.IconSize = 18;
            BBuscar.Location = new Point(547, 107);
            BBuscar.Margin = new Padding(3, 4, 3, 4);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(105, 31);
            BBuscar.TabIndex = 45;
            BBuscar.Text = "Buscar";
            BBuscar.TextAlign = ContentAlignment.MiddleRight;
            BBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(210, 120, 61);
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(315, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 43;
            label4.Text = "Fecha Fin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(210, 120, 61);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 117);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 42;
            label3.Text = "Fecha inicio:";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(210, 120, 61);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(255, 38);
            label2.TabIndex = 40;
            label2.Text = "Reporte Ventas";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(412, 111);
            dateTimePicker2.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(128, 27);
            dateTimePicker2.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(210, 120, 61);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(181, 113);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(128, 27);
            dateTimePicker1.TabIndex = 38;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(210, 120, 61);
            label1.Location = new Point(28, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1505, 143);
            label1.TabIndex = 39;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(820, 262);
            label7.Name = "label7";
            label7.Size = new Size(85, 18);
            label7.TabIndex = 54;
            label7.Text = "Buscar por:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(911, 252);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 28);
            comboBox1.TabIndex = 53;
            // 
            // TBusqueda
            // 
            TBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TBusqueda.Location = new Point(1115, 252);
            TBusqueda.Margin = new Padding(3, 4, 3, 4);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(246, 27);
            TBusqueda.TabIndex = 52;
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
            BLimpiarBusqueda.Location = new Point(1427, 247);
            BLimpiarBusqueda.Margin = new Padding(3, 4, 3, 4);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(57, 39);
            BLimpiarBusqueda.TabIndex = 51;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            // 
            // BDescargarExcelRegCom
            // 
            BDescargarExcelRegCom.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            BDescargarExcelRegCom.IconColor = Color.Black;
            BDescargarExcelRegCom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BDescargarExcelRegCom.IconSize = 18;
            BDescargarExcelRegCom.Location = new Point(80, 262);
            BDescargarExcelRegCom.Margin = new Padding(3, 4, 3, 4);
            BDescargarExcelRegCom.Name = "BDescargarExcelRegCom";
            BDescargarExcelRegCom.Size = new Size(166, 31);
            BDescargarExcelRegCom.TabIndex = 50;
            BDescargarExcelRegCom.Text = "Descargar Excel";
            BDescargarExcelRegCom.TextAlign = ContentAlignment.MiddleRight;
            BDescargarExcelRegCom.TextImageRelation = TextImageRelation.ImageBeforeText;
            BDescargarExcelRegCom.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoCliente, nombreCliente, VerDetalleVen });
            dataGridView1.Location = new Point(65, 314);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1429, 488);
            dataGridView1.TabIndex = 49;
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
            BBusqueda.Location = new Point(1367, 247);
            BBusqueda.Margin = new Padding(3, 4, 3, 4);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(54, 39);
            BBusqueda.TabIndex = 47;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(28, 227);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(1549, 656);
            label6.TabIndex = 48;
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
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "Usuario Registro";
            UsuarioRegistro.MinimumWidth = 6;
            UsuarioRegistro.Name = "UsuarioRegistro";
            UsuarioRegistro.Width = 125;
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.HeaderText = "Documento Cliente";
            DocumentoCliente.MinimumWidth = 6;
            DocumentoCliente.Name = "DocumentoCliente";
            DocumentoCliente.Width = 125;
            // 
            // nombreCliente
            // 
            nombreCliente.HeaderText = "Nombre Cliente";
            nombreCliente.MinimumWidth = 6;
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Width = 125;
            // 
            // VerDetalleVen
            // 
            VerDetalleVen.HeaderText = "Ver Detalle";
            VerDetalleVen.MinimumWidth = 6;
            VerDetalleVen.Name = "VerDetalleVen";
            VerDetalleVen.Resizable = DataGridViewTriState.True;
            VerDetalleVen.SortMode = DataGridViewColumnSortMode.Automatic;
            VerDetalleVen.Text = "Ver Venta";
            VerDetalleVen.Width = 125;
            // 
            // frmReportesVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 985);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(TBusqueda);
            Controls.Add(BLimpiarBusqueda);
            Controls.Add(BDescargarExcelRegCom);
            Controls.Add(dataGridView1);
            Controls.Add(BBusqueda);
            Controls.Add(label6);
            Controls.Add(BBuscar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "frmReportesVentas";
            Text = "frmReportesVentas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton BBuscar;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label7;
        private ComboBox comboBox1;
        private TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private FontAwesome.Sharp.IconButton BDescargarExcelRegCom;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private Label label6;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn DocumentoCliente;
        private DataGridViewTextBoxColumn nombreCliente;
        private DataGridViewButtonColumn VerDetalleVen;
    }
}