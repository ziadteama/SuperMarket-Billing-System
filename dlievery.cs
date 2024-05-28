using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
   

        public class Delivery : Person
        {
        public Delivery(double id, string password, string name) :base(id,password, name)
        {
            
        }

        public Delivery()
            { }
            public Delivery(string name, double id, string password, int age, string personalNumber, string address, decimal salaryPerhour) : base(name, id, password, age, personalNumber, address, salaryPerhour)
            {
            }
            
       /* public void OrderProcessing(Order order) //al messages de 5ra awi ik bs na msh ader at5el 7aga for now 3al GUI
        {
            order.display();   // display the order odamo 3alashan y3mlo
            order.uptadeTheorderPhase();
            Avaliable = false;
            Console.WriteLine("Are you finished ? ");
            bool ans = bool.Parse(Console.ReadLine());
            if (ans == true)
                order.uptadeTheorderPhase();
            Console.WriteLine("did you return to the supermarket ?");
            ans = bool.Parse(Console.ReadLine());
            if (ans == true)
            {
                Avaliable = true;
                if (OrdersToWait.Count != null)
                {
                    order = OrdersToWait.Peek();
                    OrdersToWait.Dequeue();
                    OrderProcessing(order);
                }
            }
        }*/

        /*static public void OrderToWhichOne(Order order, Delivery[] deleveryguy)
        {
            for (int i = 0; i < deleveryguy.Length; i++)
            {
                if (deleveryguy[i].Avaliable == true)
                {
                    deleveryguy[i].OrderProcessing(order);
                    return;
                }
                OrdersToWait.Enqueue(order);
            }*/
        }

    }
