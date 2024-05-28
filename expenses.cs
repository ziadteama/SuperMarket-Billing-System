using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class expenses
    {
        public static decimal TotalSales { get; set; }
        public decimal Interest_Income { get; set; }
        public decimal Dividend_Income { get; set; }
        public decimal Rental_Income { get; set; }
        public decimal Royalties { get; set; }
        public decimal Government_Grants { get; set; }
        public static decimal Salaries { get; set; }
        public decimal Rent { get; set; }
        public decimal Utilities { get; set; }
        public decimal OfficeSupplies { get; set; }
        public decimal EmployeeBenefits { get; set; }
        public decimal MarketingAndAdvertising { get; set; }

        public expenses(decimal interestIncome, decimal dividendIncome, decimal rentalIncome, decimal royalties, decimal governmentGrants, decimal rent, decimal utilities, decimal officeSupplies, decimal employeeBenefits, decimal marketingAndAdvertising)
        {
            Interest_Income = interestIncome;
            Dividend_Income = dividendIncome;
            Rental_Income = rentalIncome;
            Royalties = royalties;
            Government_Grants = governmentGrants;
            Rent = rent;
            Utilities = utilities;
            OfficeSupplies = officeSupplies;
            EmployeeBenefits = employeeBenefits;
            MarketingAndAdvertising = marketingAndAdvertising;
            TotalSales = 0;
        }
        public static void Total_sales(decimal x)
        {
            TotalSales += x;
        }
        public static decimal SalariesCal(List<Person> persons)
        {
            Salaries = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                Salaries += (persons[i].SalaryPerhour * persons[i].Hours);
            }
            return Salaries;
           
        }
        public static string Print(expenses expense)
        {
            string X = "";
            X += $"Expenses Interest Income: {expense.Interest_Income}\nDividend Income : {expense.Dividend_Income}\nRental Income : {expense.Rental_Income}\nRoyalties:{expense.Royalties}\n Total Revenue : {expenses.TotalRevenue(expense)}\nRent: {expense.Rent}\nUtilities : {expense.Utilities}\nOffice Supplies : {expense.OfficeSupplies}\nEmployee Benefits : {expense.EmployeeBenefits}\nMarketing And Advertising : {expense.MarketingAndAdvertising}\nSalaries: {expense.Government_Grants}\nTotal Sales: {expenses.TotalExpense(expense)}\n\n Profit : {expenses.Profit(expense)}";
            return X;
        }
        public static decimal TotalRevenue(expenses Expenses)
        {
            return TotalSales + Expenses.Interest_Income + Expenses.Dividend_Income + Expenses.Rental_Income + Expenses.Royalties + Expenses.Government_Grants;
        }
        public static decimal TotalExpense(expenses Expenses)
        {
            return Salaries + Expenses.Rent + Expenses.Utilities + Expenses.OfficeSupplies + Expenses.EmployeeBenefits + Expenses.MarketingAndAdvertising;
        }
        public static decimal Profit(expenses Expenses)
        {
            return expenses.TotalRevenue(Expenses) - expenses.TotalExpense(Expenses);
        }
    }
}
