using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ExamShopping
{
    class ExamShopping
    {
        static void Main()
        {
            Dictionary<string, int> stocks = new Dictionary<string, int>();

            var input = Console.ReadLine()
                .Split(' ')
                .ToList();


            while (input[0] != "shopping")
            {

                var product = input[1];
                string lastElement = input[2];
                int quantity = 0;
                if (int.TryParse(lastElement, out quantity))
                {
                    if (!stocks.ContainsKey(product))
                    {
                        stocks.Add(product, quantity);
                    }
                    else
                    {
                        stocks[product] += quantity;
                    }
                }
                input = Console.ReadLine()
                   .Split(' ')
                   .ToList();
            }

            input = Console.ReadLine()
                .Split(' ')
                .ToList();

            while (input[0] != "exam")
            {
                string product = input[1];
                int quantity = int.Parse(input[2]);

                if (!stocks.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (stocks[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }

                    if (stocks[product] <= quantity)
                    {
                        stocks[product] = 0;
                    }
                    else
                    {
                        stocks[product] -= quantity;
                    }
                }
                input = Console.ReadLine()
                    .Split(' ')
                    .ToList();
            }
            foreach (var kvp in stocks)
            {
                string key = kvp.Key;
                int value = kvp.Value;
                if (value != 0)
                {
                    Console.WriteLine($"{key} -> {value}");
                }
            }
        }
    }
}