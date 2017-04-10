using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_7_Remainders
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 31;
            int b = 7;
            int quotient = a / b;
            int remainder = a % b;
            int total = b * quotient + remainder;
            Console.WriteLine(a + "/" + b + " is " + quotient + " remainder " + remainder);
            Console.WriteLine(b + " * " + quotient + " + " + remainder + " = " + total);
            Console.ReadKey();
        }
    }
}
