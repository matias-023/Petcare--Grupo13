namespace CapaPresentacion
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            TDocumento = new TextBox();
            TContraseña = new TextBox();
            label3 = new Label();
            label4 = new Label();
            BIngresar = new FontAwesome.Sharp.IconButton();
            BCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SaddleBrown;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 236);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SaddleBrown;
            label2.Font = new Font("Microsoft Sans Serif", 30F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 163);
            label2.Name = "label2";
            label2.Size = new Size(166, 46);
            label2.TabIndex = 1;
            label2.Text = "PetCare";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SaddleBrown;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShieldDog;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 120;
            iconPictureBox1.Location = new Point(54, 35);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(120, 120);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // TDocumento
            // 
            TDocumento.BackColor = SystemColors.Control;
            TDocumento.Location = new Point(261, 53);
            TDocumento.Name = "TDocumento";
            TDocumento.Size = new Size(232, 23);
            TDocumento.TabIndex = 3;
            // 
            // TContraseña
            // 
            TContraseña.BackColor = SystemColors.Control;
            TContraseña.Location = new Point(261, 115);
            TContraseña.Name = "TContraseña";
            TContraseña.PasswordChar = '*';
            TContraseña.Size = new Size(232, 23);
            TContraseña.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 35);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 5;
            label3.Text = "Número de Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 97);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // BIngresar
            // 
            BIngresar.BackColor = Color.SaddleBrown;
            BIngresar.Cursor = Cursors.Hand;
            BIngresar.FlatAppearance.BorderColor = Color.Black;
            BIngresar.FlatStyle = FlatStyle.Flat;
            BIngresar.ForeColor = Color.White;
            BIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BIngresar.IconColor = Color.White;
            BIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BIngresar.IconSize = 30;
            BIngresar.Location = new Point(261, 175);
            BIngresar.Name = "BIngresar";
            BIngresar.Size = new Size(100, 40);
            BIngresar.TabIndex = 7;
            BIngresar.Text = "Ingresar";
            BIngresar.TextAlign = ContentAlignment.MiddleRight;
            BIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BIngresar.UseVisualStyleBackColor = false;
            BIngresar.Click += BIngresar_Click;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.Firebrick;
            BCancelar.Cursor = Cursors.Hand;
            BCancelar.FlatAppearance.BorderColor = Color.Black;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.ForeColor = Color.White;
            BCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            BCancelar.IconColor = Color.White;
            BCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BCancelar.IconSize = 30;
            BCancelar.Location = new Point(393, 175);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(100, 40);
            BCancelar.TabIndex = 8;
            BCancelar.Text = "Cancelar";
            BCancelar.TextAlign = ContentAlignment.MiddleRight;
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(532, 236);
            Controls.Add(BCancelar);
            Controls.Add(BIngresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TContraseña);
            Controls.Add(TDocumento);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox TDocumento;
        private TextBox TContraseña;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton BIngresar;
        private FontAwesome.Sharp.IconButton BCancelar;
    }
}