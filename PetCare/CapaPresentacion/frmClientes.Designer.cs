namespace CapaPresentacion
{
    partial class frmClientes
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
            label9 = new Label();
            label7 = new Label();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            CBusqueda = new ComboBox();
            TBusqueda = new TextBox();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            dgvDataClientes = new DataGridView();
            BSeleccionar = new DataGridViewButtonColumn();
            idCliente = new DataGridViewTextBoxColumn();
            documento = new DataGridViewTextBoxColumn();
            nombreCompleto = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            estadoValor = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            BAgregar = new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataClientes).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(BLimpiarBusqueda);
            panel2.Controls.Add(CBusqueda);
            panel2.Controls.Add(TBusqueda);
            panel2.Controls.Add(BBusqueda);
            panel2.Location = new Point(23, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 68);
            panel2.TabIndex = 14;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(210, 120, 61);
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(397, 30);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 15;
            label9.Text = "Buscar por:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 22);
            label7.Name = "label7";
            label7.Size = new Size(192, 25);
            label7.TabIndex = 0;
            label7.Text = "Lista de clientes:";
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
            BLimpiarBusqueda.TabIndex = 19;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            // 
            // CBusqueda
            // 
            CBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(469, 26);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(174, 23);
            CBusqueda.TabIndex = 16;
            // 
            // TBusqueda
            // 
            TBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TBusqueda.Location = new Point(649, 26);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(216, 23);
            TBusqueda.TabIndex = 17;
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
            BBusqueda.TabIndex = 18;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
            // 
            // dgvDataClientes
            // 
            dgvDataClientes.AllowUserToAddRows = false;
            dgvDataClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDataClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDataClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataClientes.Columns.AddRange(new DataGridViewColumn[] { BSeleccionar, idCliente, documento, nombreCompleto, correo, telefono, estadoValor, estado });
            dgvDataClientes.Location = new Point(23, 107);
            dgvDataClientes.MultiSelect = false;
            dgvDataClientes.Name = "dgvDataClientes";
            dgvDataClientes.ReadOnly = true;
            dgvDataClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvDataClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDataClientes.RowTemplate.Height = 28;
            dgvDataClientes.Size = new Size(1001, 454);
            dgvDataClientes.TabIndex = 15;
            // 
            // BSeleccionar
            // 
            BSeleccionar.HeaderText = "";
            BSeleccionar.MinimumWidth = 6;
            BSeleccionar.Name = "BSeleccionar";
            BSeleccionar.ReadOnly = true;
            BSeleccionar.Width = 35;
            // 
            // idCliente
            // 
            idCliente.HeaderText = "ID";
            idCliente.MinimumWidth = 6;
            idCliente.Name = "idCliente";
            idCliente.ReadOnly = true;
            idCliente.Visible = false;
            idCliente.Width = 125;
            // 
            // documento
            // 
            documento.HeaderText = "Número de documento";
            documento.MinimumWidth = 6;
            documento.Name = "documento";
            documento.ReadOnly = true;
            documento.Width = 200;
            // 
            // nombreCompleto
            // 
            nombreCompleto.HeaderText = "Nombre completo";
            nombreCompleto.MinimumWidth = 6;
            nombreCompleto.Name = "nombreCompleto";
            nombreCompleto.ReadOnly = true;
            nombreCompleto.Width = 200;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.ReadOnly = true;
            correo.Width = 250;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 150;
            // 
            // estadoValor
            // 
            estadoValor.HeaderText = "estadoValor";
            estadoValor.MinimumWidth = 6;
            estadoValor.Name = "estadoValor";
            estadoValor.ReadOnly = true;
            estadoValor.Visible = false;
            estadoValor.Width = 125;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 125;
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
            BAgregar.Location = new Point(856, 574);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(168, 50);
            BAgregar.TabIndex = 16;
            BAgregar.Text = "Agregar cliente";
            BAgregar.TextAlign = ContentAlignment.MiddleRight;
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 636);
            Controls.Add(BAgregar);
            Controls.Add(dgvDataClientes);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClientes";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label7;
        private Label label9;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private ComboBox CBusqueda;
        private TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private DataGridView dgvDataClientes;
        private DataGridViewButtonColumn BSeleccionar;
        private DataGridViewTextBoxColumn idCliente;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn nombreCompleto;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn estadoValor;
        private DataGridViewTextBoxColumn estado;
        private FontAwesome.Sharp.IconButton BAgregar;
    }
}