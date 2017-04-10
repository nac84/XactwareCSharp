using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_8_Cylinders
{
    class Program
    {
        static void Main(string[] args)
        {
            string heightInput, radiusInput;
            Console.WriteLine("Let's build a cylinder!");
            Console.Write("Enter the height: ");
            heightInput = Console.ReadLine();
            float height = Convert.ToSingle(heightInput);
            Console.Write("Enter the radius of the base: ");
            radiusInput = Console.ReadLine();
            float radius = Convert.ToSingle(radiusInput);
            Console.WriteLine("The volumn of the cylinder is " + (3.1415926 * radius * radius * height));
            Console.WriteLine("The surface area of the cylinder is " + (2* 3.1415926 * radius * (radius + height)));
            Console.ReadKey();
        }
    }
}
