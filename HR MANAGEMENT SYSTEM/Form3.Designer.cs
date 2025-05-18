namespace HR_MANAGEMENT_SYSTEM
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            menubtn = new Button();
            viewabtn = new Button();
            schedbtn = new Button();
            button4 = new Button();
            aboutbtn = new Button();
            logoutbtn = new Button();
            menutransits = new System.Windows.Forms.Timer(components);
            sidebartransit = new System.Windows.Forms.Timer(components);
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            mainpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Green;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(aboutbtn);
            flowLayoutPanel1.Controls.Add(logoutbtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.ForeColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(0, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(183, 502);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(173, 38);
            button1.TabIndex = 7;
            button1.Text = "DASHBOARD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(menubtn);
            flowLayoutPanel2.Controls.Add(viewabtn);
            flowLayoutPanel2.Controls.Add(schedbtn);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 47);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(169, 50);
            flowLayoutPanel2.TabIndex = 6;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // menubtn
            // 
            menubtn.BackColor = Color.Transparent;
            menubtn.FlatStyle = FlatStyle.Popup;
            menubtn.ForeColor = Color.White;
            menubtn.Image = (Image)resources.GetObject("menubtn.Image");
            menubtn.ImageAlign = ContentAlignment.MiddleLeft;
            menubtn.Location = new Point(3, 3);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(170, 42);
            menubtn.TabIndex = 3;
            menubtn.Text = "menu";
            menubtn.UseVisualStyleBackColor = false;
            menubtn.Click += button2_Click;
            // 
            // viewabtn
            // 
            viewabtn.BackColor = Color.Transparent;
            viewabtn.FlatStyle = FlatStyle.Popup;
            viewabtn.ForeColor = Color.White;
            viewabtn.Image = (Image)resources.GetObject("viewabtn.Image");
            viewabtn.ImageAlign = ContentAlignment.MiddleLeft;
            viewabtn.Location = new Point(179, 3);
            viewabtn.Name = "viewabtn";
            viewabtn.Size = new Size(170, 41);
            viewabtn.TabIndex = 4;
            viewabtn.Text = "view applicants";
            viewabtn.UseVisualStyleBackColor = false;
            viewabtn.Click += viewabtn_Click;
            // 
            // schedbtn
            // 
            schedbtn.BackColor = Color.Transparent;
            schedbtn.FlatStyle = FlatStyle.Popup;
            schedbtn.ForeColor = Color.White;
            schedbtn.Image = (Image)resources.GetObject("schedbtn.Image");
            schedbtn.ImageAlign = ContentAlignment.MiddleLeft;
            schedbtn.Location = new Point(355, 3);
            schedbtn.Name = "schedbtn";
            schedbtn.Size = new Size(170, 41);
            schedbtn.TabIndex = 3;
            schedbtn.Text = "schedule";
            schedbtn.UseVisualStyleBackColor = false;
            schedbtn.Click += schedbtn_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(531, 3);
            button4.Name = "button4";
            button4.Size = new Size(170, 41);
            button4.TabIndex = 5;
            button4.Text = "evaluate applicants";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // aboutbtn
            // 
            aboutbtn.BackColor = Color.Transparent;
            aboutbtn.FlatStyle = FlatStyle.Popup;
            aboutbtn.ForeColor = Color.White;
            aboutbtn.Image = (Image)resources.GetObject("aboutbtn.Image");
            aboutbtn.ImageAlign = ContentAlignment.MiddleLeft;
            aboutbtn.Location = new Point(3, 103);
            aboutbtn.Name = "aboutbtn";
            aboutbtn.Size = new Size(173, 41);
            aboutbtn.TabIndex = 6;
            aboutbtn.Text = "about us";
            aboutbtn.UseVisualStyleBackColor = false;
            aboutbtn.Click += aboutbtn_Click;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.Transparent;
            logoutbtn.BackgroundImageLayout = ImageLayout.None;
            logoutbtn.FlatStyle = FlatStyle.Popup;
            logoutbtn.ForeColor = Color.White;
            logoutbtn.Image = (Image)resources.GetObject("logoutbtn.Image");
            logoutbtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutbtn.Location = new Point(3, 150);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(173, 38);
            logoutbtn.TabIndex = 6;
            logoutbtn.Text = "LOGOUT";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // menutransits
            // 
            menutransits.Interval = 3;
            menutransits.Tick += menutransits_Tick;
            // 
            // sidebartransit
            // 
            sidebartransit.Interval = 1;
            sidebartransit.Tick += sidebartransit_Tick;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.BackgroundImage = (Image)resources.GetObject("guna2PictureBox1.BackgroundImage");
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(12, 12);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(51, 29);
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.Click += guna2PictureBox1_Click;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = SystemColors.ActiveCaptionText;
            guna2CustomGradientPanel1.Controls.Add(mainpanel);
            guna2CustomGradientPanel1.Controls.Add(label1);
            guna2CustomGradientPanel1.Controls.Add(guna2PictureBox1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges5;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor = Color.FromArgb(0, 192, 0);
            guna2CustomGradientPanel1.FillColor2 = Color.Yellow;
            guna2CustomGradientPanel1.FillColor3 = Color.FromArgb(0, 192, 0);
            guna2CustomGradientPanel1.FillColor4 = Color.FromArgb(0, 192, 0);
            guna2CustomGradientPanel1.ForeColor = SystemColors.ButtonHighlight;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CustomGradientPanel1.Size = new Size(873, 556);
            guna2CustomGradientPanel1.TabIndex = 0;
            guna2CustomGradientPanel1.Paint += guna2CustomGradientPanel1_Paint;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.Transparent;
            mainpanel.CustomizableEdges = customizableEdges3;
            mainpanel.Location = new Point(182, 55);
            mainpanel.Name = "mainpanel";
            mainpanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            mainpanel.Size = new Size(702, 502);
            mainpanel.TabIndex = 2;
            mainpanel.Paint += guna2GradientPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(394, 40);
            label1.TabIndex = 1;
            label1.Text = "HR MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(873, 556);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(guna2CustomGradientPanel1);
            Name = "Form3";
            Text = "DASHBOARD";
            Load += Form3_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button schedbtn;
        private Button viewabtn;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button aboutbtn;
        private Button logoutbtn;
        private System.Windows.Forms.Timer menutransits;
        private System.Windows.Forms.Timer sidebartransit;
        private Button menubtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Label label1;
        private Button button1;
        private Guna.UI2.WinForms.Guna2GradientPanel mainpanel;
    }
}