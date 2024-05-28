using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Administrator : Person
    {
       
        public Administrator(string name, double id, string password, int age, string personalNumber, string address, decimal salaryPerhour) : base(name, id, password, age, personalNumber, address, salaryPerhour)
        { }
    
    }
}
