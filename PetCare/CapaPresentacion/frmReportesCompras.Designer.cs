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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label9 = new Label();
            BDescargarExcel = new FontAwesome.Sharp.IconButton();
            CBusqueda = new ComboBox();
            TBusqueda = new TextBox();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            BBuscar = new FontAwesome.Sharp.IconButton();
            dateTimePicker2 = new DateTimePicker();
            dgvData = new DataGridView();
            fechaRegistro = new DataGridViewTextBoxColumn();
            numeroCompra = new DataGridViewTextBoxColumn();
            DocumentoUsuario = new DataGridViewTextBoxColumn();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            razonSocialProv = new DataGridViewTextBoxColumn();
            montoTotal = new DataGridViewTextBoxColumn();
            verDetalle = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
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
            panel1.Controls.Add(BBusqueda);
            panel1.Controls.Add(BLimpiarBusqueda);
            panel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(26, 147);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 67);
            panel1.TabIndex = 59;
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
            label9.TabIndex = 64;
            label9.Text = "Buscar por:";
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
            TBusqueda.Size = new Size(247, 24);
            TBusqueda.TabIndex = 6;
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
            BBusqueda.Location = new Point(992, 16);
            BBusqueda.Margin = new Padding(3, 4, 3, 4);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(54, 39);
            BBusqueda.TabIndex = 7;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
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
            BLimpiarBusqueda.Location = new Point(1053, 16);
            BLimpiarBusqueda.Margin = new Padding(3, 4, 3, 4);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(57, 39);
            BLimpiarBusqueda.TabIndex = 8;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BBuscar);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Location = new Point(26, 27);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1162, 90);
            panel2.TabIndex = 58;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(210, 120, 61);
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(499, 37);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 65;
            label3.Text = "Fecha inicio:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(210, 120, 61);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(618, 35);
            dateTimePicker1.Margin = new Padding(6, 4, 6, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 24);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(286, 31);
            label1.TabIndex = 0;
            label1.Text = "Reporte de compras:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(210, 120, 61);
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(759, 37);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 24);
            label4.TabIndex = 66;
            label4.Text = "Fecha Fin:";
            // 
            // BBuscar
            // 
            BBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BBuscar.Font = new Font("Microsoft Sans Serif", 9F);
            BBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscar.IconColor = Color.Black;
            BBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscar.IconSize = 18;
            BBuscar.Location = new Point(1006, 33);
            BBuscar.Margin = new Padding(3, 4, 3, 4);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(104, 31);
            BBuscar.TabIndex = 3;
            BBuscar.Text = "Buscar";
            BBuscar.TextAlign = ContentAlignment.MiddleRight;
            BBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(859, 35);
            dateTimePicker2.Margin = new Padding(6, 4, 6, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(126, 24);
            dateTimePicker2.TabIndex = 2;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { fechaRegistro, numeroCompra, DocumentoUsuario, DocumentoProveedor, razonSocialProv, montoTotal, verDetalle });
            dgvData.Location = new Point(26, 245);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(1162, 587);
            dgvData.TabIndex = 60;
            // 
            // fechaRegistro
            // 
            fechaRegistro.HeaderText = "Fecha de registro";
            fechaRegistro.MinimumWidth = 6;
            fechaRegistro.Name = "fechaRegistro";
            fechaRegistro.ReadOnly = true;
            fechaRegistro.Width = 250;
            // 
            // numeroCompra
            // 
            numeroCompra.HeaderText = "Número de compra";
            numeroCompra.MinimumWidth = 6;
            numeroCompra.Name = "numeroCompra";
            numeroCompra.ReadOnly = true;
            numeroCompra.Width = 180;
            // 
            // DocumentoUsuario
            // 
            DocumentoUsuario.HeaderText = "Documento del Usuario";
            DocumentoUsuario.MinimumWidth = 6;
            DocumentoUsuario.Name = "DocumentoUsuario";
            DocumentoUsuario.ReadOnly = true;
            DocumentoUsuario.Width = 250;
            // 
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "Documento del Proveedor";
            DocumentoProveedor.MinimumWidth = 6;
            DocumentoProveedor.Name = "DocumentoProveedor";
            DocumentoProveedor.ReadOnly = true;
            DocumentoProveedor.Width = 250;
            // 
            // razonSocialProv
            // 
            razonSocialProv.HeaderText = "Razon social Proveedor";
            razonSocialProv.MinimumWidth = 6;
            razonSocialProv.Name = "razonSocialProv";
            razonSocialProv.ReadOnly = true;
            razonSocialProv.Width = 275;
            // 
            // montoTotal
            // 
            montoTotal.HeaderText = "Monto Total";
            montoTotal.MinimumWidth = 6;
            montoTotal.Name = "montoTotal";
            montoTotal.ReadOnly = true;
            montoTotal.Width = 205;
            // 
            // verDetalle
            // 
            verDetalle.HeaderText = "Ver detalle";
            verDetalle.MinimumWidth = 6;
            verDetalle.Name = "verDetalle";
            verDetalle.ReadOnly = true;
            verDetalle.Width = 180;
            // 
            // frmReportesCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 848);
            Controls.Add(dgvData);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmReportesCompras";
            Text = "frmReportesCompras";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton BDescargarExcel;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private FontAwesome.Sharp.IconButton BBuscar;
        private DateTimePicker dateTimePicker2;
        private Label label9;
        private ComboBox CBusqueda;
        private TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn fechaRegistro;
        private DataGridViewTextBoxColumn numeroCompra;
        private DataGridViewTextBoxColumn DocumentoUsuario;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridViewTextBoxColumn razonSocialProv;
        private DataGridViewTextBoxColumn montoTotal;
        private DataGridViewButtonColumn verDetalle;
    }
}