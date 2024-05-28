using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
     class Person
    {
        public string Name { get; set; }
        public double id { get; set; }
        public string password { get; set; }
        DateOnly dateOfhire;
        public DateOnly DateOfHire
        {
            get
            {
                return dateOfhire;
            }
            set
            {
                dateOfhire = value;
            }
        }
        int age;
        public int Age
        {
            get { return age; }
            set
            {
                do
                {
                    if (value > 15 && value < 60)
                        age = value;
                    else
                    {
                        Console.WriteLine("incorrect age input");
                        Console.Write("Age : ");
                        value = int.Parse(Console.ReadLine());
                    }
                } while (value < 15 || value > 60);
            }
        }
        string personalNumber;
        public string PersonalNumber
        {
            get { return personalNumber; }

            set
            {
                string Test1 = value.Substring(0, 1);
                char Test2 = value[2];
                do
                {
                    if (value.Length == 11 && Test1 == "01" && (Test2 == '0' || Test2 == '1' || Test2 == '2' || Test2 == '5'))
                        personalNumber = "+2" + value;
                    else
                    {
                        Console.WriteLine("incorrect Personal number input");
                        Console.Write("Personal number : ");
                        value = Console.ReadLine();
                    }
                } while (value.Length != 11 || Test1 != "01" || (Test2 != '0' && Test2 != '1' && Test2 != '2' && Test2 != '5'));
            }
        }
        string address;
        public string Address { get; set; }
        decimal salaryPerhour;
        public decimal SalaryPerhour { get; set; }
        public string MessagefromBoss { get; set; }
        public void Message(string Mess)   /*message displayed by the administator*/
        {
            MessagefromBoss = Mess;
        }
        public Person() { }
        public Person(string name, double id, string password, DateOnly dateOfHire, int age, string personalNumber, string address, decimal salaryPerhour)
        {
            this.Name = name;
            this.id = id;
            this.password = password;
            DateOfHire = dateOfHire;
            this.age = age;
            this.personalNumber = personalNumber;
            this.address = address;
            this.salaryPerhour = salaryPerhour;
        }
        public Person(double id, string password)
        {
            this.id = id;
            this.password = password;
        }

    }
}
