using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazokHazi {
    internal class Program {
        static void Main(string[] args) {
            //elsoOszthatosag();
            //masodikAtvaltas();
            //harmadikRelacio();
            //negyedikOszth();
            //otodikEgyenlet();
            //Console.WriteLine(hatodikAnalizis());
            //hetedikHomerseklet2();
            //nyolcadikUjhold();

            //kilences kell

            //tizedikHaromszogvizsgalat();

            //11kell
            //12kell
            //13kell
            //14kell
            //15kell
            //16kell

            

        }

        static void elsoOszthatosag() {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > 0 && b > 0) {
                Console.WriteLine((double)a / b);
            } else {
                Console.WriteLine("0val nem osztunk");
            }
        }
        static void masodikAtvaltas() {
            Console.WriteLine("Add meg a műveletet (f Celsius-ra c to celsius):");
            string muveletJel = Console.ReadLine().ToLower();
            Console.WriteLine("Add meg a számot:");
            double szam = Convert.ToDouble(Console.ReadLine());

            if (muveletJel == "f") {
                Console.WriteLine("Eredmény Celsius-ban: " + ((szam - 32) * 5 / 9));
            } else if (muveletJel == "c") {
                Console.WriteLine($"{(szam * 9 / 5) + 32}");
            }
        }

        static void harmadikRelacio() {
            Console.WriteLine("harmadik feladat relacio");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b) {
                Console.WriteLine("nagyobb");
            } else if (b > a) {
                Console.WriteLine("kisebb");
            } else {
                Console.WriteLine("egyenlo");
            }
        }

        static void negyedikOszth() {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (y == 0) {
                Console.WriteLine("nem osztható");
            } else if (x % y == 0) {
                Console.WriteLine("osztható");
            } else {
                Console.WriteLine("nem osztható");
            }
        }

        static void otodikEgyenlet() {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a == 0) {
                Console.WriteLine("nem elsőfokú egyenlet");
            } else {
                //x = -b / a
                double x = -(double)b / a;


                if (x == (int)x) {
                    Console.WriteLine((int)x);
                } else {
                    Console.WriteLine(x);
                }
            }
        }

        static string hatodikAnalizis() {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0) {
                return "1";
            } else if (a < 0) {
                return "-1";
            } else {
                return "0";
            }
        }

        static void hetedikHomerseklet2() {
            int adat = Convert.ToInt32(Console.ReadLine());

            if (adat >= 100) {
                Console.WriteLine("goz");
            } else if (adat > 0) {
                Console.WriteLine("viz");
            } else {
                Console.WriteLine("jég");
            }
        }

        static void nyolcadikUjhold() {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            if (b == 15) {
                Console.WriteLine("holdfogyatkozás");
            } else if (b == 1) {
                Console.WriteLine("telihold");
            } else {
                if (b > a)
                    Console.WriteLine("telihold");
                else
                    Console.WriteLine("holdfogyatkozás");
            }
        }

        static void tizedikHaromszogvizsgalat() {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if ((a + b) > c && (a + c) > b && (b + c) > a) {
                Console.WriteLine("szerkesztheto");
            } else {
                Console.WriteLine("nem szerkesztheto");
            }
        }
    }
}
