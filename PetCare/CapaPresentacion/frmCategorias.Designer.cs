namespace CapaPresentacion
{
    partial class frmCategorias
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
            CBusqueda = new ComboBox();
            TBusqueda = new TextBox();
            label1 = new Label();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            dgvDataCat = new DataGridView();
            BSeleccionar = new DataGridViewButtonColumn();
            idCategoria = new DataGridViewTextBoxColumn();
            descripcionCategoria = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            estadoValorCategoria = new DataGridViewTextBoxColumn();
            BAgregar = new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataCat).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(CBusqueda);
            panel2.Controls.Add(TBusqueda);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(BLimpiarBusqueda);
            panel2.Controls.Add(BBusqueda);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(23, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 68);
            panel2.TabIndex = 17;
            // 
            // CBusqueda
            // 
            CBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(458, 27);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(174, 23);
            CBusqueda.TabIndex = 24;
            // 
            // TBusqueda
            // 
            TBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TBusqueda.Location = new Point(638, 27);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(216, 23);
            TBusqueda.TabIndex = 25;
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
            label1.TabIndex = 12;
            label1.Text = "Buscar por:";
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
            BLimpiarBusqueda.TabIndex = 16;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
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
            BBusqueda.TabIndex = 15;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 22);
            label7.Name = "label7";
            label7.Size = new Size(220, 25);
            label7.TabIndex = 0;
            label7.Text = "Lista de categorias:";
            // 
            // dgvDataCat
            // 
            dgvDataCat.AllowUserToAddRows = false;
            dgvDataCat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDataCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDataCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataCat.Columns.AddRange(new DataGridViewColumn[] { BSeleccionar, idCategoria, descripcionCategoria, estado, estadoValorCategoria });
            dgvDataCat.Location = new Point(23, 107);
            dgvDataCat.MultiSelect = false;
            dgvDataCat.Name = "dgvDataCat";
            dgvDataCat.ReadOnly = true;
            dgvDataCat.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvDataCat.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDataCat.RowTemplate.Height = 28;
            dgvDataCat.Size = new Size(1001, 435);
            dgvDataCat.TabIndex = 16;
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
            descripcionCategoria.Width = 820;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 500;
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
            BAgregar.Location = new Point(836, 558);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(188, 50);
            BAgregar.TabIndex = 18;
            BAgregar.Text = "Agregar categoria";
            BAgregar.TextAlign = ContentAlignment.MiddleRight;
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 636);
            Controls.Add(BAgregar);
            Controls.Add(panel2);
            Controls.Add(dgvDataCat);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCategorias";
            Text = "frmCategorias";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataCat).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvDataCat;
        private Panel panel2;
        private Label label7;
        private ComboBox CBusqueda;
        private FontAwesome.Sharp.IconButton BAgregar;
        private Label label1;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private TextBox TBusqueda;
        private DataGridViewButtonColumn BSeleccionar;
        private DataGridViewTextBoxColumn idCategoria;
        private DataGridViewTextBoxColumn descripcionCategoria;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn estadoValorCategoria;
    }
}