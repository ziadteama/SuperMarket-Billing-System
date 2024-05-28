using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Order
    {
        public string[] productname { get; set; }
        public int[] Quantity { get; set; }

        protected string OrderID { get; set; }
        private readonly string username;
        public  string DeliveryAddress { get; set; }
        public string PaymentInformtion { get; set; }
        public Order(string username, string[] productNames, int[] quantities, string deliveryAddress, string paymentInformation)
        {
            Random x = new Random();
            this.username = username;
            this.OrderID = x.Next(1000000, 9999999).ToString();
            productname = new string[productNames.Length];
            Quantity = new int[quantities.Length];
            Array.Copy(productNames, productname, productNames.Length);
            Array.Copy(quantities, Quantity, quantities.Length);
            this.DeliveryAddress = deliveryAddress;
            PaymentInformtion = paymentInformation;
        }
        public static string ProductsPrint(Order X)
        {
            string Product= "------------PRODUCT DETAILS------------\n";
            for(int i=0;i< X.productname.Length;i++)
            {
                Product+=$"Name : {X.productname[i]}\n" +
                    $"Quantity : {(X.Quantity[i])}\n\n";
            }
            return Product;
        }
        public static string productsExtra(Order X)
        {
            return $"------------DELIVERY DETAILS------------\n" +
                $"Address : {X.DeliveryAddress}\n Payment : {X.PaymentInformtion}\n User Name : {X.username}\n";
        }
    }
}
