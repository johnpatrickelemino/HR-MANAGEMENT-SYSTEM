namespace HR_MANAGEMENT_SYSTEM
{
    partial class eval
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
            showPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            comboBox1 = new ComboBox();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(showPanel);
            guna2GradientPanel1.Controls.Add(guna2HtmlLabel1);
            guna2GradientPanel1.Controls.Add(comboBox1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.Dock = DockStyle.Fill;
            guna2GradientPanel1.FillColor = Color.Yellow;
            guna2GradientPanel1.FillColor2 = Color.Yellow;
            guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientPanel1.Size = new Size(600, 450);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // showPanel
            // 
            showPanel.CustomizableEdges = customizableEdges1;
            showPanel.Location = new Point(43, 118);
            showPanel.Name = "showPanel";
            showPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            showPanel.Size = new Size(500, 320);
            showPanel.TabIndex = 4;
            showPanel.Paint += guna2GradientPanel2_Paint;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.BackgroundImageLayout = ImageLayout.None;
            guna2HtmlLabel1.BorderStyle = BorderStyle.FixedSingle;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(177, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(239, 54);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "EVALUATION";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "fullname";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(43, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(500, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "                                                 ------------Select applicant------------";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // eval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "eval";
            Text = "eval";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientPanel showPanel;
    }
}