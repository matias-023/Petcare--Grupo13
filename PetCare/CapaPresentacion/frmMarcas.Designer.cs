namespace CapaPresentacion
{
    partial class frmMarcas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            BAgregar = new FontAwesome.Sharp.IconButton();
            dgvDataMarcas = new DataGridView();
            BSeleccionar = new DataGridViewButtonColumn();
            idCategoria = new DataGridViewTextBoxColumn();
            descripcionCategoria = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            estadoValorCategoria = new DataGridViewTextBoxColumn();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            CBusqueda = new ComboBox();
            TBusqueda = new TextBox();
            panel2 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDataMarcas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BAgregar
            // 
            BAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BAgregar.BackColor = Color.FromArgb(210, 120, 61);
            BAgregar.Cursor = Cursors.Hand;
            BAgregar.FlatAppearance.BorderColor = Color.Black;
            BAgregar.FlatStyle = FlatStyle.Flat;
            BAgregar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregar.ForeColor = Color.White;
            BAgregar.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            BAgregar.IconColor = Color.White;
            BAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregar.IconSize = 30;
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(863, 557);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(161, 50);
            BAgregar.TabIndex = 21;
            BAgregar.Text = "Agregar marca";
            BAgregar.TextAlign = ContentAlignment.MiddleRight;
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // dgvDataMarcas
            // 
            dgvDataMarcas.AllowUserToAddRows = false;
            dgvDataMarcas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDataMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDataMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataMarcas.Columns.AddRange(new DataGridViewColumn[] { BSeleccionar, idCategoria, descripcionCategoria, estado, estadoValorCategoria });
            dgvDataMarcas.Location = new Point(24, 107);
            dgvDataMarcas.MultiSelect = false;
            dgvDataMarcas.Name = "dgvDataMarcas";
            dgvDataMarcas.ReadOnly = true;
            dgvDataMarcas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvDataMarcas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDataMarcas.RowTemplate.Height = 28;
            dgvDataMarcas.Size = new Size(1001, 435);
            dgvDataMarcas.TabIndex = 19;
            // 
            // BSeleccionar
            // 
            BSeleccionar.HeaderText = "";
            BSeleccionar.MinimumWidth = 6;
            BSeleccionar.Name = "BSeleccionar";
            BSeleccionar.ReadOnly = true;
            BSeleccionar.Width = 35;
            // 
            // idCategoria
            // 
            idCategoria.HeaderText = "ID";
            idCategoria.MinimumWidth = 6;
            idCategoria.Name = "idCategoria";
            idCategoria.ReadOnly = true;
            idCategoria.Visible = false;
            idCategoria.Width = 150;
            // 
            // descripcionCategoria
            // 
            descripcionCategoria.HeaderText = "Descripción";
            descripcionCategoria.MinimumWidth = 6;
            descripcionCategoria.Name = "descripcionCategoria";
            descripcionCategoria.ReadOnly = true;
            descripcionCategoria.Width = 617;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 325;
            // 
            // estadoValorCategoria
            // 
            estadoValorCategoria.HeaderText = "Column1";
            estadoValorCategoria.MinimumWidth = 6;
            estadoValorCategoria.Name = "estadoValorCategoria";
            estadoValorCategoria.ReadOnly = true;
            estadoValorCategoria.Visible = false;
            estadoValorCategoria.Width = 125;
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
            BLimpiarBusqueda.Location = new Point(913, 24);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(47, 29);
            BLimpiarBusqueda.TabIndex = 26;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(210, 120, 61);
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(386, 31);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 22;
            label1.Text = "Buscar por:";
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
            BBusqueda.Location = new Point(860, 24);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(47, 29);
            BBusqueda.TabIndex = 25;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
            // 
            // CBusqueda
            // 
            CBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(458, 27);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(174, 23);
            CBusqueda.TabIndex = 23;
            // 
            // TBusqueda
            // 
            TBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TBusqueda.Location = new Point(638, 27);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(216, 23);
            TBusqueda.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(BLimpiarBusqueda);
            panel2.Controls.Add(BBusqueda);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(CBusqueda);
            panel2.Controls.Add(TBusqueda);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(23, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 68);
            panel2.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 22);
            label7.Name = "label7";
            label7.Size = new Size(186, 25);
            label7.TabIndex = 0;
            label7.Text = "Lista de marcas:";
            // 
            // frmMarcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 636);
            Controls.Add(panel2);
            Controls.Add(BAgregar);
            Controls.Add(dgvDataMarcas);
            Name = "frmMarcas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMarcas";
            ((System.ComponentModel.ISupportInitialize)dgvDataMarcas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton BAgregar;
        private DataGridView dgvDataMarcas;
        private DataGridViewButtonColumn BSeleccionar;
        private DataGridViewTextBoxColumn idCategoria;
        private DataGridViewTextBoxColumn descripcionCategoria;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn estadoValorCategoria;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private Label label1;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private ComboBox CBusqueda;
        private TextBox TBusqueda;
        private Panel panel2;
        private Label label7;
    }
}