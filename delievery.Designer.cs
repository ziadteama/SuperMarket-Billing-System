namespace WinFormsApp1
{
    partial class delievery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delievery));
            label_order = new Label();
            button_prepaired = new Button();
            button_deilieverd = new Button();
            label_deiliver = new Label();
            panel1 = new Panel();
            button_return = new Button();
            WelocmeUser = new Label();
            signOutButtonDel = new Button();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_order
            // 
            label_order.AutoSize = true;
            label_order.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_order.Location = new Point(305, 141);
            label_order.Name = "label_order";
            label_order.Size = new Size(209, 50);
            label_order.TabIndex = 22;
            label_order.Text = "\"Prepaired\"";
            label_order.TextAlign = ContentAlignment.MiddleCenter;
            label_order.Click += label1_Click;
            // 
            // button_prepaired
            // 
            button_prepaired.Font = new Font("Segoe UI", 14F);
            button_prepaired.Location = new Point(1038, 141);
            button_prepaired.Margin = new Padding(3, 4, 3, 4);
            button_prepaired.Name = "button_prepaired";
            button_prepaired.Size = new Size(176, 83);
            button_prepaired.TabIndex = 23;
            button_prepaired.Text = "Prepared";
            button_prepaired.UseVisualStyleBackColor = true;
            button_prepaired.Visible = false;
            button_prepaired.Click += button_prepaired_Click;
            // 
            // button_deilieverd
            // 
            button_deilieverd.Font = new Font("Segoe UI", 14F);
            button_deilieverd.Location = new Point(1038, 271);
            button_deilieverd.Margin = new Padding(3, 4, 3, 4);
            button_deilieverd.Name = "button_deilieverd";
            button_deilieverd.Size = new Size(176, 79);
            button_deilieverd.TabIndex = 25;
            button_deilieverd.Text = "Delivered";
            button_deilieverd.UseVisualStyleBackColor = true;
            button_deilieverd.Visible = false;
            button_deilieverd.Click += button_deilieverd_Click;
            // 
            // label_deiliver
            // 
            label_deiliver.AutoSize = true;
            label_deiliver.Font = new Font("Segoe UI", 21.75F);
            label_deiliver.Location = new Point(1038, 409);
            label_deiliver.Name = "label_deiliver";
            label_deiliver.Size = new Size(170, 50);
            label_deiliver.TabIndex = 26;
            label_deiliver.Text = "\"deiliver\"";
            label_deiliver.TextAlign = ContentAlignment.MiddleCenter;
            label_deiliver.Visible = false;
            label_deiliver.Click += label_deiliver_Click;
            // 
            // panel1
            // 
            panel1.AccessibleName = "WelcomeUser";
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(button_return);
            panel1.Controls.Add(WelocmeUser);
            panel1.Controls.Add(signOutButtonDel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 1068);
            panel1.TabIndex = 28;
            // 
            // button_return
            // 
            button_return.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_return.BackColor = Color.SlateGray;
            button_return.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_return.ForeColor = SystemColors.ButtonHighlight;
            button_return.Image = (Image)resources.GetObject("button_return.Image");
            button_return.Location = new Point(0, 936);
            button_return.Margin = new Padding(0, 0, 0, 7);
            button_return.Name = "button_return";
            button_return.Padding = new Padding(46, 0, 0, 0);
            button_return.Size = new Size(298, 63);
            button_return.TabIndex = 28;
            button_return.Text = "Return To Shop";
            button_return.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_return.UseVisualStyleBackColor = false;
            button_return.Visible = false;
            button_return.Click += button1_Click;
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
            // signOutButtonDel
            // 
            signOutButtonDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            signOutButtonDel.BackColor = Color.SlateGray;
            signOutButtonDel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            signOutButtonDel.ForeColor = SystemColors.ButtonHighlight;
            signOutButtonDel.Image = (Image)resources.GetObject("signOutButtonDel.Image");
            signOutButtonDel.Location = new Point(0, 1005);
            signOutButtonDel.Margin = new Padding(0, 0, 0, 7);
            signOutButtonDel.Name = "signOutButtonDel";
            signOutButtonDel.Padding = new Padding(46, 0, 0, 0);
            signOutButtonDel.Size = new Size(298, 63);
            signOutButtonDel.TabIndex = 9;
            signOutButtonDel.Text = "Sign out";
            signOutButtonDel.TextImageRelation = TextImageRelation.ImageBeforeText;
            signOutButtonDel.UseVisualStyleBackColor = false;
            signOutButtonDel.Click += signOutButtonDel_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1543, 0);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 99);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(298, 935);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1357, 133);
            panel2.TabIndex = 30;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1245, 8);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(167, 121);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(711, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 121);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, -4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // delievery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1655, 1068);
            Controls.Add(panel2);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Controls.Add(label_deiliver);
            Controls.Add(button_deilieverd);
            Controls.Add(button_prepaired);
            Controls.Add(label_order);
            Margin = new Padding(3, 4, 3, 4);
            Name = "delievery";
            Text = "delievery";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button signOutButtonDel;
        private Label label_order;
        private Button button_prepaired;
        private Button button_deilieverd;
        private Label label_deiliver;
        private Panel panel1;
        private Label WelocmeUser;
        private Button button_return;
        private Button ReturnToShop_button;
        private PictureBox pictureBox4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}