using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputWords = input.ToCharArray();

            var result = new Dictionary<char, int>();

            foreach (var word in inputWords)
            {
                if(!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }

            foreach(var kvp in result)
            {
                Console.WriteLine($" {kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
