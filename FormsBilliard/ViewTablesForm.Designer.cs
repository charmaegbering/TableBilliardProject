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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTablesForm));
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
            btn_delete.Location = new Point(59, 225);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(356, 225);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 2;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_home
            // 
            btn_home.Location = new Point(356, 281);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(75, 23);
            btn_home.TabIndex = 3;
            btn_home.Text = "HOME";
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // btn_addplayer
            // 
            btn_addplayer.Location = new Point(68, 281);
            btn_addplayer.Name = "btn_addplayer";
            btn_addplayer.Size = new Size(75, 23);
            btn_addplayer.TabIndex = 5;
            btn_addplayer.Text = "ADD";
            btn_addplayer.UseVisualStyleBackColor = true;
            btn_addplayer.Click += btn_addplayer_Click;
            // 
            // ViewTablesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
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