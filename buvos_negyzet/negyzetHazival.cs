using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buvosNegyzet {
    internal class Program {
        static void Main(string[] args) {

            Random rnd = new Random();
            int[] t = new int[81];
            for (int i = 0; i < 81; i++) {
                t[i] = rnd.Next(0, 10);
            }

            for (int i = 0; i < t.Length; i++) {
                Console.Write(t[i] + " ");

                if ((i + 1) % 9 == 0) {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("kerj be egy szamot vizsgalatra");
            int szam = Convert.ToInt32(Console.ReadLine());

            int sor;
            int col;
            int kockasor;
            int kockacol;

            sor = szam / 9;
            Console.WriteLine("sor: " + sor);

            col = szam % 9;

            Console.WriteLine("column: " + col);

            kockasor = sor / 3;
            Console.WriteLine("sor[]: " + kockasor);

            kockacol = col % 3;
            Console.WriteLine("col[]: " + kockacol);

            //soronkent

            bool hiba = false;
            int ertek = 1;
            while (!hiba && ertek < 10) {
                int db = 0;
                for (int j = sor * 9; j < (sor + 1) * 9; j++) {
                    if (t[j] == ertek) {
                        db++;
                    }

                }
                hiba = (db > 1);
                ertek++;

            }

            if (hiba) {
                Console.WriteLine("hibas");
            } else {
                Console.WriteLine("jo");
            }

            //col

            bool hiba2 = false;
            int ertek2 = 1;
            while(!hiba2 && ertek2 < 10) {
                int db = 0;
                for (int j = col; j < t.Length; j += 9) {
                    if (t[j] == ertek2) {
                        db++;
                    }

                }
                hiba2 = (db > 1);
                ertek2++;
            }

            if (hiba2) {
                Console.WriteLine("hibas");
            } else {
                Console.WriteLine("jo");
            }









            //hazi binaris faosok kutattsa
            //atlagok kozul a minimalis
            //sudoku adott oszlop helyes e, a sor, es a negyzet
        }
    }
}
