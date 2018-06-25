using System;
using System.Collections.Generic;
using System.Linq;

namespace Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> ProductsPrices = new Dictionary<string, decimal>();
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string product = input[0];
                decimal price = decimal.Parse(input[1]);
                ProductsPrices[product] = price;
            }

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end of clients")
                {
                    break;
                }
                string[] input = inputLine.Split(new char[] { ',', '-' }, StringSplitOptions.None);
                string name = input[0];
                string product = input[1];
                int quantity = int.Parse(input[2]);

                if (ProductsPrices.ContainsKey(product))
                {
                    var customerShopList = new Dictionary<string, int>();
                    customerShopList.Add(product, quantity);
                    decimal customerBill = ProductsPrices[product] * quantity;

                    Customer customer = new Customer { Name = name, ShopList = customerShopList, Bill = customerBill };

                    if (customers.Any(x => x.Name == name))
                    {
                        var currentCustomer = customers.First(x => x.Name == name);

                        if (currentCustomer.ShopList.ContainsKey(product))
                        {
                            currentCustomer.ShopList[product] += quantity;
                            currentCustomer.Bill += ProductsPrices[product] * quantity;
                        }
                        else
                        {
                            currentCustomer.ShopList[product] = quantity;
                            currentCustomer.Bill += ProductsPrices[product] * quantity;
                        }
                    }
                    else
                    {
                        customers.Add(customer);
                    }
                }
            }
                foreach (Customer customer in customers.OrderBy(x => x.Name))
                {
                    Console.WriteLine(customer.Name);

                    foreach (var item in customer.ShopList)
                    {
                        Console.WriteLine($"-- {item.Key} - {item.Value}");
                    }
                    Console.WriteLine($"Bill: {customer.Bill:f2}");
                }
                Console.WriteLine($"Total bill: {customers.Sum(x => x.Bill):f2}");

            }
        }
    
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShopList { get; set; }
            public decimal Bill { get; set; }
        }
    }

