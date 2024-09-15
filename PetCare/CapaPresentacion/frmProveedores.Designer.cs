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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            TIndice = new TextBox();
            CEstado = new ComboBox();
            LEstado = new Label();
            TIdUsuario = new TextBox();
            BLimpiar = new FontAwesome.Sharp.IconButton();
            BGuardar = new FontAwesome.Sharp.IconButton();
            TTelefonoProveedor = new TextBox();
            label4 = new Label();
            TCorreoProveedor = new TextBox();
            label3 = new Label();
            TRazonSocialProveedor = new TextBox();
            LRazonSocialPro = new Label();
            TDocumentoProveedor = new TextBox();
            LDocumentoProveedor = new Label();
            label8 = new Label();
            TBusqueda = new TextBox();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            dgvData = new DataGridView();
            BSeleccionar = new DataGridViewButtonColumn();
            idUsuario = new DataGridViewTextBoxColumn();
            documento = new DataGridViewTextBoxColumn();
            razonSocial = new DataGridViewTextBoxColumn();
            correoProveedor = new DataGridViewTextBoxColumn();
            telefonoProveedor = new DataGridViewTextBoxColumn();
            estadoValorProveedor = new DataGridViewTextBoxColumn();
            estadoProveedor = new DataGridViewTextBoxColumn();
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
            panel1.Controls.Add(TTelefonoProveedor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TCorreoProveedor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TRazonSocialProveedor);
            panel1.Controls.Add(LRazonSocialPro);
            panel1.Controls.Add(TDocumentoProveedor);
            panel1.Controls.Add(LDocumentoProveedor);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 677);
            panel1.TabIndex = 1;
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
            CEstado.Location = new Point(34, 352);
            CEstado.Margin = new Padding(3, 4, 3, 4);
            CEstado.Name = "CEstado";
            CEstado.Size = new Size(253, 28);
            CEstado.TabIndex = 8;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Location = new Point(33, 328);
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
            BLimpiar.Location = new Point(34, 498);
            BLimpiar.Margin = new Padding(3, 4, 3, 4);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(254, 33);
            BLimpiar.TabIndex = 10;
            BLimpiar.Text = "Limpiar";
            BLimpiar.TextAlign = ContentAlignment.MiddleRight;
            BLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiar.UseVisualStyleBackColor = false;
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
            BGuardar.Location = new Point(34, 448);
            BGuardar.Margin = new Padding(3, 4, 3, 4);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(254, 33);
            BGuardar.TabIndex = 9;
            BGuardar.Text = "Añadir Proveedor";
            BGuardar.TextAlign = ContentAlignment.MiddleRight;
            BGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // TTelefonoProveedor
            // 
            TTelefonoProveedor.Location = new Point(33, 276);
            TTelefonoProveedor.Margin = new Padding(3, 4, 3, 4);
            TTelefonoProveedor.Name = "TTelefonoProveedor";
            TTelefonoProveedor.Size = new Size(253, 27);
            TTelefonoProveedor.TabIndex = 4;
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
            // TCorreoProveedor
            // 
            TCorreoProveedor.Location = new Point(33, 205);
            TCorreoProveedor.Margin = new Padding(3, 4, 3, 4);
            TCorreoProveedor.Name = "TCorreoProveedor";
            TCorreoProveedor.Size = new Size(253, 27);
            TCorreoProveedor.TabIndex = 3;
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
            // TRazonSocialProveedor
            // 
            TRazonSocialProveedor.Location = new Point(33, 135);
            TRazonSocialProveedor.Margin = new Padding(3, 4, 3, 4);
            TRazonSocialProveedor.Name = "TRazonSocialProveedor";
            TRazonSocialProveedor.Size = new Size(253, 27);
            TRazonSocialProveedor.TabIndex = 2;
            // 
            // LRazonSocialPro
            // 
            LRazonSocialPro.AutoSize = true;
            LRazonSocialPro.Location = new Point(33, 111);
            LRazonSocialPro.Name = "LRazonSocialPro";
            LRazonSocialPro.Size = new Size(101, 20);
            LRazonSocialPro.TabIndex = 2;
            LRazonSocialPro.Text = "Razón Social: ";
            // 
            // TDocumentoProveedor
            // 
            TDocumentoProveedor.Location = new Point(33, 64);
            TDocumentoProveedor.Margin = new Padding(3, 4, 3, 4);
            TDocumentoProveedor.Name = "TDocumentoProveedor";
            TDocumentoProveedor.Size = new Size(253, 27);
            TDocumentoProveedor.TabIndex = 1;
            // 
            // LDocumentoProveedor
            // 
            LDocumentoProveedor.AutoSize = true;
            LDocumentoProveedor.Location = new Point(33, 40);
            LDocumentoProveedor.Name = "LDocumentoProveedor";
            LDocumentoProveedor.Size = new Size(87, 20);
            LDocumentoProveedor.TabIndex = 0;
            LDocumentoProveedor.Text = "Documento";
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(377, 41);
            label8.Name = "label8";
            label8.Size = new Size(1155, 90);
            label8.TabIndex = 3;
            label8.Text = "Lista de Proveedores:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TBusqueda
            // 
            TBusqueda.Location = new Point(1153, 79);
            TBusqueda.Margin = new Padding(3, 4, 3, 4);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(246, 27);
            TBusqueda.TabIndex = 10;
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
            BBusqueda.Location = new Point(1405, 73);
            BBusqueda.Margin = new Padding(3, 4, 3, 4);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(54, 39);
            BBusqueda.TabIndex = 11;
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
            BLimpiarBusqueda.Location = new Point(1465, 73);
            BLimpiarBusqueda.Margin = new Padding(3, 4, 3, 4);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(54, 39);
            BLimpiarBusqueda.TabIndex = 12;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { BSeleccionar, idUsuario, documento, razonSocial, correoProveedor, telefonoProveedor, estadoValorProveedor, estadoProveedor });
            dgvData.Location = new Point(377, 159);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(1155, 433);
            dgvData.TabIndex = 13;
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
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1585, 677);
            Controls.Add(dgvData);
            Controls.Add(BLimpiarBusqueda);
            Controls.Add(BBusqueda);
            Controls.Add(TBusqueda);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "frmProveedores";
            Text = "frmProveedores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox TIndice;
        private ComboBox CEstado;
        private Label LEstado;
        private TextBox TIdUsuario;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private FontAwesome.Sharp.IconButton BGuardar;
        private TextBox TTelefonoProveedor;
        private Label label4;
        private TextBox TCorreoProveedor;
        private Label label3;
        private TextBox TRazonSocialProveedor;
        private Label LRazonSocialPro;
        private TextBox TDocumentoProveedor;
        private Label LDocumentoProveedor;
        private Label label8;
        private TextBox TBusqueda;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private DataGridView dgvData;
        private DataGridViewButtonColumn BSeleccionar;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn razonSocial;
        private DataGridViewTextBoxColumn correoProveedor;
        private DataGridViewTextBoxColumn telefonoProveedor;
        private DataGridViewTextBoxColumn estadoValorProveedor;
        private DataGridViewTextBoxColumn estadoProveedor;
    }
}