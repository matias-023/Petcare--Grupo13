namespace CapaPresentacion.Modals
{
    partial class mdBuscarCliente
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
            BCerrar = new PictureBox();
            titulo = new Label();
            panel2 = new Panel();
            label9 = new Label();
            CBusqueda = new ComboBox();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            TBusqueda = new TextBox();
            dgvData = new DataGridView();
            nroDocumento = new DataGridViewTextBoxColumn();
            nombreCompleto = new DataGridViewTextBoxColumn();
            BAgregar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BCerrar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(210, 120, 61);
            panel1.Controls.Add(BCerrar);
            panel1.Controls.Add(titulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 34);
            panel1.TabIndex = 2;
            // 
            // BCerrar
            // 
            BCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrar.BackColor = Color.FromArgb(210, 120, 61);
            BCerrar.Cursor = Cursors.Hand;
            BCerrar.Image = Properties.Resources.cerrar;
            BCerrar.Location = new Point(508, 5);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(25, 25);
            BCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            BCerrar.TabIndex = 11;
            BCerrar.TabStop = false;
            BCerrar.Click += BCerrar_Click;
            // 
            // titulo
            // 
            titulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(164, 4);
            titulo.Name = "titulo";
            titulo.Size = new Size(217, 26);
            titulo.TabIndex = 9;
            titulo.Text = "Lista de clientes";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(CBusqueda);
            panel2.Controls.Add(BBusqueda);
            panel2.Controls.Add(BLimpiarBusqueda);
            panel2.Controls.Add(TBusqueda);
            panel2.Location = new Point(13, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 68);
            panel2.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(210, 120, 61);
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(28, 9);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 20;
            label9.Text = "Buscar por:";
            // 
            // CBusqueda
            // 
            CBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(29, 27);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(152, 23);
            CBusqueda.TabIndex = 21;
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
            BBusqueda.Location = new Point(395, 24);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(47, 29);
            BBusqueda.TabIndex = 23;
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
            BLimpiarBusqueda.Location = new Point(448, 24);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(47, 29);
            BLimpiarBusqueda.TabIndex = 24;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            // 
            // TBusqueda
            // 
            TBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TBusqueda.Location = new Point(187, 28);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(190, 23);
            TBusqueda.TabIndex = 22;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { nroDocumento, nombreCompleto });
            dgvData.Location = new Point(13, 115);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(518, 331);
            dgvData.TabIndex = 16;
            // 
            // nroDocumento
            // 
            nroDocumento.HeaderText = "Número de documento";
            nroDocumento.MinimumWidth = 6;
            nroDocumento.Name = "nroDocumento";
            nroDocumento.ReadOnly = true;
            nroDocumento.Width = 175;
            // 
            // nombreCompleto
            // 
            nombreCompleto.HeaderText = "Nombre completo";
            nombreCompleto.MinimumWidth = 6;
            nombreCompleto.Name = "nombreCompleto";
            nombreCompleto.ReadOnly = true;
            nombreCompleto.Width = 250;
            // 
            // BAgregar
            // 
            BAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BAgregar.BackColor = Color.SaddleBrown;
            BAgregar.Cursor = Cursors.Hand;
            BAgregar.FlatAppearance.BorderColor = Color.Black;
            BAgregar.FlatStyle = FlatStyle.Flat;
            BAgregar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregar.ForeColor = Color.White;
            BAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            BAgregar.IconColor = Color.White;
            BAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregar.IconSize = 30;
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(363, 450);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(168, 50);
            BAgregar.TabIndex = 17;
            BAgregar.Text = "Nuevo cliente";
            BAgregar.TextAlign = ContentAlignment.MiddleRight;
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            // 
            // mdBuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 506);
            Controls.Add(BAgregar);
            Controls.Add(dgvData);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mdBuscarCliente";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdBuscarCliente";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BCerrar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label titulo;
        private PictureBox BCerrar;
        private Panel panel2;
        private Label label9;
        private ComboBox CBusqueda;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private TextBox TBusqueda;
        private DataGridView dgvData;
        private FontAwesome.Sharp.IconButton BAgregar;
        private DataGridViewTextBoxColumn nroDocumento;
        private DataGridViewTextBoxColumn nombreCompleto;
    }
}