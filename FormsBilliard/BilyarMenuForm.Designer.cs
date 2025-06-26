namespace FormsBilliard
{
    partial class BilyarMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilyarMenuForm));
            btn_tables = new Button();
            btn_display = new Button();
            btn_about = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_tables
            // 
            btn_tables.BackColor = Color.Transparent;
            btn_tables.FlatAppearance.BorderSize = 0;
            btn_tables.FlatStyle = FlatStyle.Flat;
            btn_tables.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tables.ForeColor = Color.Black;
            btn_tables.Location = new Point(59, 131);
            btn_tables.Name = "btn_tables";
            btn_tables.Size = new Size(293, 54);
            btn_tables.TabIndex = 0;
            btn_tables.Text = "TABLES";
            btn_tables.UseVisualStyleBackColor = false;
            btn_tables.UseWaitCursor = true;
            btn_tables.Click += btn_tables_Click;
            // 
            // btn_display
            // 
            btn_display.BackColor = Color.Transparent;
            btn_display.FlatAppearance.BorderSize = 0;
            btn_display.FlatStyle = FlatStyle.Flat;
            btn_display.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_display.ForeColor = Color.Black;
            btn_display.Location = new Point(82, 222);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(258, 55);
            btn_display.TabIndex = 1;
            btn_display.Text = "DISPLAY";
            btn_display.UseVisualStyleBackColor = false;
            btn_display.UseWaitCursor = true;
            btn_display.Click += btn_display_Click;
            // 
            // btn_about
            // 
            btn_about.BackColor = Color.Transparent;
            btn_about.FlatAppearance.BorderSize = 0;
            btn_about.FlatStyle = FlatStyle.Flat;
            btn_about.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_about.ForeColor = Color.Black;
            btn_about.Location = new Point(129, 312);
            btn_about.Name = "btn_about";
            btn_about.Size = new Size(150, 50);
            btn_about.TabIndex = 2;
            btn_about.Text = "ABOUT";
            btn_about.UseVisualStyleBackColor = false;
            btn_about.UseWaitCursor = true;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.Black;
            btn_exit.Location = new Point(129, 402);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(150, 50);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "EXIT";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.UseWaitCursor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // BilyarMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(381, 487);
            Controls.Add(btn_exit);
            Controls.Add(btn_about);
            Controls.Add(btn_display);
            Controls.Add(btn_tables);
            Name = "BilyarMenuForm";
            Text = "BilyarMenuForm";
            Load += BilyarMenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_tables;
        private Button btn_display;
        private Button btn_about;
        private Button btn_exit;
    }
}