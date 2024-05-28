using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Cashier : Person
    {
        public uint IteminRecipt { get; set; }

        List<Product> Recipt = new List<Product>();
        public Machine machine { get; set; }
        public void Checkout(Product[] products, string productid)
        {

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductName == productid)
                {
                    Recipt.Add(products[i]);
                    IteminRecipt++;
                    products[i].Quantity--;

                }
            }
            Recipt.ToString();
            IteminRecipt = 0;
        }
        public Cashier(double id, string password,string name) : base(id, password,name)
        {

        }
        public Cashier(string Name, double id, string password, int age, string personalNumber, string address, decimal salaryPerhour) : base(Name, id, password, age, personalNumber, address, salaryPerhour) { }

        /*public override string ToString()
        {
            Random rand = new Random();
            string Reciptt = "";
            foreach (Product i in Recipt)
            { Reciptt += "\nProvider Information: " + i.ProviderInfromation + "\nProduct Name: " + i.ProductName + "\nProduct ID: " + i.Product_ID + "\n Price: " + i.SellPrice * i.Quantity; }
            return "Casheir Name: " + Name + "\nCasheir ID" + Id + Reciptt + "Order ID: " + rand.Next(1000000, 9999999) + "\nTotal Items: " + IteminRecipt;
        }*/
      
        public Cashier() { }

    }
}
