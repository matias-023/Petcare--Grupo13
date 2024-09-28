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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(210, 120, 61);
            label1.Location = new Point(-5, -5);
            label1.Name = "label1";
            label1.Size = new Size(1522, 128);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(210, 120, 61);
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 42);
            label2.Name = "label2";
            label2.Size = new Size(252, 35);
            label2.TabIndex = 1;
            label2.Text = "Backup y restauracion";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(387, 205);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 28);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 205);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 3;
            label3.Text = "Base de datos:";
            // 
            // button1
            // 
            button1.Location = new Point(605, 205);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 4;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 258);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 5;
            label4.Text = "Ruta a guardar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(387, 255);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(689, 34);
            textBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.magnifier_1_icon_icons_com_56924;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1082, 249);
            button2.Name = "button2";
            button2.Size = new Size(162, 47);
            button2.TabIndex = 7;
            button2.Text = "Ruta";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1082, 312);
            button3.Name = "button3";
            button3.Size = new Size(162, 59);
            button3.TabIndex = 8;
            button3.Text = "Backup";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 445);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 9;
            label5.Text = "Ruta a restaurar:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(387, 442);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(689, 34);
            textBox2.TabIndex = 10;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.magnifier_1_icon_icons_com_56924;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(1082, 432);
            button4.Name = "button4";
            button4.Size = new Size(162, 47);
            button4.TabIndex = 11;
            button4.Text = "Ruta";
            button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 515);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 12;
            label6.Text = "Base de datos:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(387, 512);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(689, 34);
            textBox3.TabIndex = 13;
            // 
            // button5
            // 
            button5.Location = new Point(1082, 496);
            button5.Name = "button5";
            button5.Size = new Size(162, 59);
            button5.TabIndex = 14;
            button5.Text = "Restaurar";
            button5.UseVisualStyleBackColor = true;
            // 
            // frmBackup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 705);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBackup";
            Text = "frmBackup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Label label5;
        private TextBox textBox2;
        private Button button4;
        private Label label6;
        private TextBox textBox3;
        private Button button5;
    }
}