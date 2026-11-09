using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematikaiKozepek {
    internal class Program {
        static void Main(string[] args) {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(harmonicMean(a,b,c));
            Console.WriteLine(mertaniMean(a,b,c));
            Console.WriteLine(numericalMean(a,b,c));
            Console.WriteLine(squareMean(a,b,c));
        }

        static double harmonicMean(double a, double b, double c) {
            return (3 / ((1 / a) + (1/b) + (1/c)));
        }

        static double mertaniMean(double a, double b, double c) {
            return Math.Pow(a * b * c, 1.0 / 3.0);
        }

        static double numericalMean(double a,double b, double c) {
            return ((a + b + c) / 3);
        }

        static double squareMean(double a, double b, double c) {
            return Math.Sqrt((a * a + b * b + c * c) / 3);
        }
    }
}
