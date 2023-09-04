using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MixLibrary;

namespace PortfolioTask3App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Hello!\nPlease enter Two Numbers\na: 2");
            //do
            //{
            //    a = MixLibrary.Read.ReadInteger();
            //    a = MixLibrary.Validate.ValidateInt(a);
            //    MixLibrary.Validate.ValidationIntMessage(a);
            //} while (a < 0);
            a = 2;
            Console.WriteLine("b: 1");
            //do
            //{
            //    b = MixLibrary.Read.ReadInteger();
            //    b = MixLibrary.Validate.ValidateInt(b);
            //    MixLibrary.Validate.ValidationIntMessage(b);
            //} while (b < 0);
            b = 1;
            Console.WriteLine("This is the result of the sum of a and b: " + MixLibrary.Calculation.Add(a, b));
            Console.WriteLine("This is the result of the substraction of a and b: " + MixLibrary.Calculation.Sub(a, b));
            Console.ReadKey();
        }
    }
}
