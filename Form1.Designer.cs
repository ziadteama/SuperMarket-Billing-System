namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox_password = new TextBox();
            log_in = new Button();
            label_error = new Label();
            textBox_id = new TextBox();
            SuspendLayout();
            // 
            // textBox_password
            // 
            textBox_password.Anchor = AnchorStyles.None;
            textBox_password.Font = new Font("Segoe UI", 20F);
            textBox_password.ForeColor = Color.Silver;
            textBox_password.Location = new Point(525, 561);
            textBox_password.Margin = new Padding(3, 4, 3, 4);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(502, 52);
            textBox_password.TabIndex = 3;
            textBox_password.Text = "Enter Password";
            textBox_password.TextChanged += textBox2_TextChanged;
            textBox_password.Enter += textBox_password_Enter;
            textBox_password.Leave += textBox_password_Leave;
            // 
            // log_in
            // 
            log_in.Anchor = AnchorStyles.None;
            log_in.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_in.Image = (Image)resources.GetObject("log_in.Image");
            log_in.ImageAlign = ContentAlignment.MiddleLeft;
            log_in.Location = new Point(703, 669);
            log_in.Margin = new Padding(57, 4, 57, 4);
            log_in.Name = "log_in";
            log_in.Padding = new Padding(11, 7, 11, 7);
            log_in.Size = new Size(140, 67);
            log_in.TabIndex = 4;
            log_in.Text = "log in";
            log_in.TextImageRelation = TextImageRelation.ImageBeforeText;
            log_in.UseVisualStyleBackColor = true;
            log_in.Click += log_in_Click;
            // 
            // label_error
            // 
            label_error.Anchor = AnchorStyles.None;
            label_error.AutoSize = true;
            label_error.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_error.ForeColor = Color.FromArgb(192, 0, 0);
            label_error.Location = new Point(715, 623);
            label_error.Name = "label_error";
            label_error.Size = new Size(32, 41);
            label_error.TabIndex = 5;
            label_error.Text = "..";
            label_error.Visible = false;
            label_error.Click += label_error_Click;
            // 
            // textBox_id
            // 
            textBox_id.Anchor = AnchorStyles.None;
            textBox_id.Font = new Font("Segoe UI", 20F);
            textBox_id.ForeColor = Color.Silver;
            textBox_id.Location = new Point(525, 464);
            textBox_id.Margin = new Padding(3, 4, 3, 4);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(502, 52);
            textBox_id.TabIndex = 7;
            textBox_id.Text = "Enter User Name";
            textBox_id.Enter += textBox_id_Enter;
            textBox_id.Leave += textBox_id_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1542, 1171);
            Controls.Add(textBox_id);
            Controls.Add(label_error);
            Controls.Add(log_in);
            Controls.Add(textBox_password);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "..";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Password;
        private TextBox textBox_password;
        private Button log_in;
        private Label label_error;
        private Label UserId;
        private TextBox textBox_id;
    }
}
