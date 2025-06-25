namespace BilyaranForms
{
    partial class TablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesForm));
            btn_table1 = new Button();
            btn_table2 = new Button();
            btn_table3 = new Button();
            btn_table4 = new Button();
            SuspendLayout();
            // 
            // btn_table1
            // 
            btn_table1.BackColor = Color.Transparent;
            btn_table1.BackgroundImageLayout = ImageLayout.None;
            btn_table1.FlatAppearance.BorderSize = 0;
            btn_table1.FlatStyle = FlatStyle.Flat;
            btn_table1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_table1.ForeColor = Color.White;
            btn_table1.Location = new Point(138, 122);
            btn_table1.Name = "btn_table1";
            btn_table1.Size = new Size(150, 50);
            btn_table1.TabIndex = 0;
            btn_table1.Text = "TABLE 1";
            btn_table1.UseVisualStyleBackColor = false;
            // 
            // btn_table2
            // 
            btn_table2.BackColor = Color.Transparent;
            btn_table2.BackgroundImageLayout = ImageLayout.None;
            btn_table2.FlatAppearance.BorderSize = 0;
            btn_table2.FlatStyle = FlatStyle.Flat;
            btn_table2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_table2.ForeColor = Color.White;
            btn_table2.Location = new Point(138, 204);
            btn_table2.Name = "btn_table2";
            btn_table2.Size = new Size(150, 50);
            btn_table2.TabIndex = 1;
            btn_table2.Text = "TABLE 2";
            btn_table2.UseVisualStyleBackColor = false;
            // 
            // btn_table3
            // 
            btn_table3.BackColor = Color.Transparent;
            btn_table3.BackgroundImageLayout = ImageLayout.None;
            btn_table3.FlatAppearance.BorderSize = 0;
            btn_table3.FlatStyle = FlatStyle.Flat;
            btn_table3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_table3.ForeColor = Color.White;
            btn_table3.Location = new Point(138, 286);
            btn_table3.Name = "btn_table3";
            btn_table3.Size = new Size(150, 50);
            btn_table3.TabIndex = 2;
            btn_table3.Text = "TABLE 3";
            btn_table3.UseVisualStyleBackColor = false;
            btn_table3.Click += button1_Click;
            // 
            // btn_table4
            // 
            btn_table4.BackColor = Color.Transparent;
            btn_table4.BackgroundImageLayout = ImageLayout.None;
            btn_table4.FlatAppearance.BorderSize = 0;
            btn_table4.FlatStyle = FlatStyle.Flat;
            btn_table4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_table4.ForeColor = Color.White;
            btn_table4.Location = new Point(138, 371);
            btn_table4.Name = "btn_table4";
            btn_table4.Size = new Size(150, 50);
            btn_table4.TabIndex = 3;
            btn_table4.Text = "TABLE 4";
            btn_table4.UseVisualStyleBackColor = false;
            // 
            // TablesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(388, 450);
            Controls.Add(btn_table4);
            Controls.Add(btn_table3);
            Controls.Add(btn_table2);
            Controls.Add(btn_table1);
            Name = "TablesForm";
            Text = "TablesForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_table1;
        private Button btn_table2;
        private Button btn_table3;
        private Button btn_table4;
    }
}