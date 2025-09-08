using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszogTeruletSzamitas {
    internal class Program {
        static void Main(string[] args) {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            string mertekEgység = Console.ReadLine();

            double s = (a+b+c)/2;

            Console.WriteLine($"{Math.Round(Math.Sqrt(s*(s-a)*(s-b)*(s-c)),2)} {mertekEgység}2");

        }
    }
}
