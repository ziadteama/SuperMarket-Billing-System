using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        readonly Administrator administrator;
        int index_1, index_2;
        public Form2(Administrator X)
        {
            administrator = X;
            InitializeComponent();
            this.Text = "Adminstrator Main";
            WelocmeUser.Text = $"Welcome ! {administrator.Name}";
            var classtype = new List<string> { "Delivery", "Cashier" };
            foreach (var type in classtype)
            {
                comboBox_job.Items.Add(type);
                comboBox_job.SelectedIndex = -1;
                comboBox_job.SelectedIndexChanged += new EventHandler(ComboBoxClasses_SelectedIndexChanged);

            }
            foreach (Person i in Program.persons)
            {
                if (i is not Administrator)
                {
                    comboBox_name.Items.Add(i.Name);
                    comboBox_name.SelectedIndex = -1;
                    comboBox_name.SelectedIndexChanged += new EventHandler(ComboBoxClasses_SelectedIndexChanged2);
                }
            }
            this.WindowState = FormWindowState.Maximized;
        }
        private void ComboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_job.SelectedIndex != -1)
            {
                index_1 = comboBox_job.SelectedIndex;
                label_newpassword.Visible = true;
                textBox_pass.Visible = true;
                button1.Visible = true;
                textboxName.Visible = true;
                Namefora7.Visible = true;
            }

        }
        private void ComboBoxClasses_SelectedIndexChanged2(object sender, EventArgs e)
        {

            if (comboBox_name.SelectedIndex != -1)
            {
                index_2 = comboBox_name.SelectedIndex;
                button2.Visible = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label_position.Visible = true;
            comboBox_job.Visible = true;
            label_newpassword.Visible = false;
            textBox_pass.Visible = false;
            button1.Visible = false;
            comboBox_name.Visible = false;
            label_expenses.Visible = false;
            Proucts_label.Visible = false;
            label_diplay_data.Visible = false;
            button2.Visible = false;

            label1.Visible = false;
            comboBox_name.Visible = false;
            //groupBox1.Visible = true;
            textboxName.Visible = false;
            Namefora7.Visible = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button_fireworker_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            comboBox_name.Visible = true;
            //groupBox1.Visible = false;
            label_position.Visible = false;
            comboBox_job.Visible = false;
            label_newpassword.Visible = false;
            textBox_pass.Visible = false;
            button1.Visible = false;
            label_expenses.Visible = false;
            Proucts_label.Visible = false;
            label_diplay_data.Visible = false;
            button2.Visible = false;
            textboxName.Visible = false;
            Namefora7.Visible = false;
        }

        private void comboBox_job_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string X = textBox_pass.Text;
            try
            {
                if (X.Length < 4)
                {
                    label_errornew.Visible = true;
                    label_errornew.Text = "Too short";
                }
                else
                {
                    Random random = new Random();
                    int num = random.Next(1000, 10000);
                    var person = new Person();
                    switch (index_1)
                    {
                        case 0:
                            {
                                person = person as Delivery;

                                person = new Delivery(num, textBox_pass.Text, textboxName.Text);
                                break;
                            }

                        case 1:
                            {
                                person = person as Cashier;
                                person = new Cashier(num, textBox_pass.Text, textboxName.Text);
                                break;
                            }
                        default: break;
                    }
                    Program.persons.Add(person);
                    MessageBox.Show($"Person Added\n id : {person.id}");
                    Form2 form2 = new Form2(administrator);
                    form2.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Program.persons.Remove(Program.persons.Find(p => p.Name == comboBox_name.Text));
            MessageBox.Show("Worker data is deleted", "Delete");
            comboBox_name.Items.Clear();
            foreach (Person i in Program.persons)
            {
                if (i is not Administrator)
                {
                    comboBox_name.Items.Add(i.Name);
                    comboBox_name.SelectedIndex = -1;
                    comboBox_name.SelectedIndexChanged += new EventHandler(ComboBoxClasses_SelectedIndexChanged2);
                }
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            data form1 = new data();
            form1.Show();
            this.Hide();
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            label_expenses.Visible = true;
            label_position.Visible = false;
            comboBox_job.Visible = false;
            label_newpassword.Visible = false;
            textBox_pass.Visible = false;
            button1.Visible = false;
            comboBox_name.Visible = false;
            Proucts_label.Visible = false;
            label_diplay_data.Visible = false;
            label1.Visible = false;
            comboBox_name.Visible = false;
            button2.Visible = false;
            textboxName.Visible = false;
            Namefora7.Visible = false;

            //groupBox1.Visible = true;
            expenses.SalariesCal(Program.persons);
            label_expenses.Text = expenses.Print(Program.Expenses);
        }

        private void button_display_proudcts_Click(object sender, EventArgs e)
        {
            Proucts_label.Visible = true;
            label_expenses.Visible = false;
            label_position.Visible = false;
            comboBox_job.Visible = false;
            label_newpassword.Visible = false;
            textBox_pass.Visible = false;
            button1.Visible = false;
            comboBox_name.Visible = false;
            label_diplay_data.Visible = false;
            label1.Visible = false;
            comboBox_name.Visible = false;
            button2.Visible = false;
            textboxName.Visible = false;
            Namefora7.Visible = false;

            //groupBox1.Visible = true;
            Proucts_label.Text = Product.DisplayString(Program.products);
        }

        private void button_display_data_Click(object sender, EventArgs e)
        {
            label_diplay_data.Visible = true;
            Proucts_label.Visible = false;
            label_expenses.Visible = false;
            label_position.Visible = false;
            comboBox_job.Visible = false;
            label_newpassword.Visible = false;
            textBox_pass.Visible = false;
            button1.Visible = false;
            comboBox_name.Visible = false;
            label1.Visible = false;
            comboBox_name.Visible = false;
            button2.Visible = false;
            textboxName.Visible = false;
            Namefora7.Visible = false;

            //groupBox1.Visible = true;
            label_diplay_data.Text = Person.display_data(Program.persons);

        }

        private void expenses_Click(object sender, EventArgs e)
        {

        }

        private void label_position_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Proucts_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Namefora7_Click(object sender, EventArgs e)
        {

        }

        private void textBox_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}


