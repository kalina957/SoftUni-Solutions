using System;
using System.Collections.Generic;

namespace Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
               Sale sale = ReadSale();
                if (!salesByTown.ContainsKey(sale.town))
                {
                    salesByTown[sale.town] = 0;
                }
                salesByTown[sale.town] += (decimal)sale.quantity * sale.price;
            }
            foreach (var sale in salesByTown)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:f2}");
            }
        }

        private static Sale ReadSale()
        {
            string[] input = Console.ReadLine().Split();
            Sale sale = new Sale { town = input[0], product = input[1], price = decimal.Parse(input[2]), quantity = double.Parse(input[3])};
            return sale;
        }

        class Sale
        {
            public string town { get; set; }
            public string product { get; set; }
            public decimal price { get; set; }
            public double quantity { get; set; }
        }
    }
}
