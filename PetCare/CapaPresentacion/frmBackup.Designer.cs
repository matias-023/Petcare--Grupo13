namespace CapaPresentacion
{
    partial class frmBackup
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
            label4 = new Label();
            txtRutaGuardar = new TextBox();
            btnRutaGuardar = new Button();
            btnBackup = new Button();
            label5 = new Label();
            txtRutaRestaurar = new TextBox();
            btnRutaBuscar = new Button();
            btnRestaurar = new Button();
            panel2 = new Panel();
            label7 = new Label();
            panel1 = new Panel();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.Location = new Point(23, 57);
            label4.Name = "label4";
            label4.Size = new Size(99, 16);
            label4.TabIndex = 5;
            label4.Text = "Ruta a guardar:";
            // 
            // txtRutaGuardar
            // 
            txtRutaGuardar.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtRutaGuardar.Location = new Point(123, 54);
            txtRutaGuardar.Margin = new Padding(3, 2, 3, 2);
            txtRutaGuardar.Multiline = true;
            txtRutaGuardar.Name = "txtRutaGuardar";
            txtRutaGuardar.Size = new Size(603, 26);
            txtRutaGuardar.TabIndex = 6;
            // 
            // btnRutaGuardar
            // 
            btnRutaGuardar.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnRutaGuardar.Image = Properties.Resources.magnifier_1_icon_icons_com_56924;
            btnRutaGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRutaGuardar.Location = new Point(732, 48);
            btnRutaGuardar.Margin = new Padding(3, 2, 3, 2);
            btnRutaGuardar.Name = "btnRutaGuardar";
            btnRutaGuardar.Size = new Size(142, 35);
            btnRutaGuardar.TabIndex = 7;
            btnRutaGuardar.Text = "Ruta";
            btnRutaGuardar.UseVisualStyleBackColor = true;
            btnRutaGuardar.Click += btnRutaGuardar_Click;
            // 
            // btnBackup
            // 
            btnBackup.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnBackup.Location = new Point(732, 87);
            btnBackup.Margin = new Padding(3, 2, 3, 2);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(142, 44);
            btnBackup.TabIndex = 8;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.Location = new Point(9, 196);
            label5.Name = "label5";
            label5.Size = new Size(105, 16);
            label5.TabIndex = 9;
            label5.Text = "Ruta a restaurar:";
            // 
            // txtRutaRestaurar
            // 
            txtRutaRestaurar.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtRutaRestaurar.Location = new Point(120, 193);
            txtRutaRestaurar.Margin = new Padding(3, 2, 3, 2);
            txtRutaRestaurar.Multiline = true;
            txtRutaRestaurar.Name = "txtRutaRestaurar";
            txtRutaRestaurar.Size = new Size(603, 26);
            txtRutaRestaurar.TabIndex = 10;
            // 
            // btnRutaBuscar
            // 
            btnRutaBuscar.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnRutaBuscar.Image = Properties.Resources.magnifier_1_icon_icons_com_56924;
            btnRutaBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRutaBuscar.Location = new Point(728, 187);
            btnRutaBuscar.Margin = new Padding(3, 2, 3, 2);
            btnRutaBuscar.Name = "btnRutaBuscar";
            btnRutaBuscar.Size = new Size(142, 35);
            btnRutaBuscar.TabIndex = 11;
            btnRutaBuscar.Text = "Ruta";
            btnRutaBuscar.UseVisualStyleBackColor = true;
            btnRutaBuscar.Click += btnRutaBuscar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnRestaurar.Location = new Point(728, 226);
            btnRestaurar.Margin = new Padding(3, 2, 3, 2);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(142, 44);
            btnRestaurar.TabIndex = 14;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(210, 120, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Location = new Point(23, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 68);
            panel2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 22);
            label7.Name = "label7";
            label7.Size = new Size(262, 25);
            label7.TabIndex = 0;
            label7.Text = "Backup y Restauración:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnRutaBuscar);
            panel1.Controls.Add(txtRutaGuardar);
            panel1.Controls.Add(txtRutaRestaurar);
            panel1.Controls.Add(btnRutaGuardar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnBackup);
            panel1.Location = new Point(23, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 288);
            panel1.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 562);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmBackup";
            Text = "frmBackup";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private TextBox txtRutaGuardar;
        private Button btnRutaGuardar;
        private Button btnBackup;
        private Label label5;
        private TextBox txtRutaRestaurar;
        private Button btnRutaBuscar;
        private Button btnRestaurar;
        private Panel panel2;
        private Label label7;
        private Panel panel1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}