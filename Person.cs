using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Person : WorkSchedule
    {
        public string Name { get; set; }
        public double id { get; set; }
        public string password { get; set; }
      
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
        public string PersonalNumber { set { personalNumber = value; } get { return personalNumber; } }

        string address;
        public string Address { get; set; }
        decimal salaryPerhour;
        public decimal SalaryPerhour { get; set; }

        public Person() { }
        public Person(double id,string password,string name)
        {
            this.id
                = id;
            this.password = password;
            this.Name = name;

        }
        public Person(string name, double id, string password, int age, string personalNumber, string address, decimal salaryPerhour) 
        {
            this.Name = name;
            this.id = id;
            this.password = password;
            this.age = age;
            this.personalNumber = personalNumber;
            Address = address;
            SalaryPerhour = salaryPerhour;
        }
        public Person(bool[] days) : base(days)
        { }
        public static String display_data(List<Person>person)
        {
            string X = "";
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i] is not Administrator)
                {
                    X += $"Name : {person[i].Name}\nAddress : {person[i].Address}\nAge : {person[i].Age}\nPersonal Number : {person[i].PersonalNumber}\nid : {person[i].id}\nsalaryPerhour : {person[i].SalaryPerhour}\npassword:{person[i].password}\n\n";
                }


            }
            return X;

        }


    }
}