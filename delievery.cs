using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class delievery : Form
    {
        Delivery worker;

        public delievery(Delivery X)
        {
            this.WindowState = FormWindowState.Maximized;
            worker = X;
            InitializeComponent();
            if (Program.IsQueueEmpty())
                label_order.Text = "There is no orders";
            else
            {
                label_order.Text = Order.ProductsPrint(Program.OrdersToWait.Peek());
                button_prepaired.Visible = true;
            }
            WelocmeUser.Text = $"Welcome! {worker.Name}";
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button_signout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hidePics()
        {
            pictureBox3.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();

        }

        private void button_prepaired_Click(object sender, EventArgs e)
        {
            button_deilieverd.Visible = true;
            label_deiliver.Visible = true;
            label_deiliver.Text = Order.productsExtra(Program.OrdersToWait.Peek());
            hidePics();
            pictureBox2.Show();

        }

        private void button_deilieverd_Click(object sender, EventArgs e)
        {
            button_return.Visible = true;
            hidePics();
            pictureBox3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.dequeueData();
            delievery form = new delievery(worker);
            form.Show();
            this.Hide();
        }

        private void ReturnToShop_button_Click(object sender, EventArgs e)
        {
            data form1 = new data();
            form1.Show();
            this.Hide();
        }

        private void label_deiliver_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signOutButtonDel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
