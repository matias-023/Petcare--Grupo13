namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            label1 = new Label();
            label5 = new Label();
            BBuscar = new FontAwesome.Sharp.IconButton();
            BLimpiar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            groupBox3 = new GroupBox();
            label10 = new Label();
            TDocUsuario = new TextBox();
            label6 = new Label();
            TTipoDocumento = new TextBox();
            label7 = new Label();
            TFecha = new TextBox();
            groupBox2 = new GroupBox();
            TIdCompra = new TextBox();
            TRazonSocial = new TextBox();
            label4 = new Label();
            label2 = new Label();
            TDocumentoProveedor = new TextBox();
            dgvData = new DataGridView();
            producto = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            label3 = new Label();
            TTotal = new TextBox();
            BDescargar = new FontAwesome.Sharp.IconButton();
            TCodigoCompra = new TextBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(311, 30);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 5;
            label1.Text = "Detalle compra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(578, 74);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 7;
            label5.Text = "Codigo de compra:";
            // 
            // BBuscar
            // 
            BBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscar.IconColor = Color.Black;
            BBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscar.IconSize = 18;
            BBuscar.Location = new Point(871, 70);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(92, 23);
            BBuscar.TabIndex = 2;
            BBuscar.Text = "Buscar";
            BBuscar.TextAlign = ContentAlignment.MiddleRight;
            BBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // BLimpiar
            // 
            BLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            BLimpiar.IconColor = Color.Black;
            BLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BLimpiar.IconSize = 18;
            BLimpiar.Location = new Point(969, 70);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(91, 23);
            BLimpiar.TabIndex = 3;
            BLimpiar.Text = "Limpiar";
            BLimpiar.TextAlign = ContentAlignment.MiddleRight;
            BLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(290, 9);
            label8.Name = "label8";
            label8.Size = new Size(787, 552);
            label8.TabIndex = 4;
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(TDocUsuario);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(TTipoDocumento);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(TFecha);
            groupBox3.Location = new Point(311, 113);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(749, 83);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información Compra:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(458, 29);
            label10.Name = "label10";
            label10.Size = new Size(160, 15);
            label10.TabIndex = 20;
            label10.Text = "Nro. Documento del usuario:";
            // 
            // TDocUsuario
            // 
            TDocUsuario.Location = new Point(458, 47);
            TDocUsuario.Name = "TDocUsuario";
            TDocUsuario.Size = new Size(273, 23);
            TDocUsuario.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 29);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 16;
            label6.Text = "Tipo de documento:";
            // 
            // TTipoDocumento
            // 
            TTipoDocumento.Location = new Point(202, 47);
            TTipoDocumento.Name = "TTipoDocumento";
            TTipoDocumento.Size = new Size(240, 23);
            TTipoDocumento.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 29);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 2;
            label7.Text = "Fecha:";
            // 
            // TFecha
            // 
            TFecha.Location = new Point(16, 47);
            TFecha.Name = "TFecha";
            TFecha.Size = new Size(172, 23);
            TFecha.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(TIdCompra);
            groupBox2.Controls.Add(TRazonSocial);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(TDocumentoProveedor);
            groupBox2.Location = new Point(311, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(749, 89);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información proveedor";
            // 
            // TIdCompra
            // 
            TIdCompra.Location = new Point(672, 47);
            TIdCompra.Name = "TIdCompra";
            TIdCompra.Size = new Size(59, 23);
            TIdCompra.TabIndex = 13;
            TIdCompra.Visible = false;
            // 
            // TRazonSocial
            // 
            TRazonSocial.Location = new Point(202, 47);
            TRazonSocial.Name = "TRazonSocial";
            TRazonSocial.Size = new Size(309, 23);
            TRazonSocial.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 29);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 3;
            label4.Text = "Razon social: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 29);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 2;
            label2.Text = "Número de documento:";
            // 
            // TDocumentoProveedor
            // 
            TDocumentoProveedor.Location = new Point(16, 47);
            TDocumentoProveedor.Name = "TDocumentoProveedor";
            TDocumentoProveedor.Size = new Size(172, 23);
            TDocumentoProveedor.TabIndex = 0;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { producto, precioCompra, cantidad, subTotal });
            dgvData.Location = new Point(311, 297);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(749, 222);
            dgvData.TabIndex = 12;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 245;
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "Precio compra";
            precioCompra.MinimumWidth = 6;
            precioCompra.Name = "precioCompra";
            precioCompra.ReadOnly = true;
            precioCompra.Width = 150;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 150;
            // 
            // subTotal
            // 
            subTotal.HeaderText = "Sub Total";
            subTotal.MinimumWidth = 6;
            subTotal.Name = "subTotal";
            subTotal.ReadOnly = true;
            subTotal.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(311, 531);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 14;
            label3.Text = "Monto total:";
            // 
            // TTotal
            // 
            TTotal.Location = new Point(390, 527);
            TTotal.Name = "TTotal";
            TTotal.Size = new Size(172, 23);
            TTotal.TabIndex = 13;
            // 
            // BDescargar
            // 
            BDescargar.IconChar = FontAwesome.Sharp.IconChar.File;
            BDescargar.IconColor = Color.Black;
            BDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BDescargar.IconSize = 18;
            BDescargar.Location = new Point(915, 527);
            BDescargar.Name = "BDescargar";
            BDescargar.Size = new Size(145, 23);
            BDescargar.TabIndex = 15;
            BDescargar.Text = "Descargar en PDF";
            BDescargar.TextAlign = ContentAlignment.MiddleRight;
            BDescargar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BDescargar.UseVisualStyleBackColor = true;
            // 
            // TCodigoCompra
            // 
            TCodigoCompra.Location = new Point(693, 70);
            TCodigoCompra.Name = "TCodigoCompra";
            TCodigoCompra.Size = new Size(172, 23);
            TCodigoCompra.TabIndex = 1;
            // 
            // frmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 585);
            Controls.Add(TCodigoCompra);
            Controls.Add(BDescargar);
            Controls.Add(label3);
            Controls.Add(TTotal);
            Controls.Add(dgvData);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(BLimpiar);
            Controls.Add(BBuscar);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label8);
            Name = "frmDetalleCompra";
            Text = "frmDetalleCompra";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label5;
        private FontAwesome.Sharp.IconButton BBuscar;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private Label label8;
        private GroupBox groupBox3;
        private Label label10;
        private TextBox TDocUsuario;
        private Label label6;
        private TextBox TTipoDocumento;
        private Label label7;
        private TextBox TFecha;
        private GroupBox groupBox2;
        private TextBox TIdCompra;
        private TextBox TRazonSocial;
        private Label label4;
        private Label label2;
        private TextBox TDocumentoProveedor;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subTotal;
        private Label label3;
        private TextBox TTotal;
        private FontAwesome.Sharp.IconButton BDescargar;
        private TextBox TCodigoCompra;
    }
}