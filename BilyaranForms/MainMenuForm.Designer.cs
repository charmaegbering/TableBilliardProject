namespace BilyaranForms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            btn_tables = new Button();
            btn_about = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_tables
            // 
            btn_tables.BackColor = Color.Transparent;
            btn_tables.FlatAppearance.BorderSize = 0;
            btn_tables.FlatStyle = FlatStyle.Flat;
            btn_tables.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tables.ForeColor = Color.White;
            btn_tables.Location = new Point(63, 118);
            btn_tables.Name = "btn_tables";
            btn_tables.Size = new Size(150, 60);
            btn_tables.TabIndex = 0;
            btn_tables.Text = "Select Table";
            btn_tables.UseVisualStyleBackColor = false;
            btn_tables.Click += btn_tables_Click;
            // 
            // btn_about
            // 
            btn_about.BackColor = Color.Transparent;
            btn_about.FlatAppearance.BorderSize = 0;
            btn_about.FlatStyle = FlatStyle.Flat;
            btn_about.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_about.ForeColor = Color.White;
            btn_about.Location = new Point(63, 184);
            btn_about.Name = "btn_about";
            btn_about.Size = new Size(150, 60);
            btn_about.TabIndex = 1;
            btn_about.Text = "About";
            btn_about.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(63, 241);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(150, 60);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(388, 450);
            Controls.Add(btn_exit);
            Controls.Add(btn_about);
            Controls.Add(btn_tables);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_tables;
        private Button btn_about;
        private Button btn_exit;
    }
}