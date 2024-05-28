using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public static class Program
    {
        static public int T_S=0;
        static public List<Product> products = new List<Product>
{
    new Product("Milk", "DairyLand Farms", 100, 1.20f, 1.50f),
    new Product("Bread", "Baker's Delight", 150, 0.80f, 1.20f),
    new Product("Eggs", "FarmFresh", 200, 2.50f, 3.00f),
    new Product("Apples", "FruitOrchards", 300, 0.50f, 0.80f),
    new Product("Chicken Breast", "Poultry Farms", 75, 5.00f, 6.50f),
    new Product("Orange Juice", "Citrus Delight", 120, 2.00f, 2.50f),
    new Product("Cheese", "DairyDeluxe", 90, 3.00f, 4.00f),
    new Product("Cereal", "Healthy Start", 100, 2.50f, 3.50f),
    new Product("Yogurt", "Creamy Goodness", 80, 1.00f, 1.50f),
    new Product("Pasta", "Italian Treats", 150, 1.50f, 2.00f),
    new Product("Butter", "DairyLand Farms", 50, 2.00f, 2.50f),
    new Product("Bananas", "Tropical Farms", 200, 0.30f, 0.60f),
    new Product("Tomatoes", "Green Valley", 180, 0.70f, 1.00f),
    new Product("Carrots", "Root Farms", 150, 0.40f, 0.70f),
    new Product("Onions", "Harvest Fields", 130, 0.30f, 0.60f),
    new Product("Potatoes", "Harvest Fields", 200, 0.20f, 0.50f),
    new Product("Peanut Butter", "Nutty Delight", 60, 3.00f, 4.00f),
    new Product("Jam", "Berry Goodness", 80, 2.50f, 3.50f),
    new Product("Sugar", "Sweet Co.", 100, 1.00f, 1.50f),
    new Product("Salt", "Mineral Essentials", 120, 0.50f, 1.00f),
    new Product("Pepper", "Spice World", 80, 1.50f, 2.00f),
    new Product("Rice", "Grain Farmers", 150, 1.00f, 1.50f),
    new Product("Flour", "Baker's Best", 140, 1.20f, 1.80f),
    new Product("Pasta Sauce", "Italian Delight", 100, 2.00f, 2.50f),
    new Product("Olive Oil", "Mediterranean Gold", 60, 5.00f, 7.00f),
    new Product("Canned Beans", "Bean Brothers", 200, 0.80f, 1.20f),
    new Product("Canned Tuna", "Ocean Fresh", 150, 1.50f, 2.00f),
    new Product("Ketchup", "Tomato Delight", 100, 1.00f, 1.50f),
    new Product("Mustard", "Spicy Essentials", 90, 0.80f, 1.20f),
    new Product("Mayonnaise", "Creamy Spread", 70, 2.00f, 2.50f),
    new Product("Pickles", "Briny Goodness", 80, 1.50f, 2.00f),
    new Product("Frozen Pizza", "Quick Bites", 120, 4.00f, 5.50f),
    new Product("Ice Cream", "Sweet Treats", 100, 3.00f, 4.50f),
    new Product("Frozen Vegetables", "Green Freezers", 150, 1.50f, 2.00f),
    new Product("Ground Beef", "Prime Meats", 80, 4.00f, 5.50f),
    new Product("Sausages", "Meaty Bites", 90, 3.50f, 4.50f),
    new Product("Bacon", "Smoky Delights", 70, 3.00f, 4.00f),
    new Product("Ham", "Deli Fresh", 60, 2.50f, 3.50f),
    new Product("Chicken Nuggets", "Golden Crisps", 110, 3.00f, 4.00f),
    new Product("Fish Fillets", "Ocean Catch", 100, 5.00f, 6.50f),
    new Product("Shrimp", "Sea Harvest", 90, 6.00f, 8.00f),
    new Product("Lettuce", "Fresh Greens", 150, 0.80f, 1.20f),
    new Product("Bell Peppers", "Colorful Harvest", 130, 1.00f, 1.50f),
    new Product("Cucumbers", "Green Crunch", 120, 0.50f, 1.00f)

};

        static public List<Person> persons = new List<Person>
         {
             new Administrator("Farah", 1234, "FarahLabib", 30, "0101234567890", "Apartment 69H", 25.00m),
         new Delivery("Ziad", 4567, "password2", 25, "0101234567890", "234 Street B", 15.00m),
         new Cashier("Youssef", 7890, "password3", 28, "0101234567890", "345 Street C", 20.00m),
         new Administrator("Ahmed", 2345, "password4", 35, "0101234567890", "456 Street D", 27.50m),
         new Cashier("Sara", 5678, "password5", 22, "0101234567890", "567 Street E", 14.00m),
         new Cashier("Amira", 6789, "password8", 29, "0101234567890", "890 Street H", 16.50m),
         new Delivery("Khalid", 9012, "password9", 34, "0101234567890", "901 Street I", 19.00m),
         };
        static public Queue<Order> OrdersToWait = new Queue<Order>();
        public static void EnqueueData(Order order)
        {
            OrdersToWait.Enqueue(order);
        }
        public static void dequeueData()
        {
            OrdersToWait.Dequeue();
        }
        public static bool IsQueueEmpty()
        {
            return OrdersToWait.Count == 0;
        }
        static public expenses Expenses = new expenses(12, 20, 90, 180, 234, 421, 234, 809, 145, 199);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Order order1 = new Order("Khalifa", new string[] { "Milk", "Break", "Eggs" }, new int[] { 1, 2, 1 }, "abq,new mexico", "Visa");
            Order order2 = new Order("Teama", new string[] { "Eggs", "Yogurt", "Chicken Breast" }, new int[] { 3, 9, 7 }, "tea,new zealand", "Cash");
            Program.EnqueueData(order1);
            Program.EnqueueData(order2);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form3());
        }
    }
}