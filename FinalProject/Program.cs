using FinalProject.Classes;
using FinalProject.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesCollection sales = new SalesCollection();
            SalesPerson drae = sales.AddSalesPerson("Leaundrae", "Developer");
            SalesPerson logan = sales.AddSalesPerson("Logan", "Student");
            SalesPerson adonis = sales.AddSalesPerson("Adonis", "Manager");

            drae.AddSale(500);
            drae.AddSale(450);
            drae.AddSale(300);
            drae.AddSale(200);

            logan.AddSale(150);
            logan.AddSale(250);
            logan.AddSale(800);

            adonis.AddSale(300);
            adonis.AddSale(800);
            adonis.AddSale(200);
            adonis.AddSale(150);

            CreateReport(sales.SalesPeople);
            Console.ReadLine();

        }

        static void CreateReport(List<SalesPerson> salesPeople) 
        {
            double companyTotal = 0.0;
            IEnumerator<SalesPerson> iterPerson = salesPeople.GetEnumerator();

            while (iterPerson.MoveNext())
            {
                SalesPerson person = iterPerson.Current;
                double total = 0.0;
                double sale = 0.0;
                double min = double.MaxValue;
                double max = double.MinValue;
                double avg = 0.0;
                int count = 0;

                IEnumerator<Double> iterSales = person.SalesIterator;
                while (iterSales.MoveNext()) { 
                    sale = iterSales.Current;
                    total += sale;
                    if(sale < min)
                    {
                        min = sale;
                    }
                    if(sale > max)
                    {
                        max = sale;
                    }
                }
                count = person.SalesCollection.Sales.Count;
                avg = total / count;
                companyTotal += total;

                Console.WriteLine($"Sales person: {person.Name}");
                Console.WriteLine($"Total Sales: {total:C}");
                Console.WriteLine($"Min Sales: {min:C}");
                Console.WriteLine($"Max Sales: {max:C}");
                Console.WriteLine($"Average Sales: {avg:C}");
                Console.WriteLine("___________________________________\n");

            }
            Console.WriteLine($"Company total sales: {companyTotal:C}");
        }
    }
}
