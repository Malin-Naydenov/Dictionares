using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneBook = Console.ReadLine().Split(new char[] { ' ', ':' },StringSplitOptions.RemoveEmptyEntries);

            var newPhoneBook = new SortedDictionary<string, long>();

            while(phoneBook[0] != "Over")
            {
                string name = phoneBook[0];
                string number = phoneBook[1];
                long digit = 0;
                long newNumber = 0;
                if(long.TryParse(name, out digit))
                {
                    newPhoneBook[number] = digit;
                }
                else if ( long.TryParse(number, out newNumber))
                {
                    newPhoneBook[name] = newNumber;
                }

                    phoneBook = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in newPhoneBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
