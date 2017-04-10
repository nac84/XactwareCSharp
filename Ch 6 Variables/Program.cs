using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_6_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = -50;
            uint uint1 = 42;
            byte byte1 = 12;
            sbyte sbyte1 = -112;
            short short1 = -500;
            ushort ushort1 = 455;
            long long1 = -35000;
            ulong ulong1 = 50000;
            char char1 = 'ñ';
            float float1 = 3.1415926f;
            double double1 = 3.1416589039230;
            decimal decimal1 = 19038560923746;
            bool boolean1 = true;

            Console.WriteLine("These are your variables: ");
            Console.WriteLine("" + int1 + " " + uint1
                + " " + byte1 + " " + sbyte1 + " " + short1 + " " + ushort1
                + " " + long1 + " " + ulong1 + " " + char1 + " " + float1
                + " " + double1 + " " + decimal1 + " " + boolean1 + ".");
            Console.ReadKey();


        }
    }
}
