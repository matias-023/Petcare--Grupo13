namespace CapaPresentacion.Modals
{
    partial class mdClientes
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
            TIdCliente = new TextBox();
            TTelefono = new TextBox();
            label4 = new Label();
            TCorreo = new TextBox();
            label3 = new Label();
            TNombreCompleto = new TextBox();
            label2 = new Label();
            TDocumento = new TextBox();
            label7 = new Label();
            CEstado = new ComboBox();
            LEstado = new Label();
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
            panel1.Size = new Size(542, 34);
            panel1.TabIndex = 1;
            // 
            // BCerrar
            // 
            BCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrar.BackColor = Color.FromArgb(210, 120, 61);
            BCerrar.Cursor = Cursors.Hand;
            BCerrar.Image = Properties.Resources.cerrar;
            BCerrar.Location = new Point(512, 5);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(25, 25);
            BCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            BCerrar.TabIndex = 9;
            BCerrar.TabStop = false;
            BCerrar.Click += BCerrar_Click;
            // 
            // titulo
            // 
            titulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(164, 4);
            titulo.Name = "titulo";
            titulo.Size = new Size(217, 26);
            titulo.TabIndex = 9;
            titulo.Text = "Crear Cliente";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TIndice
            // 
            TIndice.Location = new Point(474, 40);
            TIndice.Name = "TIndice";
            TIndice.Size = new Size(26, 23);
            TIndice.TabIndex = 33;
            TIndice.Text = "-1";
            TIndice.Visible = false;
            // 
            // TIdCliente
            // 
            TIdCliente.Location = new Point(506, 40);
            TIdCliente.Name = "TIdCliente";
            TIdCliente.Size = new Size(26, 23);
            TIdCliente.TabIndex = 34;
            TIdCliente.Text = "0";
            TIdCliente.Visible = false;
            // 
            // TTelefono
            // 
            TTelefono.Font = new Font("Microsoft Sans Serif", 9.75F);
            TTelefono.Location = new Point(24, 257);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(222, 22);
            TTelefono.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.Location = new Point(25, 238);
            label4.Name = "label4";
            label4.Size = new Size(64, 16);
            label4.TabIndex = 42;
            label4.Text = "Teléfono:";
            // 
            // TCorreo
            // 
            TCorreo.Font = new Font("Microsoft Sans Serif", 9.75F);
            TCorreo.Location = new Point(24, 197);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(222, 22);
            TCorreo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.Location = new Point(25, 179);
            label3.Name = "label3";
            label3.Size = new Size(120, 16);
            label3.TabIndex = 41;
            label3.Text = "Correo electrónico:";
            // 
            // TNombreCompleto
            // 
            TNombreCompleto.Font = new Font("Microsoft Sans Serif", 9.75F);
            TNombreCompleto.Location = new Point(24, 137);
            TNombreCompleto.Name = "TNombreCompleto";
            TNombreCompleto.Size = new Size(222, 22);
            TNombreCompleto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(25, 119);
            label2.Name = "label2";
            label2.Size = new Size(118, 16);
            label2.TabIndex = 40;
            label2.Text = "Nombre completo:";
            // 
            // TDocumento
            // 
            TDocumento.Font = new Font("Microsoft Sans Serif", 9.75F);
            TDocumento.Location = new Point(24, 77);
            TDocumento.Name = "TDocumento";
            TDocumento.Size = new Size(222, 22);
            TDocumento.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F);
            label7.Location = new Point(25, 59);
            label7.Name = "label7";
            label7.Size = new Size(147, 16);
            label7.TabIndex = 39;
            label7.Text = "Número de documento:";
            // 
            // CEstado
            // 
            CEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CEstado.Font = new Font("Microsoft Sans Serif", 9.75F);
            CEstado.FormattingEnabled = true;
            CEstado.Location = new Point(300, 75);
            CEstado.Name = "CEstado";
            CEstado.Size = new Size(222, 24);
            CEstado.TabIndex = 5;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Font = new Font("Microsoft Sans Serif", 9.75F);
            LEstado.Location = new Point(300, 56);
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(53, 16);
            LEstado.TabIndex = 44;
            LEstado.Text = "Estado:";
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
            BCancelar.Location = new Point(398, 297);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(117, 36);
            BCancelar.TabIndex = 46;
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
            BAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            BAgregar.IconColor = Color.White;
            BAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregar.IconSize = 30;
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(269, 297);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(107, 36);
            BAgregar.TabIndex = 45;
            BAgregar.Text = "Agregar";
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            // 
            // mdClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 347);
            Controls.Add(BCancelar);
            Controls.Add(BAgregar);
            Controls.Add(CEstado);
            Controls.Add(LEstado);
            Controls.Add(TTelefono);
            Controls.Add(label4);
            Controls.Add(TCorreo);
            Controls.Add(label3);
            Controls.Add(TNombreCompleto);
            Controls.Add(label2);
            Controls.Add(TDocumento);
            Controls.Add(label7);
            Controls.Add(TIndice);
            Controls.Add(TIdCliente);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mdClientes";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdClientes";
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
        private TextBox TIdCliente;
        private TextBox TTelefono;
        private Label label4;
        private TextBox TCorreo;
        private Label label3;
        private TextBox TNombreCompleto;
        private Label label2;
        private TextBox TDocumento;
        private Label label7;
        private ComboBox CEstado;
        private Label LEstado;
        private FontAwesome.Sharp.IconButton BCancelar;
        private FontAwesome.Sharp.IconButton BAgregar;
    }
}