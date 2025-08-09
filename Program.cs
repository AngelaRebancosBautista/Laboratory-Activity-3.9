using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<string> names = new List<string>();
            List<string> formattedNames = new List<string>();

            Console.WriteLine("Enter 6 full names:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Name {i + 1}: ");
                string name = Console.ReadLine();
                names.Add(name);

                string[] nameParts = name.Split(' ');
                string formattedName = "";

                for (int j = 0; j < nameParts.Length; j++)
                {
                    if (!string.IsNullOrEmpty(nameParts[j]))
                    {
                        string part = nameParts[j].ToLower();
                        part = char.ToUpper(part[0]) + part.Substring(1);
                        formattedName += part + " ";
                    }
                }
                formattedName = formattedName.Trim();
                formattedNames.Add(formattedName);
            }
            Console.WriteLine("\nOriginal Names:");
            Console.WriteLine(string.Join("\n", names));

            Console.WriteLine("\nFormatted Names (Title Case):");
            Console.WriteLine(string.Join("\n", formattedNames));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
        

    
