namespace FormsBilliard
{
    partial class ViewTablesForm
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
            dataview1 = new DataGridView();
            btn_delete = new Button();
            btn_update = new Button();
            btn_home = new Button();
            btn_addplayer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataview1).BeginInit();
            SuspendLayout();
            // 
            // dataview1
            // 
            dataview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataview1.Location = new Point(42, 12);
            dataview1.Name = "dataview1";
            dataview1.Size = new Size(412, 207);
            dataview1.TabIndex = 0;
            dataview1.CellContentClick += dataview1_CellContentClick;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Green;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(42, 225);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(150, 50);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Green;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(304, 225);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(150, 50);
            btn_update.TabIndex = 2;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.Green;
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_home.ForeColor = Color.White;
            btn_home.Location = new Point(304, 307);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(150, 50);
            btn_home.TabIndex = 3;
            btn_home.Text = "HOME";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // btn_addplayer
            // 
            btn_addplayer.BackColor = Color.Green;
            btn_addplayer.FlatAppearance.BorderSize = 0;
            btn_addplayer.FlatStyle = FlatStyle.Flat;
            btn_addplayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_addplayer.ForeColor = Color.White;
            btn_addplayer.Location = new Point(42, 307);
            btn_addplayer.Name = "btn_addplayer";
            btn_addplayer.Size = new Size(150, 50);
            btn_addplayer.TabIndex = 5;
            btn_addplayer.Text = "ADD";
            btn_addplayer.UseVisualStyleBackColor = false;
            btn_addplayer.Click += btn_addplayer_Click;
            // 
            // ViewTablesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bilyaran_Tables__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(521, 450);
            Controls.Add(btn_addplayer);
            Controls.Add(btn_home);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(dataview1);
            DoubleBuffered = true;
            Name = "ViewTablesForm";
            Text = "ViewTablesForm";
            ((System.ComponentModel.ISupportInitialize)dataview1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataview1;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_home;
        private Button btn_addplayer;
    }
}