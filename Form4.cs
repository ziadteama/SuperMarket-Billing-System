using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class Form4 : Form
    {
        private string username;
        private List<Product> displayedProducts;
        private List<Product> orderProducts;
        private AutoCompleteStringCollection autoCompleteProductNames;

        public Form4(Cashier X)
        {
            InitializeComponent();
            InitializeProducts();
            SetupAutoComplete();
            InitializeNumericUpDown();
            this.WindowState = FormWindowState.Maximized;
            username = X.Name;
            WelocmeUser.Text = $"Welcome ! {username}";

        }

        private void InitializeProducts()
        {
            displayedProducts = new List<Product>();
            orderProducts = new List<Product>();
        }


        private void InitializeNumericUpDown()
        {
            this.quantityNumericUpDown.Minimum = 1;
            this.quantityNumericUpDown.Maximum = 100;  // Set maximum value here
            this.quantityNumericUpDown.Value = 1;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = searchTextBox.Text.ToLower();
            displayedProducts = Program.products.FindAll(p => p.ProductName.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0);
            UpdateProductList(productsListBox, displayedProducts, true);
        }
        private void SetupAutoComplete()
        {
            autoCompleteProductNames = new AutoCompleteStringCollection();
            autoCompleteProductNames.AddRange(Program.products.Select(p => p.ProductName).ToArray());
            searchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchTextBox.AutoCompleteCustomSource = autoCompleteProductNames;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string selectedProductName = (string)productsListBox.SelectedItem;
            Product selectedProduct = Program.products.FirstOrDefault(p => p.ProductName == selectedProductName);
            if (selectedProduct != null)
            {
                var existingOrderProduct = orderProducts.FirstOrDefault(p => p.ProductName == selectedProduct.ProductName);
                if (existingOrderProduct != null)
                {
                    existingOrderProduct.Quantity += (int)quantityNumericUpDown.Value;
                }
                else
                {
                    Product orderProduct = new Product(selectedProduct.ProductName, selectedProduct.ProviderInfromation, 1, selectedProduct.UnitPrice, selectedProduct.SellPrice);
                    orderProducts.Add(orderProduct);
                }
                UpdateProductList(orderListBox, orderProducts, false);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)orderListBox.SelectedItem;
            if (selectedProduct != null)
            {
                orderProducts.Remove(selectedProduct);
                UpdateProductList(orderListBox, orderProducts, false);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            orderProducts.Clear();
            UpdateProductList(orderListBox, orderProducts, false);
        }

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)orderListBox.SelectedItem;
            if (selectedProduct != null)
            {
                selectedProduct.Quantity = (int)quantityNumericUpDown.Value;
                UpdateProductList(orderListBox, orderProducts, false);
            }
        }
        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            if (orderProducts.Count == 0)
            {
                MessageBox.Show("No items in the order.");
                return;
            }

            StringBuilder receiptBuilder = new StringBuilder();
            receiptBuilder.AppendLine("Receipt:");
            receiptBuilder.AppendLine("------------------------------");
            foreach (var product in orderProducts)
            {
                receiptBuilder.AppendLine($"{product.ProductName} - Quantity: {product.Quantity} - Price: {product.SellPrice:C}");
            }
            receiptBuilder.AppendLine("------------------------------");
            receiptBuilder.AppendLine($"Total: {orderProducts.Sum(p => p.SellPrice * p.Quantity):C}");

            MessageBox.Show(receiptBuilder.ToString(), "Receipt");
        }

        private void UpdateProductList(ListBox listBox, List<Product> products, bool displayNamesOnly)
        {
            listBox.DataSource = null;
            if (displayNamesOnly)
            {
                listBox.DataSource = products.Select(p => p.ProductName).ToList();
            }
            else
            {
                listBox.DataSource = products;
            }
        }
        private void ReturnToShop_button_Click(object sender, EventArgs e)
        {
            data form1 = new data();
            form1.Show();
            this.Hide();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Form1 x = new();
            x.Show();
            this.Hide();
        }
    }
}