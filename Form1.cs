using System.Diagnostics;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "Main Form";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            label_error.BackColor = Color.Transparent;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void log_in_Click(object sender, EventArgs e)
        {
            try
            {
                double idcheck = double.Parse(textBox_id.Text);
                string passcheck = textBox_password.Text;

                var X = Program.persons.Find(p => p.id == idcheck);
                if (X == null)
                {
                    label_error.Text = "undefined id";
                    label_error.Visible = true;
                }
                else
                {
                    if (X.password != passcheck)
                    {
                        label_error.Text = "incorrect password";
                        label_error.Visible = true;
                    }
                    else
                    {

                        if (X is Administrator)
                        {
                            Form2 secondForm = new Form2(X as Administrator);
                            secondForm.Show();
                            this.Hide();
                        }
                        else
                        if (X is Delivery)
                        {
                            delievery secondForm = new delievery(X as Delivery);
                            secondForm.Show();
                            this.Hide();
                        }
                        else
                            if (X is Cashier)
                        {
                            Form4 Y = new Form4(X as Cashier);
                            Y.Show();
                            this.Hide();
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                label_error.Text = "undefined id";
                label_error.Visible = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_id_Enter(object sender, EventArgs e)
        {
            if (textBox_id.Text == "Enter User Name")
            {
                textBox_id.Text = "";
                textBox_id.ForeColor = Color.Black;
            }
        }

        private void textBox_id_Leave(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                textBox_id.Text = "Enter User Name";
                textBox_id.ForeColor = Color.Silver;
            }
        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {
            if (textBox_password.Text == "Enter Password")
            {
                textBox_password.Text = "";
                textBox_password.ForeColor = Color.Black;
            }
        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            if (textBox_password.Text == "")
            {
                textBox_password.Text = "Enter Password";
                textBox_password.ForeColor = Color.Silver;
            }
        }
    }
}
