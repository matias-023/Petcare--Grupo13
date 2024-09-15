namespace CapaPresentacion
{
    partial class frmUsuario
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
            TIndice = new TextBox();
            CEstado = new ComboBox();
            LEstado = new Label();
            TIdUsuario = new TextBox();
            BLimpiar = new FontAwesome.Sharp.IconButton();
            BGuardar = new FontAwesome.Sharp.IconButton();
            CRol = new ComboBox();
            LRol = new Label();
            TConfirmarContraseña = new TextBox();
            label6 = new Label();
            TContraseña = new TextBox();
            label5 = new Label();
            TTelefono = new TextBox();
            label4 = new Label();
            TCorreo = new TextBox();
            label3 = new Label();
            TNombreCompleto = new TextBox();
            label2 = new Label();
            TDocumento = new TextBox();
            label1 = new Label();
            dgvData = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            CBusqueda = new ComboBox();
            TBusqueda = new TextBox();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            BSeleccionar = new DataGridViewButtonColumn();
            idUsuario = new DataGridViewTextBoxColumn();
            documento = new DataGridViewTextBoxColumn();
            nombreCompleto = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            contraseña = new DataGridViewTextBoxColumn();
            idRol = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            estadoValor = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(TIndice);
            panel1.Controls.Add(CEstado);
            panel1.Controls.Add(LEstado);
            panel1.Controls.Add(TIdUsuario);
            panel1.Controls.Add(BLimpiar);
            panel1.Controls.Add(BGuardar);
            panel1.Controls.Add(CRol);
            panel1.Controls.Add(LRol);
            panel1.Controls.Add(TConfirmarContraseña);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TContraseña);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TCorreo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TNombreCompleto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TDocumento);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 763);
            panel1.TabIndex = 0;
            // 
            // TIndice
            // 
            TIndice.Location = new Point(221, 16);
            TIndice.Margin = new Padding(3, 4, 3, 4);
            TIndice.Name = "TIndice";
            TIndice.Size = new Size(29, 27);
            TIndice.TabIndex = 16;
            TIndice.Text = "-1";
            TIndice.Visible = false;
            // 
            // CEstado
            // 
            CEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CEstado.FormattingEnabled = true;
            CEstado.Location = new Point(34, 563);
            CEstado.Margin = new Padding(3, 4, 3, 4);
            CEstado.Name = "CEstado";
            CEstado.Size = new Size(253, 28);
            CEstado.TabIndex = 8;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Location = new Point(33, 539);
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(57, 20);
            LEstado.TabIndex = 14;
            LEstado.Text = "Estado:";
            // 
            // TIdUsuario
            // 
            TIdUsuario.Location = new Point(257, 16);
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
            BLimpiar.Location = new Point(32, 667);
            BLimpiar.Margin = new Padding(3, 4, 3, 4);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(254, 33);
            BLimpiar.TabIndex = 10;
            BLimpiar.Text = "Limpiar";
            BLimpiar.TextAlign = ContentAlignment.MiddleRight;
            BLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiar.UseVisualStyleBackColor = false;
            BLimpiar.Click += BLimpiar_Click;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.ForestGreen;
            BGuardar.Cursor = Cursors.Hand;
            BGuardar.FlatAppearance.BorderColor = Color.Black;
            BGuardar.FlatStyle = FlatStyle.Flat;
            BGuardar.ForeColor = Color.White;
            BGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BGuardar.IconColor = Color.White;
            BGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BGuardar.IconSize = 16;
            BGuardar.Location = new Point(32, 625);
            BGuardar.Margin = new Padding(3, 4, 3, 4);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(254, 33);
            BGuardar.TabIndex = 9;
            BGuardar.Text = "Crear usuario";
            BGuardar.TextAlign = ContentAlignment.MiddleRight;
            BGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // CRol
            // 
            CRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CRol.FormattingEnabled = true;
            CRol.Location = new Point(33, 488);
            CRol.Margin = new Padding(3, 4, 3, 4);
            CRol.Name = "CRol";
            CRol.Size = new Size(253, 28);
            CRol.TabIndex = 7;
            // 
            // LRol
            // 
            LRol.AutoSize = true;
            LRol.Location = new Point(33, 464);
            LRol.Name = "LRol";
            LRol.Size = new Size(34, 20);
            LRol.TabIndex = 12;
            LRol.Text = "Rol:";
            // 
            // TConfirmarContraseña
            // 
            TConfirmarContraseña.Location = new Point(33, 417);
            TConfirmarContraseña.Margin = new Padding(3, 4, 3, 4);
            TConfirmarContraseña.Name = "TConfirmarContraseña";
            TConfirmarContraseña.PasswordChar = '*';
            TConfirmarContraseña.Size = new Size(253, 27);
            TConfirmarContraseña.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 393);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 10;
            label6.Text = "Confirmar contraseña:";
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(33, 347);
            TContraseña.Margin = new Padding(3, 4, 3, 4);
            TContraseña.Name = "TContraseña";
            TContraseña.PasswordChar = '*';
            TContraseña.Size = new Size(253, 27);
            TContraseña.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 323);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 8;
            label5.Text = "Contraseña:";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(33, 276);
            TTelefono.Margin = new Padding(3, 4, 3, 4);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(253, 27);
            TTelefono.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 252);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Teléfono:";
            // 
            // TCorreo
            // 
            TCorreo.Location = new Point(33, 205);
            TCorreo.Margin = new Padding(3, 4, 3, 4);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(253, 27);
            TCorreo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 181);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 4;
            label3.Text = "Correo electrónico:";
            // 
            // TNombreCompleto
            // 
            TNombreCompleto.Location = new Point(33, 135);
            TNombreCompleto.Margin = new Padding(3, 4, 3, 4);
            TNombreCompleto.Name = "TNombreCompleto";
            TNombreCompleto.Size = new Size(253, 27);
            TNombreCompleto.TabIndex = 2;
            TNombreCompleto.TextChanged += TNombreCompleto_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 111);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre completo:";
            // 
            // TDocumento
            // 
            TDocumento.Location = new Point(33, 64);
            TDocumento.Margin = new Padding(3, 4, 3, 4);
            TDocumento.Name = "TDocumento";
            TDocumento.Size = new Size(253, 27);
            TDocumento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 0;
            label1.Text = "Número de documento:";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { BSeleccionar, idUsuario, documento, nombreCompleto, correo, telefono, contraseña, idRol, rol, estadoValor, estado });
            dgvData.Location = new Point(344, 135);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(1155, 605);
            dgvData.TabIndex = 1;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellPainting += dgvData_CellPainting;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(344, 21);
            label8.Name = "label8";
            label8.Size = new Size(1155, 90);
            label8.TabIndex = 2;
            label8.Text = " Lista de usuarios:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(824, 63);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 5;
            label9.Text = "Buscar por:";
            // 
            // CBusqueda
            // 
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(906, 59);
            CBusqueda.Margin = new Padding(3, 4, 3, 4);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(198, 28);
            CBusqueda.TabIndex = 8;
            // 
            // TBusqueda
            // 
            TBusqueda.Location = new Point(1112, 59);
            TBusqueda.Margin = new Padding(3, 4, 3, 4);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(246, 27);
            TBusqueda.TabIndex = 9;
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
            BBusqueda.Location = new Point(1366, 53);
            BBusqueda.Margin = new Padding(3, 4, 3, 4);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(54, 39);
            BBusqueda.TabIndex = 10;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
            BBusqueda.Click += BBusqueda_Click;
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
            BLimpiarBusqueda.Location = new Point(1426, 53);
            BLimpiarBusqueda.Margin = new Padding(3, 4, 3, 4);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(54, 39);
            BLimpiarBusqueda.TabIndex = 11;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            BLimpiarBusqueda.Click += BLimpiarBusqueda_Click;
            // 
            // BSeleccionar
            // 
            BSeleccionar.HeaderText = "";
            BSeleccionar.MinimumWidth = 6;
            BSeleccionar.Name = "BSeleccionar";
            BSeleccionar.ReadOnly = true;
            BSeleccionar.Width = 35;
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
            // contraseña
            // 
            contraseña.HeaderText = "Contraseña";
            contraseña.MinimumWidth = 6;
            contraseña.Name = "contraseña";
            contraseña.ReadOnly = true;
            contraseña.Visible = false;
            contraseña.Width = 150;
            // 
            // idRol
            // 
            idRol.HeaderText = "idRol";
            idRol.MinimumWidth = 6;
            idRol.Name = "idRol";
            idRol.ReadOnly = true;
            idRol.Visible = false;
            idRol.Width = 125;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.MinimumWidth = 6;
            rol.Name = "rol";
            rol.ReadOnly = true;
            rol.Width = 150;
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
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1562, 763);
            Controls.Add(BLimpiarBusqueda);
            Controls.Add(BBusqueda);
            Controls.Add(TBusqueda);
            Controls.Add(CBusqueda);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dgvData);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUsuario";
            Text = "frmUsuario";
            Load += frmUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox TDocumento;
        private Label label1;
        private TextBox TConfirmarContraseña;
        private Label label6;
        private TextBox TContraseña;
        private Label label5;
        private TextBox TTelefono;
        private Label label4;
        private TextBox TCorreo;
        private Label label3;
        private TextBox TNombreCompleto;
        private Label LRol;
        private ComboBox CRol;
        private FontAwesome.Sharp.IconButton BGuardar;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private DataGridView dgvData;
        private Label label8;
        private TextBox TIdUsuario;
        private Label label9;
        private ComboBox CBusqueda;
        private TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private ComboBox CEstado;
        private Label LEstado;
        private TextBox TIndice;
        private DataGridViewButtonColumn BSeleccionar;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn nombreCompleto;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn contraseña;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn estadoValor;
        private DataGridViewTextBoxColumn estado;
    }
}