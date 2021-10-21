using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two-digit_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two-digit Comparison");
            Console.WriteLine(" ");
            Console.Write("First number: ");
            int bil1 = int.Parse (Console.ReadLine());

            Console.Write("Second number: ");
            int bil2 = int.Parse (Console.ReadLine());

            Console.WriteLine(" ");

            if (bil1 > bil2)
            {
                Console.WriteLine(bil1 + " > " + bil2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The first number is greater than the second number.");
            }

            else if (bil1 < bil2)
            {
                Console.WriteLine(bil1 + " < " + bil2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The first number is smaller than the second number.");
            }

            else if (bil1 == bil2)
            {
                Console.WriteLine(bil1 + " = " + bil2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The first number is the same as the second number.");
            }

            Console.ReadKey();
        }
    }
}
