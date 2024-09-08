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
            CEstado = new ComboBox();
            label10 = new Label();
            TIdUsuario = new TextBox();
            BEliminar = new FontAwesome.Sharp.IconButton();
            BEditar = new FontAwesome.Sharp.IconButton();
            BGuardar = new FontAwesome.Sharp.IconButton();
            CRol = new ComboBox();
            label7 = new Label();
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
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
            panel1.Controls.Add(CEstado);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(TIdUsuario);
            panel1.Controls.Add(BEliminar);
            panel1.Controls.Add(BEditar);
            panel1.Controls.Add(BGuardar);
            panel1.Controls.Add(CRol);
            panel1.Controls.Add(label7);
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
            panel1.Size = new Size(321, 769);
            panel1.TabIndex = 0;
            // 
            // CEstado
            // 
            CEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CEstado.FormattingEnabled = true;
            CEstado.Location = new Point(34, 563);
            CEstado.Margin = new Padding(3, 4, 3, 4);
            CEstado.Name = "CEstado";
            CEstado.Size = new Size(253, 28);
            CEstado.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 539);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 14;
            label10.Text = "Estado:";
            // 
            // TIdUsuario
            // 
            TIdUsuario.Location = new Point(257, 16);
            TIdUsuario.Margin = new Padding(3, 4, 3, 4);
            TIdUsuario.Name = "TIdUsuario";
            TIdUsuario.Size = new Size(29, 27);
            TIdUsuario.TabIndex = 13;
            TIdUsuario.Text = "0";
            // 
            // BEliminar
            // 
            BEliminar.BackColor = Color.Firebrick;
            BEliminar.Cursor = Cursors.Hand;
            BEliminar.FlatAppearance.BorderColor = Color.Black;
            BEliminar.FlatStyle = FlatStyle.Flat;
            BEliminar.ForeColor = Color.White;
            BEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            BEliminar.IconColor = Color.White;
            BEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BEliminar.IconSize = 16;
            BEliminar.Location = new Point(33, 707);
            BEliminar.Margin = new Padding(3, 4, 3, 4);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(254, 33);
            BEliminar.TabIndex = 10;
            BEliminar.Text = "Eliminar";
            BEliminar.TextAlign = ContentAlignment.MiddleRight;
            BEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminar.UseVisualStyleBackColor = false;
            // 
            // BEditar
            // 
            BEditar.BackColor = Color.RoyalBlue;
            BEditar.Cursor = Cursors.Hand;
            BEditar.FlatAppearance.BorderColor = Color.Black;
            BEditar.FlatStyle = FlatStyle.Flat;
            BEditar.ForeColor = Color.White;
            BEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            BEditar.IconColor = Color.White;
            BEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BEditar.IconSize = 16;
            BEditar.Location = new Point(32, 666);
            BEditar.Margin = new Padding(3, 4, 3, 4);
            BEditar.Name = "BEditar";
            BEditar.Size = new Size(254, 33);
            BEditar.TabIndex = 9;
            BEditar.Text = "Editar";
            BEditar.TextAlign = ContentAlignment.MiddleRight;
            BEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEditar.UseVisualStyleBackColor = false;
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
            BGuardar.TabIndex = 8;
            BGuardar.Text = "Guardar";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 464);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 12;
            label7.Text = "Rol:";
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
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(344, 21);
            label8.Name = "label8";
            label8.Size = new Size(1155, 91);
            label8.TabIndex = 2;
            label8.Text = " Lista de usuarios:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(865, 63);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 5;
            label9.Text = "Buscar por:";
            // 
            // CBusqueda
            // 
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(947, 59);
            CBusqueda.Margin = new Padding(3, 4, 3, 4);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(157, 28);
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
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(1366, 53);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(54, 39);
            iconButton1.TabIndex = 10;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.White;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderColor = Color.Black;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(1426, 53);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(54, 39);
            iconButton2.TabIndex = 11;
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
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
            documento.Width = 150;
            // 
            // nombreCompleto
            // 
            nombreCompleto.HeaderText = "Nombre completo";
            nombreCompleto.MinimumWidth = 6;
            nombreCompleto.Name = "nombreCompleto";
            nombreCompleto.ReadOnly = true;
            nombreCompleto.Width = 180;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.ReadOnly = true;
            correo.Width = 150;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 125;
            // 
            // contraseña
            // 
            contraseña.HeaderText = "Contraseña";
            contraseña.MinimumWidth = 6;
            contraseña.Name = "contraseña";
            contraseña.ReadOnly = true;
            contraseña.Visible = false;
            contraseña.Width = 125;
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
            rol.Width = 125;
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
            ClientSize = new Size(1513, 769);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
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
        private Label label7;
        private ComboBox CRol;
        private FontAwesome.Sharp.IconButton BGuardar;
        private FontAwesome.Sharp.IconButton BEliminar;
        private FontAwesome.Sharp.IconButton BEditar;
        private DataGridView dgvData;
        private Label label8;
        private TextBox TIdUsuario;
        private Label label9;
        private ComboBox CBusqueda;
        private TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private ComboBox CEstado;
        private Label label10;
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