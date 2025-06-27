namespace FormsBilliard
{
    partial class AddPTForm
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
            lbl_tnumber = new Label();
            lbl_playerone = new Label();
            lbl_playertwo = new Label();
            lbl_paymentone = new Label();
            lbl_paymenttwo = new Label();
            tb_tnumber = new TextBox();
            tb_playerone = new TextBox();
            tb_playertwo = new TextBox();
            tb_onepayment = new TextBox();
            tb_twopayment = new TextBox();
            btn_enter = new Button();
            btn_Home = new Button();
            SuspendLayout();
            // 
            // lbl_tnumber
            // 
            lbl_tnumber.AutoSize = true;
            lbl_tnumber.BackColor = Color.Transparent;
            lbl_tnumber.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tnumber.ForeColor = Color.White;
            lbl_tnumber.Location = new Point(497, 28);
            lbl_tnumber.Name = "lbl_tnumber";
            lbl_tnumber.Size = new Size(214, 36);
            lbl_tnumber.TabIndex = 0;
            lbl_tnumber.Text = "TABLE NUMBER";
            // 
            // lbl_playerone
            // 
            lbl_playerone.AutoSize = true;
            lbl_playerone.BackColor = Color.Transparent;
            lbl_playerone.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_playerone.ForeColor = Color.White;
            lbl_playerone.Location = new Point(442, 163);
            lbl_playerone.Name = "lbl_playerone";
            lbl_playerone.Size = new Size(138, 30);
            lbl_playerone.TabIndex = 1;
            lbl_playerone.Text = "PLAYER ONE";
            // 
            // lbl_playertwo
            // 
            lbl_playertwo.AutoSize = true;
            lbl_playertwo.BackColor = Color.Transparent;
            lbl_playertwo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_playertwo.ForeColor = Color.White;
            lbl_playertwo.Location = new Point(630, 163);
            lbl_playertwo.Name = "lbl_playertwo";
            lbl_playertwo.Size = new Size(143, 30);
            lbl_playertwo.TabIndex = 2;
            lbl_playertwo.Text = "PLAYER TWO";
            // 
            // lbl_paymentone
            // 
            lbl_paymentone.AutoSize = true;
            lbl_paymentone.BackColor = Color.Transparent;
            lbl_paymentone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_paymentone.ForeColor = Color.White;
            lbl_paymentone.Location = new Point(451, 248);
            lbl_paymentone.Name = "lbl_paymentone";
            lbl_paymentone.Size = new Size(129, 75);
            lbl_paymentone.TabIndex = 3;
            lbl_paymentone.Text = "PLAYER ONE \r\nBALANCE:\r\n\r\n";
            // 
            // lbl_paymenttwo
            // 
            lbl_paymenttwo.AutoSize = true;
            lbl_paymenttwo.BackColor = Color.Transparent;
            lbl_paymenttwo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_paymenttwo.ForeColor = Color.Transparent;
            lbl_paymenttwo.Location = new Point(632, 252);
            lbl_paymenttwo.Name = "lbl_paymenttwo";
            lbl_paymenttwo.Size = new Size(134, 75);
            lbl_paymenttwo.TabIndex = 4;
            lbl_paymenttwo.Text = "PLAYER TWO \r\nBALANCE:\r\n\r\n";
            // 
            // tb_tnumber
            // 
            tb_tnumber.BorderStyle = BorderStyle.None;
            tb_tnumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_tnumber.Location = new Point(530, 88);
            tb_tnumber.Name = "tb_tnumber";
            tb_tnumber.Size = new Size(150, 28);
            tb_tnumber.TabIndex = 5;
            // 
            // tb_playerone
            // 
            tb_playerone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_playerone.ForeColor = Color.Black;
            tb_playerone.Location = new Point(460, 208);
            tb_playerone.Name = "tb_playerone";
            tb_playerone.ScrollBars = ScrollBars.Horizontal;
            tb_playerone.Size = new Size(100, 33);
            tb_playerone.TabIndex = 6;
            // 
            // tb_playertwo
            // 
            tb_playertwo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tb_playertwo.Location = new Point(647, 209);
            tb_playertwo.Name = "tb_playertwo";
            tb_playertwo.Size = new Size(100, 33);
            tb_playertwo.TabIndex = 7;
            // 
            // tb_onepayment
            // 
            tb_onepayment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_onepayment.ForeColor = Color.Black;
            tb_onepayment.Location = new Point(460, 300);
            tb_onepayment.Name = "tb_onepayment";
            tb_onepayment.Size = new Size(100, 33);
            tb_onepayment.TabIndex = 8;
            // 
            // tb_twopayment
            // 
            tb_twopayment.Font = new Font("Segoe UI", 14.25F);
            tb_twopayment.Location = new Point(643, 304);
            tb_twopayment.Name = "tb_twopayment";
            tb_twopayment.Size = new Size(100, 33);
            tb_twopayment.TabIndex = 9;
            // 
            // btn_enter
            // 
            btn_enter.BackColor = Color.Green;
            btn_enter.FlatAppearance.BorderSize = 0;
            btn_enter.FlatStyle = FlatStyle.Flat;
            btn_enter.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_enter.ForeColor = Color.White;
            btn_enter.Location = new Point(666, 406);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(100, 50);
            btn_enter.TabIndex = 10;
            btn_enter.Text = "ENTER";
            btn_enter.UseVisualStyleBackColor = false;
            btn_enter.Click += btn_enter_Click;
            // 
            // btn_Home
            // 
            btn_Home.BackColor = Color.Green;
            btn_Home.FlatAppearance.BorderSize = 0;
            btn_Home.FlatStyle = FlatStyle.Flat;
            btn_Home.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Home.ForeColor = Color.White;
            btn_Home.Location = new Point(470, 406);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(100, 50);
            btn_Home.TabIndex = 12;
            btn_Home.Text = "HOME";
            btn_Home.UseVisualStyleBackColor = false;
            btn_Home.Click += btn_Home_Click;
            // 
            // AddPTForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAYING_MECHANICS;
            ClientSize = new Size(800, 497);
            Controls.Add(btn_Home);
            Controls.Add(btn_enter);
            Controls.Add(tb_twopayment);
            Controls.Add(tb_onepayment);
            Controls.Add(tb_playertwo);
            Controls.Add(tb_playerone);
            Controls.Add(tb_tnumber);
            Controls.Add(lbl_paymenttwo);
            Controls.Add(lbl_paymentone);
            Controls.Add(lbl_playertwo);
            Controls.Add(lbl_playerone);
            Controls.Add(lbl_tnumber);
            Name = "AddPTForm";
            Text = "AddPTForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tnumber;
        private Label lbl_playerone;
        private Label lbl_playertwo;
        private Label lbl_paymentone;
        private Label lbl_paymenttwo;
        private TextBox tb_tnumber;
        private TextBox tb_playerone;
        private TextBox tb_playertwo;
        private TextBox tb_onepayment;
        private TextBox tb_twopayment;
        private Button btn_enter;
        private Button btn_Home;
    }
}