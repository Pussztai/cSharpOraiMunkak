using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            //kilencHomerseklet2();
            //tizedikHaromszogvizsgalat();
            //tizeneggyHaromszog2();
            //tizenkettoHaromszog4();
            //tizenharomHetNapjai();
            //tizennegyDolgozat();
            //tizenotEvnapjai();
            //tizenhatSiknegyed2();



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

        static void kilencHomerseklet2() {
            Console.WriteLine("C vagy K vagy F: ");
            char homersekletJel = Convert.ToChar(Console.ReadLine().ToUpper());
            double szam = Convert.ToDouble(Console.ReadLine());
            char homersekletJelKimenet = Convert.ToChar(Console.ReadLine().ToUpper());
            if (homersekletJel == 'F' && homersekletJelKimenet == 'C') {
                Console.WriteLine("Eredmény Celsius-ban: " + ((szam - 32) * 5 / 9));
            } else if(homersekletJel == 'F' && homersekletJelKimenet == 'K') {
                Console.WriteLine($"Eredmeny Kelvinbe: {(szam-32)*5/9+273.15}");
            } else if(homersekletJel == 'C' && homersekletJelKimenet == 'F') {
                Console.WriteLine($" eredmeny fahrenheitbe {(szam*9/5) + 32}");
            }

            //kitolteni tul konnyu lenne ezert skip masik feladatra

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

        static void tizeneggyHaromszog2() {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if((a + b) > c && (a + c) > b && (b + c) > a) {
                if (a == b&& b== c) {
                    Console.WriteLine("egyenlo oldalu");
                } else {
                    Console.WriteLine("csak szerkesztheto");
                }
            } else {
                Console.WriteLine("nem szerkesztheto");
            }
        }

        static void tizenkettoHaromszog4() {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if((a*a + b*b) == c*c || (a*a + c*c) == b*b || (b*b + c*c) == a * a) {
                if((a + b) > c && (a + c) > b && (b + c) > a && a != b || b != c) {
                    Console.WriteLine(" csak szekesztheto");
                }
                Console.WriteLine("derekszog");
                
            } else {
                Console.WriteLine("nem szerkesztheto");
            }
        }

        static void tizenharomHetNapjai() {
            int inpNum = Convert.ToInt32(Console.ReadLine());
            int celNum = Convert.ToInt32(Console.ReadLine());

            //int counter = inpNum;
            //for (int i = 1; i < celNum; i++) {
            //    counter++;
            //    if (counter > 7) {
            //        counter = 1;
            //    }

            //    Console.WriteLine(counter);
            //}

            //or

            Console.WriteLine(((inpNum-1) + (celNum -1) % 7)+1);
        }

        static void tizennegyDolgozat() {
            int elertPont = Convert.ToInt32(Console.ReadLine());
            int maxPont = Convert.ToInt32(Console.ReadLine());

            double szazalek = ((double)elertPont /maxPont) * 100;

            if (szazalek <= 29) {
                Console.WriteLine("eggyes");
            }else if(szazalek >= 30 && szazalek <= 39) {
                Console.WriteLine("ketto");
            } else if (szazalek >= 40 && szazalek <= 59) {
                Console.WriteLine("ketto");
            } else if (szazalek >= 60 && szazalek <= 79) {
                Console.WriteLine("ketto");
            } else if(szazalek >= 80) {
                Console.WriteLine("ot");
            }

        }

        static void tizenotEvnapjai() {
            int honap = Convert.ToInt32(Console.ReadLine());
            switch (honap) {
                case 1:
                    Console.WriteLine("januar");break;
            }
            //continue...
        }

        static void tizenhatSiknegyed2() {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if(x == 0 && y == 0) {
                Console.WriteLine("origo");
            } else if(x == 0) {
                Console.WriteLine("y tengely");
            }else if(x < 0 && y > 0) {
                Console.WriteLine("11.siknegyed");
            }else if(x > 0 && y > 0) {
                Console.WriteLine("1.siknegyed");
            }else if(x < 0 && y < 0) {
                Console.WriteLine("iii siknegyed");
            } else {
                Console.WriteLine("4. siknegyed");
            }


        }

        
    }
}
