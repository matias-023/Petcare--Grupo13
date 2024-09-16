namespace CapaPresentacion
{
    partial class frmDetalleVenta
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
            label1 = new Label();
            TCodigoVenta = new TextBox();
            BLimpiar = new FontAwesome.Sharp.IconButton();
            BBuscar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label6 = new Label();
            TTipoDocumento = new TextBox();
            label7 = new Label();
            TFecha = new TextBox();
            TMedioPago = new TextBox();
            groupBox2 = new GroupBox();
            TIdVenta = new TextBox();
            label3 = new Label();
            TDocumentoCliente = new TextBox();
            dgvData = new DataGridView();
            producto = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            label2 = new Label();
            TTotal = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label11 = new Label();
            BDescargar = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            groupBox1 = new GroupBox();
            label12 = new Label();
            TNombreCajero = new TextBox();
            label13 = new Label();
            TDocumentoCajero = new TextBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(287, 8);
            label8.Name = "label8";
            label8.Size = new Size(787, 552);
            label8.TabIndex = 5;
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(308, 27);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 6;
            label1.Text = "Detalle venta";
            // 
            // TCodigoVenta
            // 
            TCodigoVenta.Location = new Point(682, 69);
            TCodigoVenta.Name = "TCodigoVenta";
            TCodigoVenta.Size = new Size(172, 23);
            TCodigoVenta.TabIndex = 8;
            // 
            // BLimpiar
            // 
            BLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            BLimpiar.IconColor = Color.Black;
            BLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BLimpiar.IconSize = 18;
            BLimpiar.Location = new Point(958, 69);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(91, 23);
            BLimpiar.TabIndex = 10;
            BLimpiar.Text = "Limpiar";
            BLimpiar.TextAlign = ContentAlignment.MiddleRight;
            BLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiar.UseVisualStyleBackColor = true;
            // 
            // BBuscar
            // 
            BBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BBuscar.IconColor = Color.Black;
            BBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscar.IconSize = 18;
            BBuscar.Location = new Point(860, 69);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(92, 23);
            BBuscar.TabIndex = 9;
            BBuscar.Text = "Buscar";
            BBuscar.TextAlign = ContentAlignment.MiddleRight;
            BBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(576, 72);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 11;
            label5.Text = "Codigo de venta: ";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(TMedioPago);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(TTipoDocumento);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(TFecha);
            groupBox3.Location = new Point(308, 114);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(749, 83);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información Venta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 29);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 16;
            label6.Text = "Tipo de documento:";
            // 
            // TTipoDocumento
            // 
            TTipoDocumento.Location = new Point(199, 47);
            TTipoDocumento.Name = "TTipoDocumento";
            TTipoDocumento.Size = new Size(240, 23);
            TTipoDocumento.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 29);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 2;
            label7.Text = "Fecha:";
            // 
            // TFecha
            // 
            TFecha.Location = new Point(13, 47);
            TFecha.Name = "TFecha";
            TFecha.Size = new Size(172, 23);
            TFecha.TabIndex = 4;
            // 
            // TMedioPago
            // 
            TMedioPago.Location = new Point(455, 47);
            TMedioPago.Name = "TMedioPago";
            TMedioPago.Size = new Size(240, 23);
            TMedioPago.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(TIdVenta);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(TDocumentoCliente);
            groupBox2.Location = new Point(797, 205);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 89);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información cliente:";
            // 
            // TIdVenta
            // 
            TIdVenta.Location = new Point(189, 18);
            TIdVenta.Name = "TIdVenta";
            TIdVenta.Size = new Size(59, 23);
            TIdVenta.TabIndex = 13;
            TIdVenta.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 29);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 2;
            label3.Text = "Número de documento:";
            // 
            // TDocumentoCliente
            // 
            TDocumentoCliente.Location = new Point(13, 47);
            TDocumentoCliente.Name = "TDocumentoCliente";
            TDocumentoCliente.Size = new Size(193, 23);
            TDocumentoCliente.TabIndex = 9;
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
            dgvData.Location = new Point(308, 300);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(749, 222);
            dgvData.TabIndex = 15;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(308, 534);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 17;
            label2.Text = "Monto total:";
            // 
            // TTotal
            // 
            TTotal.Location = new Point(387, 530);
            TTotal.Name = "TTotal";
            TTotal.Size = new Size(109, 23);
            TTotal.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(510, 534);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 19;
            label9.Text = "Monto pago:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(589, 530);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 23);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(802, 530);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(81, 23);
            textBox2.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(707, 534);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 21;
            label11.Text = "Monto cambio:";
            // 
            // BDescargar
            // 
            BDescargar.IconChar = FontAwesome.Sharp.IconChar.File;
            BDescargar.IconColor = Color.Black;
            BDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BDescargar.IconSize = 18;
            BDescargar.Location = new Point(912, 530);
            BDescargar.Name = "BDescargar";
            BDescargar.Size = new Size(145, 23);
            BDescargar.TabIndex = 23;
            BDescargar.Text = "Descargar en PDF";
            BDescargar.TextAlign = ContentAlignment.MiddleRight;
            BDescargar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BDescargar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(455, 29);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 20;
            label10.Text = "Medio de pago:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(TNombreCajero);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(TDocumentoCajero);
            groupBox1.Location = new Point(308, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 89);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información cajero:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(199, 29);
            label12.Name = "label12";
            label12.Size = new Size(108, 15);
            label12.TabIndex = 16;
            label12.Text = "Nombre completo:";
            // 
            // TNombreCajero
            // 
            TNombreCajero.Location = new Point(199, 47);
            TNombreCajero.Name = "TNombreCajero";
            TNombreCajero.Size = new Size(268, 23);
            TNombreCajero.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 29);
            label13.Name = "label13";
            label13.Size = new Size(99, 15);
            label13.TabIndex = 2;
            label13.Text = "Nro. Documento:";
            // 
            // TDocumentoCajero
            // 
            TDocumentoCajero.Location = new Point(13, 47);
            TDocumentoCajero.Name = "TDocumentoCajero";
            TDocumentoCajero.Size = new Size(172, 23);
            TDocumentoCajero.TabIndex = 7;
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 585);
            Controls.Add(groupBox1);
            Controls.Add(BDescargar);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(TTotal);
            Controls.Add(dgvData);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(TCodigoVenta);
            Controls.Add(BLimpiar);
            Controls.Add(BBuscar);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label8);
            Name = "frmDetalleVenta";
            Text = "frmDetalleVenta";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label1;
        private TextBox TCodigoVenta;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private FontAwesome.Sharp.IconButton BBuscar;
        private Label label5;
        private GroupBox groupBox3;
        private Label label6;
        private TextBox TTipoDocumento;
        private Label label7;
        private TextBox TFecha;
        private TextBox TMedioPago;
        private GroupBox groupBox2;
        private TextBox TIdVenta;
        private Label label3;
        private TextBox TDocumentoCliente;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subTotal;
        private Label label2;
        private TextBox TTotal;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label11;
        private FontAwesome.Sharp.IconButton BDescargar;
        private Label label10;
        private GroupBox groupBox1;
        private Label label12;
        private TextBox TNombreCajero;
        private Label label13;
        private TextBox TDocumentoCajero;
    }
}