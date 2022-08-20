using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value");
            string val1 = Console.ReadLine();

            Console.WriteLine("Enter second value");
            string val2 = Console.ReadLine();

            string val3 = val2;
            val2 = val1;
            val1 = val3;

            Console.WriteLine("After swapping values: \n variables1 = {0} \n variables2 = {1}", val1, val2);
            Console.ReadLine();



        }
    }
}
