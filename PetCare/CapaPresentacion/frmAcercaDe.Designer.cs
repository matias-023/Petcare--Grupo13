namespace CapaPresentacion
{
    partial class frmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            panel1 = new Panel();
            label14 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 372);
            panel1.TabIndex = 14;
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label14.Location = new Point(30, 308);
            label14.Name = "label14";
            label14.Size = new Size(787, 37);
            label14.TabIndex = 27;
            label14.Text = "PetCare se ofrece \"tal cual\", sin garantías de funcionamiento o precisión. Grupo_13 no se hace responsable de daños derivados de su uso.";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(979, 97);
            label2.TabIndex = 16;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 23.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(393, 37);
            label1.TabIndex = 15;
            label1.Text = "Derechos de Copyright\n\n";
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label11.Location = new Point(12, 264);
            label11.Name = "label11";
            label11.Size = new Size(335, 37);
            label11.TabIndex = 25;
            label11.Text = "Exención de Responsabilidad\n\n";
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label10.Location = new Point(30, 214);
            label10.Name = "label10";
            label10.Size = new Size(763, 37);
            label10.TabIndex = 24;
            label10.Text = "Esta aplicación se proporciona solo para uso personal según los términos de la licencia aplicable. Para otros usos, contacta a grupo13@gmail.com.";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label7.Location = new Point(12, 178);
            label7.Name = "label7";
            label7.Size = new Size(178, 37);
            label7.TabIndex = 21;
            label7.Text = "Licencia de Uso";
            // 
            // frmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1012, 379);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAcercaDe";
            Text = "frmAcercaDe";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label14;
        private Label label2;
        private Label label1;
        private Label label11;
        private Label label10;
        private Label label7;
    }
}