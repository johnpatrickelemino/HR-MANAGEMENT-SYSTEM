namespace HR_MANAGEMENT_SYSTEM
{
    partial class dashboard
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GradientPanel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.Transparent;
            guna2GradientPanel1.Controls.Add(guna2Panel1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.Dock = DockStyle.Fill;
            guna2GradientPanel1.FillColor = Color.FromArgb(192, 255, 192);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 255, 192);
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientPanel1.Size = new Size(800, 450);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 30;
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(231, 12);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(267, 56);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(3, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(261, 47);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "HR DASHBOARD";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboard";
            Text = "dashboard";
            guna2GradientPanel1.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}