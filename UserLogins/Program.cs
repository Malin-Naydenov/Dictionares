using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> caseWithLogins = new Dictionary<string, string>();

            string[] inputLogin = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
           
            
            while ( inputLogin[0] != "end" && inputLogin[0] != "login")
            {
                string name = inputLogin[0];
                string password = inputLogin[1];

                caseWithLogins[name] = password;
                inputLogin = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            int count = 0;
            if(inputLogin[0] == "login")
            {
                inputLogin = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            while (inputLogin[0] != "end")
            {
                string name = inputLogin[0];
                string password = inputLogin[1];
                if (!caseWithLogins.ContainsKey(inputLogin[0]))
                {
                    Console.WriteLine($"{name}: login failed");
                    count++;
                }
                else
                {
                    if (!caseWithLogins.ContainsValue(inputLogin[1]))
                    {
                        Console.WriteLine($"{name}: login failed");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{name}: logged in successfully");
                    }
                }
                inputLogin = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            if( inputLogin[0] == "end")
            {
                Console.WriteLine($"unsuccessful login attempts: {count}");
            }
        }
    }
}
