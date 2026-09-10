using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmeltDigKultCuccok {
    internal class Program {
        static void Main(string[] args) {
            (double kerulet, double terulet) = Rectangle(8, 5);
            Console.WriteLine($"Kerulet {kerulet} Terulet{terulet}");
            (double atmero, double keruletKor, double terlet) = Circle(5);
            Console.WriteLine($"Atmero {atmero} Kerulet {keruletKor} Terulet {terlet}");
            (double KeruletTriangle, double TeruletTriangle) = Triangle(3, 4, 5);
            Console.WriteLine($"Kerulet {KeruletTriangle} Terulet {TeruletTriangle}");
            Console.WriteLine($"Háromszög Magasság {TriangleHeight(6)}");
            (double lapAtlo, double testAtlo) = Cube(5);
            Console.WriteLine($"lap Atlo {lapAtlo} test Atlo {testAtlo}");
            Console.WriteLine(NameFusion("Pusztai","Attila"));
            Console.WriteLine(IsEven(4));
            Console.WriteLine(DecidingNumber(5));
            Console.WriteLine(WaterCheck(50));
            Console.WriteLine(SzerkeszthetoHaromszog(5,3,4));
            Console.WriteLine(FahrenheitToCelsius(4));
            Console.WriteLine(CelsiusToFahrenheit(30));
            Console.WriteLine(TimeChecking(3672));
        }
        static (double,double) Rectangle(double a,double b) {
            return (2 * (a + b), a * b);
        }
        static (double,double,double) Circle(double r) {
            return (2 * r, 2 * Math.PI * r, Math.PI * r*r);
        }
        static (double,double) Triangle(double a, double b, double c) {
            double s = (a + b + c) / 2;
            double terulet = Math.Sqrt((s * (s - a) * (s - b) * (s - c)));
            return (a + b + c, terulet);
        }

        static double TriangleHeight(double a) {
            return ((a * Math.Sqrt(3)) / 2);
        } 

        static (double,double) Cube(int a) {
            return (a * Math.Sqrt(2), a * Math.Sqrt(3));
        }

        static string NameFusion(string vez,string ker) {
            return $"{vez} {ker}";
        }

        static bool IsEven(int n) {
            return n % 2 == 0;
        }

        static string DecidingNumber(int n) {
            string result = "";
            switch (n) {
                case 1:
                    result= "1 - Elégtelen";
                    break;
                case 2:
                    result = "2 - elégséges";
                    break;
                case 3:
                    result = "3 - közepes";
                    break;
                case 4:
                    result = "4 - jó";
                    break;
                case 5:
                    result = "5 - jeles";
                    break;
                default:
                    break;
            }
            return result;
        }

        static string WaterCheck(int homerseklet) {
            if(homerseklet<= 0) {
                return "Szilárd halmazállapotú";
            }else if(homerseklet < 100) {
                return "Folyekony halmazallapotu";
            } else {
                return "Gőz halmazallapot";
            }
        }
        static bool SzerkeszthetoHaromszog(double a, double b, double c)
            {
            return a + b > c && a + c > b && b + c > a; 
        }

        static double FahrenheitToCelsius(double fahrenheit)
            {
            return (fahrenheit - 32) * 5 / 9; 
        }

        static double CelsiusToFahrenheit(double celsius)
            {
            return celsius * 9 / 5 + 32; 
        }

        static string TimeChecking(int masodperc) {
            int ora = masodperc / 3600;
            masodperc %= 3600;
            int perc = masodperc / 60;
            int maradekMasodperc = masodperc % 60;
            return $"{ora} óra, {perc} perc, {maradekMasodperc} másodperc";
        }


    }
}
