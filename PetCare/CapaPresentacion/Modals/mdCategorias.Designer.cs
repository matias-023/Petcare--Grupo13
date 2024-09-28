namespace CapaPresentacion.Modals
{
    partial class mdCategorias
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
            panel1 = new Panel();
            BCerrar = new PictureBox();
            titulo = new Label();
            TIndice = new TextBox();
            TIdCategoria = new TextBox();
            CEstadoCat = new ComboBox();
            LEstado = new Label();
            TDescripcionCategoria = new TextBox();
            LDescripcionCategoria = new Label();
            BCancelar = new FontAwesome.Sharp.IconButton();
            BAgregar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(210, 120, 61);
            panel1.Controls.Add(BCerrar);
            panel1.Controls.Add(titulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 34);
            panel1.TabIndex = 1;
            // 
            // BCerrar
            // 
            BCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrar.BackColor = Color.FromArgb(210, 120, 61);
            BCerrar.Cursor = Cursors.Hand;
            BCerrar.Image = Properties.Resources.cerrar;
            BCerrar.Location = new Point(375, 5);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(25, 25);
            BCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            BCerrar.TabIndex = 9;
            BCerrar.TabStop = false;
            BCerrar.Click += BCerrarCat_Click;
            // 
            // titulo
            // 
            titulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(97, 4);
            titulo.Name = "titulo";
            titulo.Size = new Size(217, 26);
            titulo.TabIndex = 9;
            titulo.Text = "Crear Categoría";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TIndice
            // 
            TIndice.Location = new Point(355, 52);
            TIndice.Name = "TIndice";
            TIndice.Size = new Size(26, 23);
            TIndice.TabIndex = 18;
            TIndice.Text = "-1";
            TIndice.Visible = false;
            // 
            // TIdCategoria
            // 
            TIdCategoria.Location = new Point(355, 81);
            TIdCategoria.Name = "TIdCategoria";
            TIdCategoria.Size = new Size(26, 23);
            TIdCategoria.TabIndex = 17;
            TIdCategoria.Text = "0";
            TIdCategoria.Visible = false;
            // 
            // CEstadoCat
            // 
            CEstadoCat.DropDownStyle = ComboBoxStyle.DropDownList;
            CEstadoCat.Font = new Font("Microsoft Sans Serif", 9.75F);
            CEstadoCat.FormattingEnabled = true;
            CEstadoCat.Location = new Point(93, 170);
            CEstadoCat.Name = "CEstadoCat";
            CEstadoCat.Size = new Size(222, 24);
            CEstadoCat.TabIndex = 2;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Font = new Font("Microsoft Sans Serif", 9.75F);
            LEstado.Location = new Point(94, 153);
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(53, 16);
            LEstado.TabIndex = 21;
            LEstado.Text = "Estado:";
            // 
            // TDescripcionCategoria
            // 
            TDescripcionCategoria.Font = new Font("Microsoft Sans Serif", 9.75F);
            TDescripcionCategoria.Location = new Point(93, 100);
            TDescripcionCategoria.Name = "TDescripcionCategoria";
            TDescripcionCategoria.Size = new Size(222, 22);
            TDescripcionCategoria.TabIndex = 1;
            // 
            // LDescripcionCategoria
            // 
            LDescripcionCategoria.AutoSize = true;
            LDescripcionCategoria.Font = new Font("Microsoft Sans Serif", 9.75F);
            LDescripcionCategoria.Location = new Point(94, 82);
            LDescripcionCategoria.Name = "LDescripcionCategoria";
            LDescripcionCategoria.Size = new Size(82, 16);
            LDescripcionCategoria.TabIndex = 19;
            LDescripcionCategoria.Text = "Descripción:";
            // 
            // BCancelar
            // 
            BCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BCancelar.BackColor = Color.Firebrick;
            BCancelar.Cursor = Cursors.Hand;
            BCancelar.FlatAppearance.BorderColor = Color.Black;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = Color.White;
            BCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            BCancelar.IconColor = Color.White;
            BCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BCancelar.IconSize = 30;
            BCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BCancelar.Location = new Point(210, 250);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(117, 36);
            BCancelar.TabIndex = 4;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
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
            BAgregar.Location = new Point(73, 250);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(107, 36);
            BAgregar.TabIndex = 3;
            BAgregar.Text = "Agregar";
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            // 
            // mdCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 308);
            Controls.Add(BCancelar);
            Controls.Add(BAgregar);
            Controls.Add(CEstadoCat);
            Controls.Add(LEstado);
            Controls.Add(TDescripcionCategoria);
            Controls.Add(LDescripcionCategoria);
            Controls.Add(TIndice);
            Controls.Add(TIdCategoria);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mdCategorias";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mcCategorias";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label titulo;
        private PictureBox BCerrar;
        private TextBox TIndice;
        private TextBox TIdCategoria;
        private ComboBox CEstadoCat;
        private Label LEstado;
        private TextBox TDescripcionCategoria;
        private Label LDescripcionCategoria;
        private FontAwesome.Sharp.IconButton BCancelar;
        private FontAwesome.Sharp.IconButton BAgregar;
    }
}