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

            bool hiba = false;
            int ertek = 1;
            while(!hiba && ertek < 10) {
                int db = 0;
                for (int j = sor*9; j < (sor+1)*9; j++) {
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



                for (int i = 0; i < t.Length; i++) {
                    Console.Write(t[i] + " ");

                    if (i % 9 == 0) {
                        Console.WriteLine();
                    }
                }



            //hazi binaris faosok kutattsa
            //atlagok kozul a minimalis
            //sudoku adott oszlop helyes e, a sor, es a negyzet
        }
    }
}
