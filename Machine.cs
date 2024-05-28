using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Machine
    {
        List<Product> Recipt;
        uint IteminRecipt = 0;
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

        public override string ToString()
        {
            Random rand = new Random();
            string Reciptt = "";
            foreach (Product i in Recipt)
            { Reciptt += "\nProvider Information: " + i.ProviderInfromation + "\nProduct Name: " + i.ProductName  + "\n Price: " + i.SellPrice * i.Quantity; }
            return Reciptt + "Order ID: " + rand.Next(1000000, 9999999) + "\nTotal Items: " + IteminRecipt;
        }
    }
}
