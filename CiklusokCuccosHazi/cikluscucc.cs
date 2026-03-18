using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Final_boss_hazi {
    internal class Program {

        static void Main(string[] args) {
            szamigElszamolas();
            Console.WriteLine();
            Kettes();
            Harmas();
            Console.WriteLine(Negyes());
            atlagaSzamitas();
            factorialNumber();
            checkingInput();
            menu();
            osztokSzama();
            leganygobbOsztoLeastdivisidor();
            primFelbontas();
            Console.WriteLine();
            diofanticEgyenlet();
            fibonacci();
            stars();

        }
        static void szamigElszamolas() {
            int szam = Convert.ToInt32(Console.ReadLine());

            //szamlalo ciklus

            for (int i = 1; i < szam + 1; i++) {
                Console.Write(i);
                if (i < szam) {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            for (int i = szam; i > 0; i--) {
                Console.Write(i);
                if (i > 1) {
                    Console.Write(", ");
                }
            }

            //elotesztelo ciklus
            Console.WriteLine();


            int j = 1;
            while (j < szam + 1) {
                Console.Write(j);
                if (j < szam) {
                    Console.Write(", ");
                }
                j++;
            }
            Console.WriteLine();

            int k = 1;
            do {
                Console.Write(k);
                if (k < szam) {
                    Console.Write(", ");
                }
                k++;
            } while (k < szam + 1);
        }
        
        static void Kettes() {
            Console.WriteLine("Kettes feladat (dobokocka)");
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
        static void Harmas() {
            Console.WriteLine("harmas feladat (mekegő nyelv)");
            string vowels = "aeiouáéíóöőúüű";
            string m = Console.ReadLine();
            float ecount = 0;
            float mcount = 0;
            foreach (char e in m) {
                char x = char.ToLower(e);
                if (vowels.Contains(x.ToString())) {
                    mcount += 1;
                    if (x == 'e' || x == 'é') {
                        ecount += 1;
                    }
                }
            }

            if (mcount > 0) {
                Console.WriteLine($"{(ecount / mcount) * 100}%");
            } else {
                Console.WriteLine("Nincs magánhangzó!");
            }
        }
        static bool Negyes() {
            Console.WriteLine("Negyes feladat (Primszam)");
            int pvn = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < pvn; i++) {
                if (pvn % i == 0) {
                    return false;
                }
            }
            return true;


        }
        static void atlagaSzamitas() {
            Console.WriteLine("otos feladat (atlag)");
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

            if(counter == 0) {
                Console.WriteLine("nem irtal be pozitiv szamot");
            } else {
                Console.WriteLine(Math.Round((double)osszeg / counter, 2));
            }
                
        }

        static void factorialNumber() {
            Console.WriteLine("hatos feladat (factorial)");
            int szam = Convert.ToInt32(Console.ReadLine());
            int osszeg = 1;
            for (int i = 1; i < szam + 1; i++) {
                osszeg *= i;
            }

            Console.WriteLine(osszeg);
        }

        static void checkingInput() {
            Console.WriteLine("Hetes feladat (Szuletesi ev)");
            int szuletesiEv;


            do {
                szuletesiEv = Convert.ToInt32(Console.ReadLine());

            } while (szuletesiEv < 1940 || szuletesiEv > 2020);

            Console.WriteLine(2020 - szuletesiEv);


        }

        static void menu() {
            Console.WriteLine("8# Menü");

            Console.WriteLine("1 – Add meg a nevet");
            Console.WriteLine("2 – Üdv {0}!");
            Console.WriteLine("3 – Helló {0}!");
            Console.WriteLine("4 – Szia {0}!");
            Console.WriteLine("5 – Kilépés.");
            char utasitas;
            string n = null;


            do {
                utasitas = Convert.ToChar(Console.ReadLine());
                if (utasitas == '1') {
                    n = Console.ReadLine();
                }
                if (utasitas == '2' || utasitas == '3' || utasitas == '4') {
                    if (string.IsNullOrEmpty(n)) {
                        Console.WriteLine("Először add meg a nevet!");
                    } else if (utasitas == '2') {
                        Console.WriteLine($"Üdv {n}!");
                    } else if (utasitas == '3') {
                        Console.WriteLine($"Helló {n}!");
                    } else if (utasitas == '4') {
                        Console.WriteLine($"Szia {n}!");
                    }
                }
            }
            while (utasitas != '5');

        }

        static void osztokSzama() {
            Console.WriteLine("kilences feladat (osztok szama)");
            int szam = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i < szam + 1; i++) {
                if (szam % i == 0) {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        static void leganygobbOsztoLeastdivisidor() {
            Console.WriteLine("tizes feladat (lnko)");

            Console.WriteLine("Lnko 1 szam");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lnko 2 szam");
            int szam2 = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("tizeneggyedik feladat (prim felbontas)");

            int szam = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("tizenkettedik diofantik");
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

            //ezzel ellenorizzuk hogy egesz szam-egesz az eredmeny, kulonben vegtelen ciklusba kerulunk 
            //(Csoves expection)


            if ((k - n * x) % m == 0) {
                int y = (k - n * x) / m;
                Console.WriteLine($"x = {x}, y = {y} van megoldás");
            } else {
                Console.WriteLine("nincs megoldás");
            }



        }

        static void fibonacci() {
            Console.WriteLine("tizenharmadik (fibo)");

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
            Console.WriteLine("tizennegyedik (csillagok)");

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