namespace FormsBilliard
{
    partial class DisplayTForm
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
            dataview2 = new DataGridView();
            cmn_tables = new DataGridViewTextBoxColumn();
            cmn_stats = new DataGridViewTextBoxColumn();
            cmn_avail = new DataGridViewTextBoxColumn();
            btn_home = new Button();
            btn_tables = new Button();
            ((System.ComponentModel.ISupportInitialize)dataview2).BeginInit();
            SuspendLayout();
            // 
            // dataview2
            // 
            dataview2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataview2.Columns.AddRange(new DataGridViewColumn[] { cmn_tables, cmn_stats, cmn_avail });
            dataview2.Location = new Point(82, 29);
            dataview2.Name = "dataview2";
            dataview2.Size = new Size(326, 179);
            dataview2.TabIndex = 0;
            dataview2.CellContentClick += dataview2_CellContentClick;
            // 
            // cmn_tables
            // 
            cmn_tables.HeaderText = "TABLES";
            cmn_tables.Name = "cmn_tables";
            // 
            // cmn_stats
            // 
            cmn_stats.HeaderText = "STATUS";
            cmn_stats.Name = "cmn_stats";
            // 
            // cmn_avail
            // 
            cmn_avail.HeaderText = "AVAILABILITY";
            cmn_avail.Name = "cmn_avail";
            // 
            // btn_home
            // 
            btn_home.Location = new Point(82, 242);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(75, 23);
            btn_home.TabIndex = 1;
            btn_home.Text = "HOME";
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // btn_tables
            // 
            btn_tables.Location = new Point(333, 242);
            btn_tables.Name = "btn_tables";
            btn_tables.Size = new Size(75, 23);
            btn_tables.TabIndex = 2;
            btn_tables.Text = "TABLES\r\n";
            btn_tables.UseVisualStyleBackColor = true;
            btn_tables.Click += btn_tables_Click;
            // 
            // DisplayTForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(btn_tables);
            Controls.Add(btn_home);
            Controls.Add(dataview2);
            Name = "DisplayTForm";
            Text = "DisplayTForm";
            ((System.ComponentModel.ISupportInitialize)dataview2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataview2;
        private DataGridViewTextBoxColumn cmn_tables;
        private DataGridViewTextBoxColumn cmn_stats;
        private DataGridViewTextBoxColumn cmn_avail;
        private Button btn_home;
        private Button btn_tables;
    }
}