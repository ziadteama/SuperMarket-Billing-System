namespace WinFormsApp1
{
    partial class Fire_Worker
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
            button_back = new Button();
            button_delete = new Button();
            comboBox1 = new ComboBox();
            label_job = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_back.Location = new Point(12, 402);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 36);
            button_back.TabIndex = 2;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button1_Click;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_delete.Location = new Point(681, 399);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(93, 46);
            button_delete.TabIndex = 3;
            button_delete.Text = "delete";
            button_delete.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(111, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label_job
            // 
            label_job.AutoSize = true;
            label_job.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_job.Location = new Point(12, 63);
            label_job.Name = "label_job";
            label_job.Size = new Size(65, 21);
            label_job.TabIndex = 5;
            label_job.Text = "Position";
            label_job.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 143);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(111, 145);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 7;
            // 
            // Fire_Worker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(label_job);
            Controls.Add(comboBox1);
            Controls.Add(button_delete);
            Controls.Add(button_back);
            Name = "Fire_Worker";
            Text = "Fire_Worker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_back;
        private Button button_delete;
        private ComboBox comboBox1;
        private Label label_job;
        private Label label1;
        private ComboBox comboBox2;
    }
}