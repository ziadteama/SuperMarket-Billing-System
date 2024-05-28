namespace WinFormsApp1
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearButton;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            searchTextBox = new TextBox();
            productsListBox = new ListBox();
            orderListBox = new ListBox();
            addButton = new Button();
            removeButton = new Button();
            clearButton = new Button();
            printReceiptButton = new Button();
            quantityNumericUpDown = new NumericUpDown();
            panel1 = new Panel();
            WelocmeUser = new Label();
            signOutButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.None;
            searchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchTextBox.BackColor = SystemColors.HighlightText;
            searchTextBox.Font = new Font("Segoe UI", 12F);
            searchTextBox.ForeColor = Color.Black;
            searchTextBox.Location = new Point(456, 147);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(364, 34);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // productsListBox
            // 
            productsListBox.Anchor = AnchorStyles.None;
            productsListBox.BackColor = SystemColors.HighlightText;
            productsListBox.Font = new Font("Segoe UI", 14F);
            productsListBox.FormattingEnabled = true;
            productsListBox.ItemHeight = 31;
            productsListBox.Location = new Point(464, 209);
            productsListBox.Name = "productsListBox";
            productsListBox.Size = new Size(356, 500);
            productsListBox.TabIndex = 2;
            // 
            // orderListBox
            // 
            orderListBox.Anchor = AnchorStyles.None;
            orderListBox.BackColor = SystemColors.HighlightText;
            orderListBox.Font = new Font("Segoe UI", 14F);
            orderListBox.FormattingEnabled = true;
            orderListBox.ItemHeight = 31;
            orderListBox.Location = new Point(914, 209);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(356, 500);
            orderListBox.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.BackColor = Color.YellowGreen;
            addButton.Font = new Font("Segoe UI", 16F);
            addButton.Location = new Point(0, 307);
            addButton.Margin = new Padding(3, 3, 3, 8);
            addButton.MaximumSize = new Size(500, 500);
            addButton.Name = "addButton";
            addButton.Size = new Size(261, 75);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.None;
            removeButton.BackColor = Color.Firebrick;
            removeButton.Font = new Font("Segoe UI", 16F);
            removeButton.Location = new Point(0, 388);
            removeButton.Margin = new Padding(3, 3, 3, 8);
            removeButton.MaximumSize = new Size(500, 500);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(261, 75);
            removeButton.TabIndex = 4;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.None;
            clearButton.Font = new Font("Segoe UI", 16F);
            clearButton.Location = new Point(0, 469);
            clearButton.Margin = new Padding(3, 3, 3, 8);
            clearButton.MaximumSize = new Size(500, 500);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(261, 75);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // printReceiptButton
            // 
            printReceiptButton.Anchor = AnchorStyles.None;
            printReceiptButton.BackColor = Color.NavajoWhite;
            printReceiptButton.Font = new Font("Segoe UI", 16F);
            printReceiptButton.Location = new Point(0, 550);
            printReceiptButton.Margin = new Padding(3, 3, 3, 8);
            printReceiptButton.MaximumSize = new Size(500, 500);
            printReceiptButton.Name = "printReceiptButton";
            printReceiptButton.Size = new Size(261, 75);
            printReceiptButton.TabIndex = 4;
            printReceiptButton.Text = "Print Receipt";
            printReceiptButton.UseVisualStyleBackColor = false;
            printReceiptButton.Click += printReceiptButton_Click;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Anchor = AnchorStyles.None;
            quantityNumericUpDown.Location = new Point(1276, 209);
            quantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(46, 27);
            quantityNumericUpDown.TabIndex = 7;
            quantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            quantityNumericUpDown.ValueChanged += quantityNumericUpDown_ValueChanged;
            // 
            // panel1
            // 
            panel1.AccessibleName = "WelcomeUser";
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(WelocmeUser);
            panel1.Controls.Add(signOutButton);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(removeButton);
            panel1.Controls.Add(clearButton);
            panel1.Controls.Add(printReceiptButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 839);
            panel1.TabIndex = 8;
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
            WelocmeUser.Padding = new Padding(0, 8, 0, 0);
            WelocmeUser.Size = new Size(104, 49);
            WelocmeUser.TabIndex = 10;
            WelocmeUser.Text = "label3";
            WelocmeUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.SlateGray;
            signOutButton.Dock = DockStyle.Bottom;
            signOutButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            signOutButton.ForeColor = SystemColors.ButtonHighlight;
            signOutButton.Image = (Image)resources.GetObject("signOutButton.Image");
            signOutButton.Location = new Point(0, 792);
            signOutButton.Margin = new Padding(0, 0, 0, 5);
            signOutButton.Name = "signOutButton";
            signOutButton.Padding = new Padding(40, 0, 0, 0);
            signOutButton.Size = new Size(261, 47);
            signOutButton.TabIndex = 9;
            signOutButton.Text = "Sign out";
            signOutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(401, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(863, 209);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(390, 209);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1444, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 74);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // Form4
            // 
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1543, 839);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(searchTextBox);
            Controls.Add(productsListBox);
            Controls.Add(orderListBox);
            Name = "Form4";
            Text = "Product Manager";
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private NumericUpDown quantityNumericUpDown;
        private Label label2;
        private Panel panel1;
        private Button signOutButton;
        private PictureBox pictureBox1;
        private Label WelocmeUser;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}