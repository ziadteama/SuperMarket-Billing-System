namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label_newpassword = new Label();
            textBox_pass = new TextBox();
            comboBox_job = new ComboBox();
            label_position = new Label();
            button1 = new Button();
            label_errornew = new Label();
            label1 = new Label();
            comboBox_name = new ComboBox();
            button2 = new Button();
            Proucts_label = new Label();
            label_diplay_data = new Label();
            label_expenses = new Label();
            pictureBox1 = new PictureBox();
            button_display = new Button();
            button_fireworker = new Button();
            button_add = new Button();
            signOutButtonDel = new Button();
            button_display_proudcts = new Button();
            button_return = new Button();
            button_display_data = new Button();
            ReturnToShop_button = new Button();
            button3 = new Button();
            panel1 = new Panel();
            WelocmeUser = new Label();
            Namefora7 = new Label();
            textboxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_newpassword
            // 
            label_newpassword.AutoSize = true;
            label_newpassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_newpassword.Location = new Point(322, 205);
            label_newpassword.Name = "label_newpassword";
            label_newpassword.RightToLeft = RightToLeft.Yes;
            label_newpassword.Size = new Size(128, 37);
            label_newpassword.TabIndex = 12;
            label_newpassword.Text = "Password";
            label_newpassword.Visible = false;
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(322, 258);
            textBox_pass.Margin = new Padding(3, 4, 3, 4);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(327, 27);
            textBox_pass.TabIndex = 11;
            textBox_pass.Visible = false;
            textBox_pass.TextChanged += textBox_pass_TextChanged;
            // 
            // comboBox_job
            // 
            comboBox_job.FormattingEnabled = true;
            comboBox_job.Location = new Point(330, 173);
            comboBox_job.Margin = new Padding(3, 4, 3, 4);
            comboBox_job.Name = "comboBox_job";
            comboBox_job.Size = new Size(196, 28);
            comboBox_job.TabIndex = 10;
            comboBox_job.Visible = false;
            comboBox_job.SelectedIndexChanged += comboBox_job_SelectedIndexChanged;
            // 
            // label_position
            // 
            label_position.AutoSize = true;
            label_position.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_position.Location = new Point(322, 92);
            label_position.Name = "label_position";
            label_position.Size = new Size(95, 31);
            label_position.TabIndex = 9;
            label_position.Text = "Position";
            label_position.Visible = false;
            label_position.Click += label_position_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(680, 315);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(107, 79);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click_2;
            // 
            // label_errornew
            // 
            label_errornew.AutoSize = true;
            label_errornew.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_errornew.ForeColor = Color.FromArgb(192, 0, 0);
            label_errornew.Location = new Point(1499, 259);
            label_errornew.Name = "label_errornew";
            label_errornew.Size = new Size(16, 25);
            label_errornew.TabIndex = 14;
            label_errornew.Text = ".";
            label_errornew.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 88);
            label1.Name = "label1";
            label1.Size = new Size(82, 35);
            label1.TabIndex = 15;
            label1.Text = "Name";
            label1.Visible = false;
            // 
            // comboBox_name
            // 
            comboBox_name.FormattingEnabled = true;
            comboBox_name.Location = new Point(330, 159);
            comboBox_name.Margin = new Padding(3, 4, 3, 4);
            comboBox_name.Name = "comboBox_name";
            comboBox_name.Size = new Size(206, 28);
            comboBox_name.TabIndex = 16;
            comboBox_name.Visible = false;
            comboBox_name.SelectedIndexChanged += comboBox_name_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(680, 315);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(107, 77);
            button2.TabIndex = 17;
            button2.Text = "FIRE";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click_1;
            // 
            // Proucts_label
            // 
            Proucts_label.AutoSize = true;
            Proucts_label.Font = new Font("Microsoft Sans Serif", 8F);
            Proucts_label.Location = new Point(343, 27);
            Proucts_label.Name = "Proucts_label";
            Proucts_label.Size = new Size(74, 17);
            Proucts_label.TabIndex = 22;
            Proucts_label.Text = "\"Proudcts\"";
            Proucts_label.Visible = false;
            Proucts_label.Click += Proucts_label_Click;
            // 
            // label_diplay_data
            // 
            label_diplay_data.AutoSize = true;
            label_diplay_data.Font = new Font("Microsoft Sans Serif", 12F);
            label_diplay_data.Location = new Point(343, 27);
            label_diplay_data.Name = "label_diplay_data";
            label_diplay_data.Size = new Size(87, 25);
            label_diplay_data.TabIndex = 24;
            label_diplay_data.Text = "\"display\"";
            label_diplay_data.Visible = false;
            // 
            // label_expenses
            // 
            label_expenses.AutoSize = true;
            label_expenses.Font = new Font("Microsoft Sans Serif", 12F);
            label_expenses.Location = new Point(353, 27);
            label_expenses.Name = "label_expenses";
            label_expenses.Size = new Size(64, 25);
            label_expenses.TabIndex = 25;
            label_expenses.Text = "label2";
            label_expenses.Visible = false;
            label_expenses.Click += expenses_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1330, 616);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // button_display
            // 
            button_display.Font = new Font("Microsoft Sans Serif", 18F);
            button_display.Location = new Point(0, 340);
            button_display.Margin = new Padding(3, 4, 3, 4);
            button_display.Name = "button_display";
            button_display.Size = new Size(298, 65);
            button_display.TabIndex = 18;
            button_display.Text = "Display Expenses";
            button_display.UseVisualStyleBackColor = true;
            button_display.Click += button_display_Click;
            // 
            // button_fireworker
            // 
            button_fireworker.BackColor = Color.Firebrick;
            button_fireworker.Font = new Font("Microsoft Sans Serif", 18F);
            button_fireworker.Location = new Point(0, 481);
            button_fireworker.Margin = new Padding(3, 4, 3, 4);
            button_fireworker.Name = "button_fireworker";
            button_fireworker.Size = new Size(298, 65);
            button_fireworker.TabIndex = 8;
            button_fireworker.Text = "Fire Worker";
            button_fireworker.UseVisualStyleBackColor = false;
            button_fireworker.Click += button_fireworker_Click;
            // 
            // button_add
            // 
            button_add.BackColor = Color.YellowGreen;
            button_add.Font = new Font("Microsoft Sans Serif", 18F);
            button_add.ForeColor = SystemColors.ControlText;
            button_add.Location = new Point(0, 407);
            button_add.Margin = new Padding(3, 4, 3, 4);
            button_add.Name = "button_add";
            button_add.Size = new Size(298, 67);
            button_add.TabIndex = 0;
            button_add.Text = "Add new workers";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button1_Click;
            // 
            // signOutButtonDel
            // 
            signOutButtonDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            signOutButtonDel.BackColor = Color.SlateGray;
            signOutButtonDel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            signOutButtonDel.ForeColor = SystemColors.ButtonHighlight;
            signOutButtonDel.Image = (Image)resources.GetObject("signOutButtonDel.Image");
            signOutButtonDel.Location = new Point(0, 1888);
            signOutButtonDel.Margin = new Padding(0, 0, 0, 7);
            signOutButtonDel.Name = "signOutButtonDel";
            signOutButtonDel.Padding = new Padding(46, 0, 0, 0);
            signOutButtonDel.Size = new Size(298, 63);
            signOutButtonDel.TabIndex = 9;
            signOutButtonDel.Text = "Sign out";
            signOutButtonDel.TextImageRelation = TextImageRelation.ImageBeforeText;
            signOutButtonDel.UseVisualStyleBackColor = false;
            // 
            // button_display_proudcts
            // 
            button_display_proudcts.BackColor = Color.CadetBlue;
            button_display_proudcts.Font = new Font("Microsoft Sans Serif", 18F);
            button_display_proudcts.Location = new Point(3, 552);
            button_display_proudcts.Margin = new Padding(3, 4, 3, 4);
            button_display_proudcts.Name = "button_display_proudcts";
            button_display_proudcts.Size = new Size(291, 65);
            button_display_proudcts.TabIndex = 21;
            button_display_proudcts.Text = "Display Porducts";
            button_display_proudcts.UseVisualStyleBackColor = false;
            button_display_proudcts.Click += button_display_proudcts_Click;
            // 
            // button_return
            // 
            button_return.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_return.BackColor = Color.SlateGray;
            button_return.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_return.ForeColor = SystemColors.ButtonHighlight;
            button_return.Image = (Image)resources.GetObject("button_return.Image");
            button_return.Location = new Point(0, 1756);
            button_return.Margin = new Padding(0, 0, 0, 7);
            button_return.Name = "button_return";
            button_return.Padding = new Padding(46, 0, 0, 0);
            button_return.Size = new Size(298, 63);
            button_return.TabIndex = 28;
            button_return.Text = "Return To Shop";
            button_return.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_return.UseVisualStyleBackColor = false;
            button_return.Visible = false;
            // 
            // button_display_data
            // 
            button_display_data.Font = new Font("Microsoft Sans Serif", 18F);
            button_display_data.Location = new Point(3, 625);
            button_display_data.Margin = new Padding(3, 4, 3, 4);
            button_display_data.Name = "button_display_data";
            button_display_data.Size = new Size(291, 65);
            button_display_data.TabIndex = 23;
            button_display_data.Text = "Display Employee";
            button_display_data.UseVisualStyleBackColor = true;
            button_display_data.Click += button_display_data_Click;
            // 
            // ReturnToShop_button
            // 
            ReturnToShop_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ReturnToShop_button.BackColor = Color.SlateGray;
            ReturnToShop_button.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ReturnToShop_button.ForeColor = SystemColors.ButtonHighlight;
            ReturnToShop_button.Image = (Image)resources.GetObject("ReturnToShop_button.Image");
            ReturnToShop_button.Location = new Point(0, 1825);
            ReturnToShop_button.Margin = new Padding(0, 0, 0, 7);
            ReturnToShop_button.Name = "ReturnToShop_button";
            ReturnToShop_button.Padding = new Padding(46, 0, 0, 0);
            ReturnToShop_button.Size = new Size(298, 63);
            ReturnToShop_button.TabIndex = 29;
            ReturnToShop_button.Text = "Edit Personal Data";
            ReturnToShop_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            ReturnToShop_button.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateGray;
            button3.Dock = DockStyle.Bottom;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 953);
            button3.Margin = new Padding(0, 0, 0, 7);
            button3.Name = "button3";
            button3.Padding = new Padding(46, 0, 0, 0);
            button3.Size = new Size(298, 63);
            button3.TabIndex = 30;
            button3.Text = "Sign out";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.AccessibleName = "WelcomeUser";
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(ReturnToShop_button);
            panel1.Controls.Add(button_display_data);
            panel1.Controls.Add(button_return);
            panel1.Controls.Add(WelocmeUser);
            panel1.Controls.Add(button_display_proudcts);
            panel1.Controls.Add(signOutButtonDel);
            panel1.Controls.Add(button_add);
            panel1.Controls.Add(button_fireworker);
            panel1.Controls.Add(button_display);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 1016);
            panel1.TabIndex = 29;
            // 
            // WelocmeUser
            // 
            WelocmeUser.AccessibleName = "";
            WelocmeUser.AutoSize = true;
            WelocmeUser.Dock = DockStyle.Top;
            WelocmeUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            WelocmeUser.ForeColor = SystemColors.ButtonHighlight;
            WelocmeUser.Location = new Point(0, 0);
            WelocmeUser.Name = "WelocmeUser";
            WelocmeUser.Padding = new Padding(0, 11, 0, 0);
            WelocmeUser.Size = new Size(104, 52);
            WelocmeUser.TabIndex = 10;
            WelocmeUser.Text = "label3";
            WelocmeUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Namefora7
            // 
            Namefora7.AutoSize = true;
            Namefora7.Font = new Font("Segoe UI", 15F);
            Namefora7.Location = new Point(330, 88);
            Namefora7.Name = "Namefora7";
            Namefora7.Size = new Size(82, 35);
            Namefora7.TabIndex = 33;
            Namefora7.Text = "Name";
            Namefora7.Visible = false;
            Namefora7.Click += Namefora7_Click;
            // 
            // textboxName
            // 
            textboxName.Location = new Point(330, 126);
            textboxName.Name = "textboxName";
            textboxName.Size = new Size(324, 27);
            textboxName.TabIndex = 34;
            textboxName.Visible = false;
            textboxName.TextChanged += textboxName_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1745, 1016);
            Controls.Add(textboxName);
            Controls.Add(Namefora7);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label_expenses);
            Controls.Add(label_diplay_data);
            Controls.Add(Proucts_label);
            Controls.Add(button2);
            Controls.Add(comboBox_name);
            Controls.Add(label1);
            Controls.Add(label_errornew);
            Controls.Add(button1);
            Controls.Add(label_newpassword);
            Controls.Add(textBox_pass);
            Controls.Add(comboBox_job);
            Controls.Add(label_position);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label_time;
        private Label label_newpassword;
        private TextBox textBox_pass;
        private ComboBox comboBox_job;
        private Label label_position;
        private Button button1;
        private Label label_errornew;
        private ComboBox comboBox_name;
        private Button button2;
        private Label Proucts_label;
        private Label label_diplay_data;
        private Label label_expenses;
        private PictureBox pictureBox1;
        private Button button_display;
        private Button button_fireworker;
        private Button button_add;
        private Button signOutButtonDel;
        private Button button_display_proudcts;
        private Button button_return;
        private Button button_display_data;
        private Button ReturnToShop_button;
        private Button button3;
        private Panel panel1;
        private Label WelocmeUser;
        private Label Namefora7;
        private TextBox textboxName;
    }
}