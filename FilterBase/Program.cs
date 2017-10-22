using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputDate = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, string> position = new Dictionary<string, string>();
            Dictionary<string, int> age = new Dictionary<string, int>();
            Dictionary<string, double> salary = new Dictionary<string, double>();
            int ageOfPeople = 0;
            double salaryOfPeople = 0;
            while (inputDate[0] != "filter")
            {
                string name = inputDate[0];
                string date = inputDate[1]; 
                if (int.TryParse(date, out ageOfPeople))
                {
                    age[name] = ageOfPeople;
                }
                else if (double.TryParse(date, out salaryOfPeople))
                {
                    salary[name] = salaryOfPeople;
                }
                else
                {
                    position[name] = date;
                }
                inputDate = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            
            if (inputDate[0] == "filter")
            {
                inputDate = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string command = inputDate[0];
                 if (command == "Position")
                {
                    foreach (var kvp in position)
                    {
                        Console.WriteLine($"Name: {kvp.Key}" );
                        Console.WriteLine($"Position: {kvp.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                }
                else if (command == "Age")
                {
                    foreach (var kvp in age)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Age: {kvp.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                }
                else if (command == "Salary")
                {
                    foreach (var kvp in salary)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Salary: {kvp.Value:f2}");
                        Console.WriteLine(new string('=', 20));
                    }
                }
            }
        }
    }
}
