using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string");
            string input = Console.ReadLine();

            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The input is a palindrome");
            }

            else
            {
                Console.WriteLine("This s not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
