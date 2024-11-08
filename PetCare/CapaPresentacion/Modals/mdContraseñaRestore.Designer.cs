namespace CapaPresentacion.Modals
{
    partial class mdContraseñaRestore
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
            BCancelar = new FontAwesome.Sharp.IconButton();
            BAgregar = new FontAwesome.Sharp.IconButton();
            TContraseña = new TextBox();
            titulo = new Label();
            BCerrar = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)BCerrar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(545, 54);
            label1.TabIndex = 14;
            label1.Text = "Ingrese la contraseña del Usuario de Emergencia: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            BCancelar.Location = new Point(281, 149);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(143, 36);
            BCancelar.TabIndex = 16;
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
            BAgregar.IconChar = FontAwesome.Sharp.IconChar.Database;
            BAgregar.IconColor = Color.White;
            BAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregar.IconSize = 30;
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(132, 149);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(143, 36);
            BAgregar.TabIndex = 15;
            BAgregar.Text = "Restaurar";
            BAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // TContraseña
            // 
            TContraseña.Font = new Font("Microsoft Sans Serif", 9.75F);
            TContraseña.Location = new Point(133, 106);
            TContraseña.Name = "TContraseña";
            TContraseña.PasswordChar = '*';
            TContraseña.Size = new Size(292, 22);
            TContraseña.TabIndex = 17;
            TContraseña.KeyDown += TContraseña_KeyDown;
            // 
            // titulo
            // 
            titulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(54, 6);
            titulo.Name = "titulo";
            titulo.Size = new Size(455, 28);
            titulo.TabIndex = 9;
            titulo.Text = "Restaurar base de datos";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BCerrar
            // 
            BCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrar.BackColor = Color.FromArgb(210, 120, 61);
            BCerrar.Cursor = Cursors.Hand;
            BCerrar.Image = Properties.Resources.cerrar;
            BCerrar.Location = new Point(537, 6);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(25, 25);
            BCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            BCerrar.TabIndex = 9;
            BCerrar.TabStop = false;
            BCerrar.Click += BCerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(210, 120, 61);
            panel1.Controls.Add(BCerrar);
            panel1.Controls.Add(titulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 37);
            panel1.TabIndex = 3;
            // 
            // mdContraseñaRestore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 198);
            Controls.Add(TContraseña);
            Controls.Add(BCancelar);
            Controls.Add(BAgregar);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mdContraseñaRestore";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdContraseñaRestore";
            ((System.ComponentModel.ISupportInitialize)BCerrar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private FontAwesome.Sharp.IconButton BCancelar;
        private FontAwesome.Sharp.IconButton BAgregar;
        private TextBox TContraseña;
        private Label titulo;
        private PictureBox BCerrar;
        private Panel panel1;
    }
}