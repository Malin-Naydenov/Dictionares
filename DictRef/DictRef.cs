using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRef
{
    class DictRef
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '=' },StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> listOfdigit = new Dictionary<string, int>();

            while(input[0] != "end")
            {
                string name = input[0];
                string digit = input[1];

                int number = 0;
                if (int.TryParse(digit, out number))
                {
                    listOfdigit[name] = number;
                }
                else
                {
                    if(listOfdigit.ContainsKey(digit))
                    {
                        listOfdigit[name] = listOfdigit[digit];
                    }
                }


                input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var kvp  in listOfdigit)
            {

            Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
