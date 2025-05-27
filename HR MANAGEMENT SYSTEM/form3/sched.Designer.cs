namespace HR_MANAGEMENT_SYSTEM
{
    partial class sched
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            panel1 = new Panel();
            guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            guna2GradientPanel1.SuspendLayout();
            guna2GradientPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.Transparent;
            guna2GradientPanel1.Controls.Add(panel1);
            guna2GradientPanel1.Controls.Add(guna2GradientPanel3);
            guna2GradientPanel1.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.Dock = DockStyle.Fill;
            guna2GradientPanel1.FillColor = Color.Yellow;
            guna2GradientPanel1.FillColor2 = Color.Yellow;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientPanel1.Size = new Size(600, 450);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Location = new Point(45, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 226);
            panel1.TabIndex = 3;
            // 
            // guna2GradientPanel3
            // 
            guna2GradientPanel3.BackColor = Color.Transparent;
            guna2GradientPanel3.Controls.Add(label1);
            guna2GradientPanel3.Controls.Add(comboBox1);
            guna2GradientPanel3.CustomizableEdges = customizableEdges1;
            guna2GradientPanel3.FillColor = Color.Green;
            guna2GradientPanel3.FillColor2 = Color.Green;
            guna2GradientPanel3.Location = new Point(23, 12);
            guna2GradientPanel3.Name = "guna2GradientPanel3";
            guna2GradientPanel3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel3.Size = new Size(565, 137);
            guna2GradientPanel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" });
            comboBox1.Location = new Point(56, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(454, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "                                                          select applicant";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 13);
            label1.Name = "label1";
            label1.Size = new Size(196, 47);
            label1.TabIndex = 1;
            label1.Text = "SCHEDULE";
            // 
            // sched
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(600, 450);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sched";
            Text = "sched";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel3.ResumeLayout(false);
            guna2GradientPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label1;
    }
}