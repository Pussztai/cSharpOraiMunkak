using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklusokAlap {
    internal class Program {
        static void Main(string[] args) {
            //szamigElszamolas();
            //kiNevetAavegen();
            //mekegoNyelv();

            //if (primeCheck(7)) {
            //    Console.WriteLine("prim");
            //} else {
            //    Console.WriteLine("összetett szám");
            //}

            //atlagaSzamitas();

            //factorialNumber();

            //checkingInput();

            //menu();

            //osztokSzama();

            //leganygobbOsztoLeastdivisidor();

            //primFelbontas();

            //diofanticEgyenlet();

            //fibonacci();

            //stars();
        }

        static void szamigElszamolas() {
            int szam = Convert.ToInt32(Console.ReadLine());

            //szamlalo ciklus

            for (int i = 1; i < szam + 1; i++) {
                if (i == szam) {
                    Console.Write(i);
                } else {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();

            for (int i = szam; i > 0; i--) {
                if (i == 1) {
                    Console.Write(i);
                } else {
                    Console.Write(i + ", ");
                }
            }

            //elotesztelo ciklus


            //int i = 1;
            //while(i < szam + 1) {
            //    if (i == szam) {
            //        Console.Write(i);
            //    } else {
            //        Console.Write(i + ", ");
            //    }
            //    i++;
            //}
            //Console.WriteLine();


            //while (szam > 0) {
            //    if (szam == 1) {
            //        Console.Write(szam);
            //    } else {
            //        Console.Write(szam + ", ");
            //    }


            //    szam--;
            //}

            //int i = 1;
            //do {
            //    if (i == szam) {
            //        Console.Write(i);
            //    } else {
            //        Console.Write(i + ", ");
            //    }
            //    i++;
            //} while (i < szam + 1);

            //Console.WriteLine();

            //do {
            //    if (szam == 1) {
            //        Console.Write(szam);
            //    } else {
            //        Console.Write(szam + ", ");
            //    }
            //    szam--;
            //} while (szam > 0);


        }

        //2.feladat

        static void kiNevetAavegen() {
            Random rnd = new Random();
            int szam = 6;
            int counter = 0;

            for (int i = 0; i < szam; i++) {
                int dobottSzam = rnd.Next(1, 7);
                Console.Write($"{dobottSzam} ");
                if (dobottSzam == 6) {
                    counter++;
                }
            }
            Console.WriteLine($"Hanyszor lephettunk volna ki: {counter}");

        }

        static void mekegoNyelv() {
            int counterEÉbetuk = 0;
            int maganHangzok = 0;
            string szoveg = "Ez egy nagyon elegáns feladat!";

            for (int i = 0; i < szoveg.Length; i++) {
                char c = char.ToLower(szoveg[i]);
                if (c == 'e' || c == 'é') {
                    counterEÉbetuk++;
                } else {
                    string maganhangzok = "aáeéiíoóöőuúüű";
                    for (int j = 0; j < maganhangzok.Length; j++) {
                        if (c == maganhangzok[j]) {
                            maganHangzok++;
                        }

                    }
                }
            }

            Console.WriteLine((int)Math.Round((double)counterEÉbetuk * 100 / (counterEÉbetuk + maganHangzok)));
        }


        static bool primeCheck(int szam) {
            //int szam = 7;
            for (int i = 2; i < szam + 1; i += 2) {
                if (i % szam == 0) {
                    return false;

                }
            }
            return true;
        }

        static void atlagaSzamitas() {
            int counter = 0;
            int osszeg = 0;
            int szam;
            do {
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam > 0) {
                    counter++;
                    osszeg += szam;
                }
            } while (szam > 0 && szam <= 5);

            Console.WriteLine(Math.Round((double)osszeg / counter, 2));
        }

        static void factorialNumber() {
            int szam = 6;
            int osszeg = 1;
            for (int i = 1; i < szam + 1; i++) {
                osszeg *= i;
            }

            Console.WriteLine(osszeg);
        }

        static void checkingInput() {
            int szuletesiEv;


            do {
                szuletesiEv = Convert.ToInt32(Console.ReadLine());

            } while (szuletesiEv < 1940 || szuletesiEv > 2020);

            Console.WriteLine(2020 - szuletesiEv);


        }

        static void menu() {
            bool isRunning = true;
            bool isNameIsGiven = false;
            string choice;
            string nev = "";
            while (isRunning) {
                Console.WriteLine("1 – Add meg a nevet");
                Console.WriteLine("2 – Üdv {0}!");
                Console.WriteLine("3 – Helló {0}!");
                Console.WriteLine("4 – Szia {0}!");
                Console.WriteLine("5 – Kilépés.");
                choice = Console.ReadLine();
                switch (choice) {
                    case "1":
                        nev = Console.ReadLine();
                        isNameIsGiven = true; break;
                    case "2":
                        if (isNameIsGiven) {
                            Console.WriteLine($"Üdv {nev}");
                        } else {
                            Console.WriteLine("Nem adtal meg nevet");
                        }
                        break;
                    case "3":
                        if (isNameIsGiven) {
                            Console.WriteLine($"Helló {nev}");
                        } else {
                            Console.WriteLine("Nem adtal meg nevet");
                        }
                        break;
                    case "4":
                        if (isNameIsGiven) {
                            Console.WriteLine($"Szia {nev}");
                        } else {
                            Console.WriteLine("Nem adtal meg nevet");
                        }
                        break;
                    case "5":
                        isRunning = false;
                        Console.WriteLine("Viszlát!"); break;
                    default:
                        Console.WriteLine("Adj meg normalis opciot"); break;
                }

            }

        }

        static void osztokSzama() {
            int szam = 6;
            int counter = 0;
            for (int i = 1; i < szam + 1; i++) {
                if (szam % i == 0) {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        static void leganygobbOsztoLeastdivisidor() {
            int szam1 = 21;
            int szam2 = 28;
            int minOszto = 0;
            int hatar = Math.Min(szam1, szam2);

            for (int i = 1; i <= hatar; i++) {
                if (szam1 % i == 0 && szam2 % i == 0) {
                    minOszto = i;
                }
            }
            Console.WriteLine($"Leganygobb kozos oszto {minOszto}");
            Console.WriteLine($"Legkisebb kozos tobbszoros {(szam1 * szam2) / minOszto}");
        }

        static void primFelbontas() {
            int szam = 100;
            int oszto = 2;

            while (szam > 1) {
                if (szam % oszto == 0) {
                    szam /= oszto;
                    if (szam == 1) {
                        Console.Write(oszto);
                    } else {
                        Console.Write(oszto + "*");

                    }

                } else {
                    oszto++;
                }
            }
        }

        static void diofanticEgyenlet() {
            int n = 7;
            int m = 11;
            int k = 118;

            //teljes keplet = N⋅x+M⋅y=K

            int x = 0;

            //csak akkor allunk meg ha egesz szam van, addig pedig probalgatunk
            //ezt a % 11 el ellenorizzuk

            //(k - n * x) = hany fej marad ha x darab N feju sarkany van

            //probalgatasos modszer ciklussal
            while ((k - (n * x)) % 11 != 0) {

                x++;
            }


            int y = (k - n * x) / m;
            Console.WriteLine($"x = {x} y = {y}");

        }

        static void fibonacci() {


            int fibo1 = 0;
            int fibo2 = 1;
            int i = 0;
            while (i <= 5) {
                int osszeg = fibo1;
                fibo1 = fibo2;
                fibo2 = osszeg + fibo1;

                i++;
            }
            Console.WriteLine(i + 1);

        }

        static void stars() {
            int szam = 4;

            for (int i = 1; i <= szam; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= szam; i++) {

                for (int s = 0; s < szam - i; s++) {
                    Console.Write(' ');
                }

                for (int j = 1; j <= i; j++) {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = szam; i >= 1; i--) {
                for (int s = 0; s < szam - i; s++) {
                    Console.Write(' ');
                }

                for (int j = 1; j <= i; j++) {
                    Console.Write('*');
                }
                Console.WriteLine();

            }




            Console.WriteLine();


            for (int i = szam; i >= 1; i--) {
                for (int j = 1; j <= i; j++) {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //piramis


            for (int i = 1; i <= szam; i++) {
                
                for (int s = 0; s < szam - i; s++) {
                    Console.Write(" ");
                }

                
                for (int j = 0; j < 2 * i - 1; j++) {
                    Console.Write("*");
                }

                
                Console.WriteLine();



            }











        }
    }
}



