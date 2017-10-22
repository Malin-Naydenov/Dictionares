using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShoping
{
    class Neraboti
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stoks = new Dictionary<string, int>();

            var input = Console.ReadLine().Split(' ').ToArray();
            while (input[0] != "exam")
            {


                while (input[0] != "shopping"&& input [0] != "buy")
                {
                    var product = input[1];
                    var element = input[2];
                    var quantity = 0;
                    if (int.TryParse(input[2], out quantity))
                    {
                        if (stoks.ContainsKey(input[1]))
                        {
                            stoks[product] += quantity;
                        }
                        else
                        {
                            stoks.Add(product, quantity);
                        }
                        input = Console.ReadLine().Split(' ').ToArray();
                    }
                }

                while (input[0] == "buy" && input[0] != "shopping")
                {


                    var product = input[1];
                    var element = int.Parse(input[2]);
                    
                    if (!stoks.ContainsKey(product))
                    {
                        Console.WriteLine($"{product} doesn't exist");
                    }
                    else
                    {
                        if (stoks[product] == 0)
                        {
                            Console.WriteLine($"{product} ot of stock");
                        }
                        else if (stoks[product] > 0)
                        {
                            stoks[product] -= element;

                        }
                        else
                        {
                            stoks[product] = 0;
                        }
                    }
                    input = Console.ReadLine().Split(' ').ToArray();
                }
                if (input[0] == "shopping")
                {
                    input = Console.ReadLine().Split(' ').ToArray();
                }
            }
            foreach (var kvp in stoks)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> { kvp.Value}");
                }
            }
        }
    }
}

