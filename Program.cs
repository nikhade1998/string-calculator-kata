using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringcalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "2,5";
            string result = StringCalculator.Sum(input);
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
    }
}
