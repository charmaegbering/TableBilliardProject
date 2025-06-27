namespace FormsBilliard
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            lbl_about = new Label();
            btn_Home = new Button();
            SuspendLayout();
            // 
            // lbl_about
            // 
            lbl_about.AutoSize = true;
            lbl_about.BackColor = Color.Transparent;
            lbl_about.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_about.ForeColor = Color.Black;
            lbl_about.Location = new Point(12, 10);
            lbl_about.Name = "lbl_about";
            lbl_about.Size = new Size(631, 425);
            lbl_about.TabIndex = 0;
            lbl_about.Text = resources.GetString("lbl_about.Text");
            lbl_about.Click += lbl_about_Click;
            // 
            // btn_Home
            // 
            btn_Home.BackColor = Color.Green;
            btn_Home.FlatAppearance.BorderSize = 0;
            btn_Home.FlatStyle = FlatStyle.Flat;
            btn_Home.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Home.ForeColor = Color.White;
            btn_Home.Location = new Point(217, 423);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(150, 50);
            btn_Home.TabIndex = 1;
            btn_Home.Text = "HOME";
            btn_Home.UseVisualStyleBackColor = false;
            btn_Home.Click += btn_Home_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(637, 494);
            Controls.Add(btn_Home);
            Controls.Add(lbl_about);
            DoubleBuffered = true;
            Name = "AboutForm";
            Text = "AboutForm";
            Load += AboutForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_about;
        private Button btn_Home;
    }
}