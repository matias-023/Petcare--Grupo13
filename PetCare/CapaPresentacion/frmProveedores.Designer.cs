namespace CapaPresentacion
{
    partial class frmProveedores
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
            dgvDataProveedores = new DataGridView();
            BSeleccionar = new DataGridViewButtonColumn();
            idUsuario = new DataGridViewTextBoxColumn();
            documento = new DataGridViewTextBoxColumn();
            razonSocial = new DataGridViewTextBoxColumn();
            correoProveedor = new DataGridViewTextBoxColumn();
            telefonoProveedor = new DataGridViewTextBoxColumn();
            estadoValorProveedor = new DataGridViewTextBoxColumn();
            estadoProveedor = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label9 = new Label();
            label7 = new Label();
            CBusqueda = new ComboBox();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            TBusqueda = new TextBox();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            BAgregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvDataProveedores).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDataProveedores
            // 
            dgvDataProveedores.AllowUserToAddRows = false;
            dgvDataProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDataProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDataProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataProveedores.Columns.AddRange(new DataGridViewColumn[] { BSeleccionar, idUsuario, documento, razonSocial, correoProveedor, telefonoProveedor, estadoValorProveedor, estadoProveedor });
            dgvDataProveedores.Location = new Point(23, 107);
            dgvDataProveedores.MultiSelect = false;
            dgvDataProveedores.Name = "dgvDataProveedores";
            dgvDataProveedores.ReadOnly = true;
            dgvDataProveedores.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvDataProveedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDataProveedores.RowTemplate.Height = 28;
            dgvDataProveedores.Size = new Size(1001, 454);
            dgvDataProveedores.TabIndex = 13;
            // 
            // BSeleccionar
            // 
            BSeleccionar.HeaderText = "";
            BSeleccionar.MinimumWidth = 6;
            BSeleccionar.Name = "BSeleccionar";
            BSeleccionar.ReadOnly = true;
            BSeleccionar.Width = 30;
            // 
            // idUsuario
            // 
            idUsuario.HeaderText = "ID";
            idUsuario.MinimumWidth = 6;
            idUsuario.Name = "idUsuario";
            idUsuario.ReadOnly = true;
            idUsuario.Visible = false;
            idUsuario.Width = 125;
            // 
            // documento
            // 
            documento.HeaderText = "Número de documento";
            documento.MinimumWidth = 6;
            documento.Name = "documento";
            documento.ReadOnly = true;
            documento.Width = 240;
            // 
            // razonSocial
            // 
            razonSocial.HeaderText = "Razón Social";
            razonSocial.MinimumWidth = 6;
            razonSocial.Name = "razonSocial";
            razonSocial.ReadOnly = true;
            razonSocial.Width = 250;
            // 
            // correoProveedor
            // 
            correoProveedor.HeaderText = "Correo";
            correoProveedor.MinimumWidth = 6;
            correoProveedor.Name = "correoProveedor";
            correoProveedor.ReadOnly = true;
            correoProveedor.Width = 250;
            // 
            // telefonoProveedor
            // 
            telefonoProveedor.HeaderText = "Teléfono";
            telefonoProveedor.MinimumWidth = 6;
            telefonoProveedor.Name = "telefonoProveedor";
            telefonoProveedor.ReadOnly = true;
            telefonoProveedor.Width = 175;
            // 
            // estadoValorProveedor
            // 
            estadoValorProveedor.HeaderText = "estadoValor";
            estadoValorProveedor.MinimumWidth = 6;
            estadoValorProveedor.Name = "estadoValorProveedor";
            estadoValorProveedor.ReadOnly = true;
            estadoValorProveedor.Visible = false;
            estadoValorProveedor.Width = 125;
            // 
            // estadoProveedor
            // 
            estadoProveedor.HeaderText = "Estado";
            estadoProveedor.MinimumWidth = 6;
            estadoProveedor.Name = "estadoProveedor";
            estadoProveedor.ReadOnly = true;
            estadoProveedor.Width = 157;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(CBusqueda);
            panel2.Controls.Add(BLimpiarBusqueda);
            panel2.Controls.Add(TBusqueda);
            panel2.Controls.Add(BBusqueda);
            panel2.Location = new Point(23, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 68);
            panel2.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(210, 120, 61);
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(397, 31);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 20;
            label9.Text = "Buscar por:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 22);
            label7.Name = "label7";
            label7.Size = new Size(241, 25);
            label7.TabIndex = 0;
            label7.Text = "Lista de proveedores:";
            // 
            // CBusqueda
            // 
            CBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(469, 27);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(174, 23);
            CBusqueda.TabIndex = 21;
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
            BLimpiarBusqueda.Location = new Point(924, 23);
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
            TBusqueda.Location = new Point(649, 27);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(216, 23);
            TBusqueda.TabIndex = 22;
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
            BBusqueda.Location = new Point(871, 23);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(47, 29);
            BBusqueda.TabIndex = 23;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
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
            BAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            BAgregar.IconColor = Color.White;
            BAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregar.IconSize = 30;
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(817, 574);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(207, 50);
            BAgregar.TabIndex = 17;
            BAgregar.Text = "Agregar proveedor";
            BAgregar.TextAlign = ContentAlignment.MiddleRight;
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 636);
            Controls.Add(BAgregar);
            Controls.Add(panel2);
            Controls.Add(dgvDataProveedores);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProveedores";
            Text = "frmProveedores";
            ((System.ComponentModel.ISupportInitialize)dgvDataProveedores).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvDataProveedores;
        private DataGridViewButtonColumn BSeleccionar;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn razonSocial;
        private DataGridViewTextBoxColumn correoProveedor;
        private DataGridViewTextBoxColumn telefonoProveedor;
        private DataGridViewTextBoxColumn estadoValorProveedor;
        private DataGridViewTextBoxColumn estadoProveedor;
        private Panel panel2;
        private Label label7;
        private Label label9;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private ComboBox CBusqueda;
        private TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private FontAwesome.Sharp.IconButton BAgregar;
    }
}