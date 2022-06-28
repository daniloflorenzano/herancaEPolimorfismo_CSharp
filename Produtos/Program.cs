using System;
using Produtos.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (type)
                {
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYY): ");
                        DateTime manufatureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufatureDate));
                        break;

                    case 'i':
                        Console.Write("Custom fees: ");
                        double customFees = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customFees));
                        break;

                    default:
                        products.Add(new Product(name, price));
                        break;
                }


            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + " " + product.PriceTag());
            }
        }
    }
}
