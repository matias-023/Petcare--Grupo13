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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label8 = new Label();
            TBusqueda = new TextBox();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            CEstadoCat = new ComboBox();
            LEstado = new Label();
            TIndice = new TextBox();
            TIdUsuario = new TextBox();
            BLimpiar = new FontAwesome.Sharp.IconButton();
            BGuardarCat = new FontAwesome.Sharp.IconButton();
            TDescripcionCategoria = new TextBox();
            LDescripcionCategoria = new Label();
            dgvDataCat = new DataGridView();
            BSeleccionar = new DataGridViewButtonColumn();
            idCategoria = new DataGridViewTextBoxColumn();
            descripcionCategoria = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            estadoValorCategoria = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataCat).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(416, 54);
            label8.Name = "label8";
            label8.Size = new Size(1031, 98);
            label8.TabIndex = 3;
            label8.Text = "Lista de Categorias:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TBusqueda
            // 
            TBusqueda.Location = new Point(1061, 92);
            TBusqueda.Margin = new Padding(3, 4, 3, 4);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(246, 27);
            TBusqueda.TabIndex = 11;
            // 
            // BBusqueda
            // 
            BBusqueda.BackColor = Color.White;
            BBusqueda.Cursor = Cursors.Hand;
            BBusqueda.FlatAppearance.BorderColor = Color.Black;
            BBusqueda.FlatStyle = FlatStyle.Flat;
            BBusqueda.ForeColor = Color.White;
            BBusqueda.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBusqueda.IconColor = Color.Black;
            BBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBusqueda.IconSize = 20;
            BBusqueda.Location = new Point(1313, 84);
            BBusqueda.Margin = new Padding(3, 4, 3, 4);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(54, 39);
            BBusqueda.TabIndex = 12;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
            // 
            // BLimpiarBusqueda
            // 
            BLimpiarBusqueda.BackColor = Color.White;
            BLimpiarBusqueda.Cursor = Cursors.Hand;
            BLimpiarBusqueda.FlatAppearance.BorderColor = Color.Black;
            BLimpiarBusqueda.FlatStyle = FlatStyle.Flat;
            BLimpiarBusqueda.ForeColor = Color.White;
            BLimpiarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Broom;
            BLimpiarBusqueda.IconColor = Color.Black;
            BLimpiarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BLimpiarBusqueda.IconSize = 20;
            BLimpiarBusqueda.Location = new Point(1373, 84);
            BLimpiarBusqueda.Margin = new Padding(3, 4, 3, 4);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(54, 39);
            BLimpiarBusqueda.TabIndex = 13;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(CEstadoCat);
            panel1.Controls.Add(LEstado);
            panel1.Controls.Add(TIndice);
            panel1.Controls.Add(TIdUsuario);
            panel1.Controls.Add(BLimpiar);
            panel1.Controls.Add(BGuardarCat);
            panel1.Controls.Add(TDescripcionCategoria);
            panel1.Controls.Add(LDescripcionCategoria);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 679);
            panel1.TabIndex = 15;
            // 
            // CEstadoCat
            // 
            CEstadoCat.DropDownStyle = ComboBoxStyle.DropDownList;
            CEstadoCat.FormattingEnabled = true;
            CEstadoCat.Location = new Point(34, 206);
            CEstadoCat.Margin = new Padding(3, 4, 3, 4);
            CEstadoCat.Name = "CEstadoCat";
            CEstadoCat.Size = new Size(253, 28);
            CEstadoCat.TabIndex = 18;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Location = new Point(34, 173);
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(57, 20);
            LEstado.TabIndex = 17;
            LEstado.Text = "Estado:";
            // 
            // TIndice
            // 
            TIndice.Location = new Point(222, 54);
            TIndice.Margin = new Padding(3, 4, 3, 4);
            TIndice.Name = "TIndice";
            TIndice.Size = new Size(29, 27);
            TIndice.TabIndex = 16;
            TIndice.Text = "-1";
            TIndice.Visible = false;
            // 
            // TIdUsuario
            // 
            TIdUsuario.Location = new Point(257, 54);
            TIdUsuario.Margin = new Padding(3, 4, 3, 4);
            TIdUsuario.Name = "TIdUsuario";
            TIdUsuario.Size = new Size(29, 27);
            TIdUsuario.TabIndex = 13;
            TIdUsuario.Text = "0";
            TIdUsuario.Visible = false;
            // 
            // BLimpiar
            // 
            BLimpiar.BackColor = Color.RoyalBlue;
            BLimpiar.Cursor = Cursors.Hand;
            BLimpiar.FlatAppearance.BorderColor = Color.Black;
            BLimpiar.FlatStyle = FlatStyle.Flat;
            BLimpiar.ForeColor = Color.White;
            BLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            BLimpiar.IconColor = Color.White;
            BLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BLimpiar.IconSize = 16;
            BLimpiar.Location = new Point(32, 325);
            BLimpiar.Margin = new Padding(3, 4, 3, 4);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(254, 33);
            BLimpiar.TabIndex = 10;
            BLimpiar.Text = "Limpiar";
            BLimpiar.TextAlign = ContentAlignment.MiddleRight;
            BLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiar.UseVisualStyleBackColor = false;
            // 
            // BGuardarCat
            // 
            BGuardarCat.BackColor = Color.ForestGreen;
            BGuardarCat.Cursor = Cursors.Hand;
            BGuardarCat.FlatAppearance.BorderColor = Color.Black;
            BGuardarCat.FlatStyle = FlatStyle.Flat;
            BGuardarCat.ForeColor = Color.White;
            BGuardarCat.IconChar = FontAwesome.Sharp.IconChar.Save;
            BGuardarCat.IconColor = Color.White;
            BGuardarCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BGuardarCat.IconSize = 16;
            BGuardarCat.Location = new Point(32, 284);
            BGuardarCat.Margin = new Padding(3, 4, 3, 4);
            BGuardarCat.Name = "BGuardarCat";
            BGuardarCat.Size = new Size(254, 33);
            BGuardarCat.TabIndex = 9;
            BGuardarCat.Text = "Añadir Categoria";
            BGuardarCat.TextAlign = ContentAlignment.MiddleRight;
            BGuardarCat.TextImageRelation = TextImageRelation.ImageBeforeText;
            BGuardarCat.UseVisualStyleBackColor = false;
            // 
            // TDescripcionCategoria
            // 
            TDescripcionCategoria.Location = new Point(34, 125);
            TDescripcionCategoria.Margin = new Padding(3, 4, 3, 4);
            TDescripcionCategoria.Name = "TDescripcionCategoria";
            TDescripcionCategoria.Size = new Size(253, 27);
            TDescripcionCategoria.TabIndex = 1;
            // 
            // LDescripcionCategoria
            // 
            LDescripcionCategoria.AutoSize = true;
            LDescripcionCategoria.Location = new Point(33, 90);
            LDescripcionCategoria.Name = "LDescripcionCategoria";
            LDescripcionCategoria.Size = new Size(90, 20);
            LDescripcionCategoria.TabIndex = 0;
            LDescripcionCategoria.Text = "Descripción:";
            // 
            // dgvDataCat
            // 
            dgvDataCat.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDataCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDataCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataCat.Columns.AddRange(new DataGridViewColumn[] { BSeleccionar, idCategoria, descripcionCategoria, estado, estadoValorCategoria });
            dgvDataCat.Location = new Point(416, 173);
            dgvDataCat.Margin = new Padding(3, 4, 3, 4);
            dgvDataCat.MultiSelect = false;
            dgvDataCat.Name = "dgvDataCat";
            dgvDataCat.ReadOnly = true;
            dgvDataCat.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvDataCat.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDataCat.RowTemplate.Height = 28;
            dgvDataCat.Size = new Size(1031, 303);
            dgvDataCat.TabIndex = 16;
            dgvDataCat.CellContentClick += dgvData_CellContentClick;
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
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1543, 679);
            Controls.Add(dgvDataCat);
            Controls.Add(panel1);
            Controls.Add(BLimpiarBusqueda);
            Controls.Add(BBusqueda);
            Controls.Add(TBusqueda);
            Controls.Add(label8);
            Name = "frmCategorias";
            Text = "frmCategorias";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private Panel panel1;
        private TextBox TIndice;
        private TextBox TIdUsuario;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private FontAwesome.Sharp.IconButton BGuardarCat;
        private TextBox TDescripcionCategoria;
        private Label LDescripcionCategoria;
        private Label LEstado;
        private ComboBox CEstadoCat;
        private DataGridView dgvDataCat;
        private DataGridViewButtonColumn BSeleccionar;
        private DataGridViewTextBoxColumn idCategoria;
        private DataGridViewTextBoxColumn descripcionCategoria;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn estadoValorCategoria;
    }
}