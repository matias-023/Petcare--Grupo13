namespace CapaPresentacion.Modals
{
    partial class mdUsuarios
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
            titulo = new Label();
            BCerrar = new PictureBox();
            CEstado = new ComboBox();
            LEstado = new Label();
            TIdUsuario = new TextBox();
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
            label7 = new Label();
            fechaNac = new DateTimePicker();
            TFechaNac = new Label();
            RHombre = new RadioButton();
            RMujer = new RadioButton();
            label8 = new Label();
            BAgregar = new FontAwesome.Sharp.IconButton();
            BCancelar = new FontAwesome.Sharp.IconButton();
            TIndice = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(210, 120, 61);
            panel1.Controls.Add(titulo);
            panel1.Controls.Add(BCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 45);
            panel1.TabIndex = 0;
            // 
            // titulo
            // 
            titulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(187, 5);
            titulo.Name = "titulo";
            titulo.Size = new Size(248, 35);
            titulo.TabIndex = 9;
            titulo.Text = "Crear Usuario";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BCerrar
            // 
            BCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrar.BackColor = Color.FromArgb(210, 120, 61);
            BCerrar.Cursor = Cursors.Hand;
            BCerrar.Image = Properties.Resources.cerrar;
            BCerrar.Location = new Point(583, 5);
            BCerrar.Margin = new Padding(3, 4, 3, 4);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(29, 33);
            BCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            BCerrar.TabIndex = 8;
            BCerrar.TabStop = false;
            BCerrar.Click += BCerrar_Click;
            // 
            // CEstado
            // 
            CEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CEstado.Font = new Font("Microsoft Sans Serif", 9.75F);
            CEstado.FormattingEnabled = true;
            CEstado.Location = new Point(342, 343);
            CEstado.Margin = new Padding(3, 4, 3, 4);
            CEstado.Name = "CEstado";
            CEstado.Size = new Size(253, 28);
            CEstado.TabIndex = 11;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Font = new Font("Microsoft Sans Serif", 9.75F);
            LEstado.Location = new Point(343, 320);
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(66, 20);
            LEstado.TabIndex = 33;
            LEstado.Text = "Estado:";
            // 
            // TIdUsuario
            // 
            TIdUsuario.Location = new Point(566, 53);
            TIdUsuario.Margin = new Padding(3, 4, 3, 4);
            TIdUsuario.Name = "TIdUsuario";
            TIdUsuario.Size = new Size(29, 27);
            TIdUsuario.TabIndex = 32;
            TIdUsuario.Text = "0";
            TIdUsuario.Visible = false;
            // 
            // CRol
            // 
            CRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CRol.Font = new Font("Microsoft Sans Serif", 9.75F);
            CRol.FormattingEnabled = true;
            CRol.Location = new Point(342, 263);
            CRol.Margin = new Padding(3, 4, 3, 4);
            CRol.Name = "CRol";
            CRol.Size = new Size(253, 28);
            CRol.TabIndex = 10;
            // 
            // LRol
            // 
            LRol.AutoSize = true;
            LRol.Font = new Font("Microsoft Sans Serif", 9.75F);
            LRol.Location = new Point(343, 240);
            LRol.Name = "LRol";
            LRol.Size = new Size(39, 20);
            LRol.TabIndex = 31;
            LRol.Text = "Rol:";
            // 
            // TConfirmarContraseña
            // 
            TConfirmarContraseña.Font = new Font("Microsoft Sans Serif", 9.75F);
            TConfirmarContraseña.Location = new Point(342, 183);
            TConfirmarContraseña.Margin = new Padding(3, 4, 3, 4);
            TConfirmarContraseña.Name = "TConfirmarContraseña";
            TConfirmarContraseña.PasswordChar = '*';
            TConfirmarContraseña.Size = new Size(253, 26);
            TConfirmarContraseña.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(343, 160);
            label6.Name = "label6";
            label6.Size = new Size(176, 20);
            label6.TabIndex = 29;
            label6.Text = "Confirmar contraseña:";
            // 
            // TContraseña
            // 
            TContraseña.Font = new Font("Microsoft Sans Serif", 9.75F);
            TContraseña.Location = new Point(342, 103);
            TContraseña.Margin = new Padding(3, 4, 3, 4);
            TContraseña.Name = "TContraseña";
            TContraseña.PasswordChar = '*';
            TContraseña.Size = new Size(253, 26);
            TContraseña.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.Location = new Point(343, 80);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 26;
            label5.Text = "Contraseña:";
            // 
            // TTelefono
            // 
            TTelefono.Font = new Font("Microsoft Sans Serif", 9.75F);
            TTelefono.Location = new Point(27, 344);
            TTelefono.Margin = new Padding(3, 4, 3, 4);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(253, 26);
            TTelefono.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.Location = new Point(29, 320);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 23;
            label4.Text = "Teléfono:";
            // 
            // TCorreo
            // 
            TCorreo.Font = new Font("Microsoft Sans Serif", 9.75F);
            TCorreo.Location = new Point(27, 263);
            TCorreo.Margin = new Padding(3, 4, 3, 4);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(253, 26);
            TCorreo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.Location = new Point(29, 240);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 20;
            label3.Text = "Correo electrónico:";
            // 
            // TNombreCompleto
            // 
            TNombreCompleto.Font = new Font("Microsoft Sans Serif", 9.75F);
            TNombreCompleto.Location = new Point(27, 183);
            TNombreCompleto.Margin = new Padding(3, 4, 3, 4);
            TNombreCompleto.Name = "TNombreCompleto";
            TNombreCompleto.Size = new Size(253, 26);
            TNombreCompleto.TabIndex = 2;
            TNombreCompleto.TextChanged += TNombreCompleto_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(29, 160);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 17;
            label2.Text = "Nombre completo:";
            // 
            // TDocumento
            // 
            TDocumento.Font = new Font("Microsoft Sans Serif", 9.75F);
            TDocumento.Location = new Point(27, 103);
            TDocumento.Margin = new Padding(3, 4, 3, 4);
            TDocumento.Name = "TDocumento";
            TDocumento.Size = new Size(253, 26);
            TDocumento.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F);
            label7.Location = new Point(29, 80);
            label7.Name = "label7";
            label7.Size = new Size(183, 20);
            label7.TabIndex = 15;
            label7.Text = "Número de documento:";
            // 
            // fechaNac
            // 
            fechaNac.Font = new Font("Microsoft Sans Serif", 9.75F);
            fechaNac.Format = DateTimePickerFormat.Short;
            fechaNac.Location = new Point(32, 425);
            fechaNac.Margin = new Padding(3, 4, 3, 4);
            fechaNac.Name = "fechaNac";
            fechaNac.Size = new Size(135, 26);
            fechaNac.TabIndex = 5;
            // 
            // TFechaNac
            // 
            TFechaNac.AutoSize = true;
            TFechaNac.Font = new Font("Microsoft Sans Serif", 9.75F);
            TFechaNac.Location = new Point(29, 400);
            TFechaNac.Name = "TFechaNac";
            TFechaNac.Size = new Size(169, 20);
            TFechaNac.TabIndex = 35;
            TFechaNac.Text = "Fecha de nacimiento:";
            // 
            // RHombre
            // 
            RHombre.AutoSize = true;
            RHombre.Checked = true;
            RHombre.Font = new Font("Microsoft Sans Serif", 11.25F);
            RHombre.Location = new Point(32, 507);
            RHombre.Margin = new Padding(3, 4, 3, 4);
            RHombre.Name = "RHombre";
            RHombre.Size = new Size(100, 28);
            RHombre.TabIndex = 6;
            RHombre.TabStop = true;
            RHombre.Text = "Hombre";
            RHombre.UseVisualStyleBackColor = true;
            // 
            // RMujer
            // 
            RMujer.AutoSize = true;
            RMujer.Font = new Font("Microsoft Sans Serif", 11.25F);
            RMujer.Location = new Point(143, 507);
            RMujer.Margin = new Padding(3, 4, 3, 4);
            RMujer.Name = "RMujer";
            RMujer.Size = new Size(79, 28);
            RMujer.TabIndex = 7;
            RMujer.Text = "Mujer";
            RMujer.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F);
            label8.Location = new Point(29, 480);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 38;
            label8.Text = "Genero:";
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
            BAgregar.Location = new Point(297, 589);
            BAgregar.Margin = new Padding(3, 4, 3, 4);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(134, 48);
            BAgregar.TabIndex = 12;
            BAgregar.Text = "Agregar";
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
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
            BCancelar.Location = new Point(456, 589);
            BCancelar.Margin = new Padding(3, 4, 3, 4);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(134, 48);
            BCancelar.TabIndex = 13;
            BCancelar.Text = "Cancelar";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // TIndice
            // 
            TIndice.Location = new Point(529, 53);
            TIndice.Margin = new Padding(3, 4, 3, 4);
            TIndice.Name = "TIndice";
            TIndice.Size = new Size(29, 27);
            TIndice.TabIndex = 17;
            TIndice.Text = "-1";
            TIndice.Visible = false;
            // 
            // mdUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 655);
            Controls.Add(TIndice);
            Controls.Add(BCancelar);
            Controls.Add(BAgregar);
            Controls.Add(label8);
            Controls.Add(RMujer);
            Controls.Add(RHombre);
            Controls.Add(TFechaNac);
            Controls.Add(fechaNac);
            Controls.Add(CEstado);
            Controls.Add(LEstado);
            Controls.Add(TIdUsuario);
            Controls.Add(CRol);
            Controls.Add(LRol);
            Controls.Add(TConfirmarContraseña);
            Controls.Add(label6);
            Controls.Add(TContraseña);
            Controls.Add(label5);
            Controls.Add(TTelefono);
            Controls.Add(label4);
            Controls.Add(TCorreo);
            Controls.Add(label3);
            Controls.Add(TNombreCompleto);
            Controls.Add(label2);
            Controls.Add(TDocumento);
            Controls.Add(label7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "mdUsuarios";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            Load += mdUsuarios_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label titulo;
        private ComboBox CEstado;
        private Label LEstado;
        private TextBox TIdUsuario;
        private ComboBox CRol;
        private Label LRol;
        private TextBox TConfirmarContraseña;
        private Label label6;
        private TextBox TContraseña;
        private Label label5;
        private TextBox TTelefono;
        private Label label4;
        private TextBox TCorreo;
        private Label label3;
        private TextBox TNombreCompleto;
        private Label label2;
        private TextBox TDocumento;
        private Label label7;
        private DateTimePicker fechaNac;
        private Label TFechaNac;
        private RadioButton RHombre;
        private RadioButton RMujer;
        private Label label8;
        private FontAwesome.Sharp.IconButton BAgregar;
        private FontAwesome.Sharp.IconButton BCancelar;
        private PictureBox BCerrar;
        private TextBox TIndice;
    }
}