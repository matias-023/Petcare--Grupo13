﻿namespace CapaPresentacion
{
    partial class frmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvDataProd = new DataGridView();
            BSeleccionar = new DataGridViewButtonColumn();
            idProducto = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            idCategoria = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            idMarca = new DataGridViewTextBoxColumn();
            marca = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            stock_minimo = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            estadoValor = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            BAgregar = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            CBusqueda = new ComboBox();
            TBusqueda = new TextBox();
            label7 = new Label();
            label1 = new Label();
            BBusqueda = new FontAwesome.Sharp.IconButton();
            BLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvDataProd).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDataProd
            // 
            dgvDataProd.AllowUserToAddRows = false;
            dgvDataProd.AllowUserToDeleteRows = false;
            dgvDataProd.AllowUserToOrderColumns = true;
            dgvDataProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDataProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDataProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataProd.Columns.AddRange(new DataGridViewColumn[] { BSeleccionar, idProducto, codigo, nombre, idCategoria, categoria, idMarca, marca, stock, stock_minimo, precio, precioVenta, estadoValor, estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDataProd.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDataProd.Location = new Point(23, 94);
            dgvDataProd.MultiSelect = false;
            dgvDataProd.Name = "dgvDataProd";
            dgvDataProd.ReadOnly = true;
            dgvDataProd.RowHeadersVisible = false;
            dgvDataProd.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvDataProd.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDataProd.RowTemplate.Height = 28;
            dgvDataProd.Size = new Size(1001, 474);
            dgvDataProd.TabIndex = 5;
            dgvDataProd.CellContentClick += dgvDataProd_CellContentClick;
            dgvDataProd.CellPainting += dgvDataProd_CellPainting;
            // 
            // BSeleccionar
            // 
            BSeleccionar.HeaderText = "Editar";
            BSeleccionar.MinimumWidth = 60;
            BSeleccionar.Name = "BSeleccionar";
            BSeleccionar.ReadOnly = true;
            BSeleccionar.Width = 60;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "ID";
            idProducto.MinimumWidth = 6;
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Visible = false;
            idProducto.Width = 150;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 275;
            // 
            // idCategoria
            // 
            idCategoria.HeaderText = "idCategoria";
            idCategoria.MinimumWidth = 6;
            idCategoria.Name = "idCategoria";
            idCategoria.ReadOnly = true;
            idCategoria.Visible = false;
            idCategoria.Width = 125;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 150;
            // 
            // idMarca
            // 
            idMarca.HeaderText = "idMarca";
            idMarca.Name = "idMarca";
            idMarca.ReadOnly = true;
            idMarca.Visible = false;
            // 
            // marca
            // 
            marca.HeaderText = "Marca";
            marca.Name = "marca";
            marca.ReadOnly = true;
            marca.Width = 150;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            stock.ReadOnly = true;
            // 
            // stock_minimo
            // 
            stock_minimo.HeaderText = "Stock Mín.";
            stock_minimo.Name = "stock_minimo";
            stock_minimo.ReadOnly = true;
            stock_minimo.Width = 125;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 150;
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "Precio Venta";
            precioVenta.MinimumWidth = 6;
            precioVenta.Name = "precioVenta";
            precioVenta.ReadOnly = true;
            precioVenta.Width = 150;
            // 
            // estadoValor
            // 
            estadoValor.HeaderText = "estadoValorProd";
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
            estado.Width = 120;
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
            BAgregar.Location = new Point(822, 574);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(202, 50);
            BAgregar.TabIndex = 6;
            BAgregar.Text = "Agregar producto";
            BAgregar.TextAlign = ContentAlignment.MiddleRight;
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(CBusqueda);
            panel2.Controls.Add(TBusqueda);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(BBusqueda);
            panel2.Controls.Add(BLimpiarBusqueda);
            panel2.Location = new Point(23, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 68);
            panel2.TabIndex = 20;
            // 
            // CBusqueda
            // 
            CBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBusqueda.Font = new Font("Segoe UI", 11F);
            CBusqueda.FormattingEnabled = true;
            CBusqueda.Location = new Point(421, 23);
            CBusqueda.Name = "CBusqueda";
            CBusqueda.Size = new Size(221, 28);
            CBusqueda.TabIndex = 1;
            // 
            // TBusqueda
            // 
            TBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBusqueda.Location = new Point(648, 24);
            TBusqueda.Name = "TBusqueda";
            TBusqueda.Size = new Size(216, 27);
            TBusqueda.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(14, 20);
            label7.Name = "label7";
            label7.Size = new Size(235, 29);
            label7.TabIndex = 0;
            label7.Text = "Lista de productos:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(210, 120, 61);
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(328, 28);
            label1.Name = "label1";
            label1.Size = new Size(85, 18);
            label1.TabIndex = 26;
            label1.Text = "Buscar por:";
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
            BBusqueda.IconSize = 23;
            BBusqueda.Location = new Point(870, 22);
            BBusqueda.Name = "BBusqueda";
            BBusqueda.Size = new Size(47, 29);
            BBusqueda.TabIndex = 3;
            BBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBusqueda.UseVisualStyleBackColor = false;
            BBusqueda.Click += BBusqueda_Click;
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
            BLimpiarBusqueda.IconSize = 23;
            BLimpiarBusqueda.Location = new Point(925, 22);
            BLimpiarBusqueda.Name = "BLimpiarBusqueda";
            BLimpiarBusqueda.Size = new Size(47, 29);
            BLimpiarBusqueda.TabIndex = 4;
            BLimpiarBusqueda.TextAlign = ContentAlignment.MiddleRight;
            BLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            BLimpiarBusqueda.UseVisualStyleBackColor = false;
            BLimpiarBusqueda.Click += BLimpiarBusqueda_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 636);
            Controls.Add(panel2);
            Controls.Add(BAgregar);
            Controls.Add(dgvDataProd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataProd).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvDataProd;
        private FontAwesome.Sharp.IconButton BAgregar;
        private Panel panel2;
        private Label label7;
        private ComboBox CBusqueda;
        private TextBox TBusqueda;
        private Label label1;
        private FontAwesome.Sharp.IconButton BBusqueda;
        private FontAwesome.Sharp.IconButton BLimpiarBusqueda;
        private DataGridViewButtonColumn BSeleccionar;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn idCategoria;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn idMarca;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn stock_minimo;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn estadoValor;
        private DataGridViewTextBoxColumn estado;
    }
}