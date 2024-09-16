namespace CapaPresentacion
{
    partial class frmCompras
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
            label8 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            CTipoDocumento = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            TFecha = new TextBox();
            groupBox2 = new GroupBox();
            TIdProveedor = new TextBox();
            TRazonSocial = new TextBox();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label5 = new Label();
            TDocumentoProveedor = new TextBox();
            groupBox3 = new GroupBox();
            label11 = new Label();
            TCantidad = new NumericUpDown();
            label10 = new Label();
            TPrecioVenta = new TextBox();
            label9 = new Label();
            TPrecioCompra = new TextBox();
            label6 = new Label();
            TProducto = new TextBox();
            TIdProducto = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            TCodProducto = new TextBox();
            dgvData = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            BEliminar = new DataGridViewButtonColumn();
            BAgregar = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            TTotal = new TextBox();
            BRegistrar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(155, 10);
            label8.Name = "label8";
            label8.Size = new Size(1020, 549);
            label8.TabIndex = 3;
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(174, 29);
            label1.Name = "label1";
            label1.Size = new Size(189, 31);
            label1.TabIndex = 4;
            label1.Text = "Registrar compra";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(CTipoDocumento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TFecha);
            groupBox1.Location = new Point(174, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 89);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información compra";
            // 
            // CTipoDocumento
            // 
            CTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            CTipoDocumento.FormattingEnabled = true;
            CTipoDocumento.Location = new Point(207, 42);
            CTipoDocumento.Name = "CTipoDocumento";
            CTipoDocumento.Size = new Size(172, 23);
            CTipoDocumento.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 24);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 3;
            label3.Text = "Tipo Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 24);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // TFecha
            // 
            TFecha.BackColor = SystemColors.Control;
            TFecha.Location = new Point(16, 42);
            TFecha.Name = "TFecha";
            TFecha.Size = new Size(172, 23);
            TFecha.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(TIdProveedor);
            groupBox2.Controls.Add(TRazonSocial);
            groupBox2.Controls.Add(BBusqueda);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TDocumentoProveedor);
            groupBox2.Location = new Point(586, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(576, 89);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información proveedor";
            // 
            // TIdProveedor
            // 
            TIdProveedor.Location = new Point(521, 12);
            TIdProveedor.Name = "TIdProveedor";
            TIdProveedor.Size = new Size(35, 23);
            TIdProveedor.TabIndex = 13;
            TIdProveedor.Visible = false;
            // 
            // TRazonSocial
            // 
            TRazonSocial.BackColor = SystemColors.Control;
            TRazonSocial.Location = new Point(247, 41);
            TRazonSocial.Name = "TRazonSocial";
            TRazonSocial.Size = new Size(309, 23);
            TRazonSocial.TabIndex = 12;
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
            BBusqueda.Location = new Point(194, 41);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(47, 23);
            BBusqueda.TabIndex = 11;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 23);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 3;
            label4.Text = "Razon social: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 24);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 2;
            label5.Text = "Número de documento:";
            // 
            // TDocumentoProveedor
            // 
            TDocumentoProveedor.BackColor = SystemColors.Control;
            TDocumentoProveedor.Location = new Point(16, 42);
            TDocumentoProveedor.Name = "TDocumentoProveedor";
            TDocumentoProveedor.Size = new Size(172, 23);
            TDocumentoProveedor.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(TCantidad);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(TPrecioVenta);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(TPrecioCompra);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(TProducto);
            groupBox3.Controls.Add(TIdProducto);
            groupBox3.Controls.Add(iconButton1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(TCodProducto);
            groupBox3.Location = new Point(174, 169);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(838, 83);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información de Producto:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(718, 24);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 22;
            label11.Text = "Cantidad: ";
            // 
            // TCantidad
            // 
            TCantidad.Location = new Point(718, 41);
            TCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            TCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TCantidad.Name = "TCantidad";
            TCantidad.Size = new Size(120, 23);
            TCantidad.TabIndex = 21;
            TCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(606, 24);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 20;
            label10.Text = "Precio venta:";
            // 
            // TPrecioVenta
            // 
            TPrecioVenta.Location = new Point(606, 41);
            TPrecioVenta.Name = "TPrecioVenta";
            TPrecioVenta.Size = new Size(106, 23);
            TPrecioVenta.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(494, 24);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 18;
            label9.Text = "Precio compra:";
            // 
            // TPrecioCompra
            // 
            TPrecioCompra.Location = new Point(494, 41);
            TPrecioCompra.Name = "TPrecioCompra";
            TPrecioCompra.Size = new Size(106, 23);
            TPrecioCompra.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 23);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 16;
            label6.Text = "Producto:";
            // 
            // TProducto
            // 
            TProducto.BackColor = SystemColors.Control;
            TProducto.Location = new Point(247, 41);
            TProducto.Name = "TProducto";
            TProducto.Size = new Size(241, 23);
            TProducto.TabIndex = 15;
            // 
            // TIdProducto
            // 
            TIdProducto.Location = new Point(153, 13);
            TIdProducto.Name = "TIdProducto";
            TIdProducto.Size = new Size(35, 23);
            TIdProducto.TabIndex = 14;
            TIdProducto.Visible = false;
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
            iconButton1.Location = new Point(194, 41);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(47, 23);
            iconButton1.TabIndex = 12;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 24);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 2;
            label7.Text = "Codigo de producto:";
            // 
            // TCodProducto
            // 
            TCodProducto.Location = new Point(16, 42);
            TCodProducto.Name = "TCodProducto";
            TCodProducto.Size = new Size(172, 23);
            TCodProducto.TabIndex = 0;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { idProducto, producto, precioCompra, precioVenta, cantidad, subTotal, BEliminar });
            dgvData.Location = new Point(174, 258);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(838, 289);
            dgvData.TabIndex = 8;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "idProducto";
            idProducto.MinimumWidth = 6;
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Visible = false;
            idProducto.Width = 125;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 300;
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "Precio compra";
            precioCompra.MinimumWidth = 6;
            precioCompra.Name = "precioCompra";
            precioCompra.ReadOnly = true;
            precioCompra.Width = 150;
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "precioVenta";
            precioVenta.MinimumWidth = 6;
            precioVenta.Name = "precioVenta";
            precioVenta.ReadOnly = true;
            precioVenta.Visible = false;
            precioVenta.Width = 250;
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
            // BEliminar
            // 
            BEliminar.HeaderText = "";
            BEliminar.MinimumWidth = 6;
            BEliminar.Name = "BEliminar";
            BEliminar.ReadOnly = true;
            BEliminar.Width = 35;
            // 
            // BAgregar
            // 
            BAgregar.Cursor = Cursors.Hand;
            BAgregar.FlatAppearance.BorderColor = Color.Black;
            BAgregar.Font = new Font("Segoe UI", 12F);
            BAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            BAgregar.IconColor = Color.ForestGreen;
            BAgregar.IconFont = FontAwesome.Sharp.IconFont.Brands;
            BAgregar.IconSize = 45;
            BAgregar.Location = new Point(1018, 169);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(144, 83);
            BAgregar.TabIndex = 8;
            BAgregar.Text = "Agregar";
            BAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            BAgregar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(1018, 449);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 22;
            label12.Text = "Total a pagar:";
            // 
            // TTotal
            // 
            TTotal.Location = new Point(1018, 467);
            TTotal.Name = "TTotal";
            TTotal.Size = new Size(144, 23);
            TTotal.TabIndex = 9;
            // 
            // BRegistrar
            // 
            BRegistrar.Cursor = Cursors.Hand;
            BRegistrar.FlatAppearance.BorderColor = Color.Black;
            BRegistrar.Font = new Font("Segoe UI", 12F);
            BRegistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            BRegistrar.IconColor = Color.DodgerBlue;
            BRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BRegistrar.IconSize = 40;
            BRegistrar.Location = new Point(1018, 496);
            BRegistrar.Name = "BRegistrar";
            BRegistrar.Size = new Size(144, 51);
            BRegistrar.TabIndex = 10;
            BRegistrar.Text = "Registrar";
            BRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BRegistrar.UseVisualStyleBackColor = true;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 573);
            Controls.Add(BRegistrar);
            Controls.Add(label12);
            Controls.Add(TTotal);
            Controls.Add(BAgregar);
            Controls.Add(dgvData);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label8);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCompras";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox TFecha;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private TextBox TDocumentoProveedor;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private TextBox TIdProveedor;
        private TextBox TRazonSocial;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox TCodProducto;
        private NumericUpDown TCantidad;
        private Label label10;
        private TextBox TPrecioVenta;
        private Label label9;
        private TextBox TPrecioCompra;
        private Label label6;
        private TextBox TProducto;
        private TextBox TIdProducto;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label11;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subTotal;
        private DataGridViewButtonColumn BEliminar;
        private FontAwesome.Sharp.IconButton BAgregar;
        private Label label12;
        private TextBox TTotal;
        private FontAwesome.Sharp.IconButton BRegistrar;
        private ComboBox CTipoDocumento;
    }
}