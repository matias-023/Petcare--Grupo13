namespace CapaPresentacion
{
    partial class frmReportes
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
            CTipoReporte = new ComboBox();
            label3 = new Label();
            TFechaInicio = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            BBuscar = new FontAwesome.Sharp.IconButton();
            TFechaFin = new DateTimePicker();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            dgvData = new DataGridView();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(CTipoReporte);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(TFechaInicio);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BBuscar);
            panel2.Controls.Add(TFechaFin);
            panel2.Location = new Point(26, 27);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1162, 125);
            panel2.TabIndex = 58;
            // 
            // CTipoReporte
            // 
            CTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            CTipoReporte.FormattingEnabled = true;
            CTipoReporte.Location = new Point(16, 77);
            CTipoReporte.Margin = new Padding(3, 4, 3, 4);
            CTipoReporte.Name = "CTipoReporte";
            CTipoReporte.Size = new Size(345, 28);
            CTipoReporte.TabIndex = 67;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(210, 120, 61);
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(519, 79);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 65;
            label3.Text = "Fecha inicio:";
            // 
            // TFechaInicio
            // 
            TFechaInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TFechaInicio.CalendarMonthBackground = Color.FromArgb(210, 120, 61);
            TFechaInicio.CustomFormat = "dd/MM/yyyy";
            TFechaInicio.Font = new Font("Microsoft Sans Serif", 9F);
            TFechaInicio.Format = DateTimePickerFormat.Short;
            TFechaInicio.Location = new Point(638, 76);
            TFechaInicio.Margin = new Padding(6, 4, 6, 4);
            TFechaInicio.Name = "TFechaInicio";
            TFechaInicio.Size = new Size(126, 24);
            TFechaInicio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(142, 31);
            label1.TabIndex = 0;
            label1.Text = "Reportes:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(210, 120, 61);
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(778, 79);
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
            BBuscar.Location = new Point(1025, 75);
            BBuscar.Margin = new Padding(3, 4, 3, 4);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(104, 31);
            BBuscar.TabIndex = 3;
            BBuscar.Text = "Buscar";
            BBuscar.TextAlign = ContentAlignment.MiddleRight;
            BBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // TFechaFin
            // 
            TFechaFin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TFechaFin.CustomFormat = "dd/MM/yyyy";
            TFechaFin.Font = new Font("Microsoft Sans Serif", 9F);
            TFechaFin.Format = DateTimePickerFormat.Short;
            TFechaFin.Location = new Point(879, 76);
            TFechaFin.Margin = new Padding(6, 4, 6, 4);
            TFechaFin.Name = "TFechaFin";
            TFechaFin.Size = new Size(126, 24);
            TFechaFin.TabIndex = 2;
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
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
            dgvData.Location = new Point(26, 160);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(1162, 566);
            dgvData.TabIndex = 60;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(271, 362);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(761, 337);
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 749);
            Controls.Add(pictureBox1);
            Controls.Add(dgvData);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmReportes";
            Load += frmReportes_Load;
            Resize += frmReportes_Resize;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Label label3;
        private DateTimePicker TFechaInicio;
        private Label label4;
        private FontAwesome.Sharp.IconButton BBuscar;
        private DateTimePicker TFechaFin;
        private ComboBox CTipoReporte;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private DataGridView dgvData;
        private PictureBox pictureBox1;
    }
}