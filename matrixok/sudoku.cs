using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku {
    internal class Program {

        static int[,] Feltoltés(int[,] t, int sor, int oszlop) {
            //int[,] ujt = new int[9, 9];
            //for (int i = 0; i < sor; i++) {
            //    for (int j = 0; j < oszlop; j++) {
            //        ujt[i, j] = t[i,j];
            //        while (t[i, j] == 0) {
            //            Console.Write($"{i}:{j + 1} = ");
            //            List<int> szamok = Lehetoseg(t, i, j);
            //            if(szamok.Count == 1) {
            //                t[i, j] = szamok[0];
            //            }

            //        }
            //    }
            //}
            //return t;

            bool valtozas;

            do {
                valtozas = false;

                for (int i = 0; i < sor; i++) {
                    for (int j = 0; j < oszlop; j++) {
                        if (t[i,j] == 0) {
                            List<int> szamok = Lehetoseg(t, i, j);
                            if(szamok.Count == 1) {
                                t[i, j] = szamok[0];
                                valtozas = true;
                            }
                        }
                    }
                }

            } while (valtozas);

            return t;

        }


        static void lehetosegekKiirasa(int[,] t,int sor,int oszlop) {
            for (int i = 0; i < sor; i++) {
                for (int j = 0; j < oszlop; j++) {
                    if (t[i,j] == 0) {
                        Console.Write($"{i}:{j+1} = ");
                        List<int> szamok = Lehetoseg(t, i, j);
                        foreach (int item in szamok) {
                            Console.Write(item + " ");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }

       

        static List<int> Lehetoseg(int[,] t,int sor,int oszlop) {
            List<int> szamok = new List<int>();
           
            for (int i = 1; i <= 9; i++) {
                if (lehetosegek(t, sor, oszlop, i)) {
                    szamok.Add(i);
                   

                }
            }
            return szamok;
            
        }

        static bool lehetosegek(int[,] t,int sor, int oszlop,int szam) {

            for (int i = 0; i < oszlop; i++) {
                if (t[sor, i] == szam) return false;
            }

            for (int i = 0; i < sor; i++) {
                if (t[i, sor] == szam) return false;
            }

            int startRow = (sor / 3) * 3;
            int startCol = (oszlop / 3) * 3;
            for (int i = startRow; i < startRow+3; i++) {
                for (int j = startCol; j < startCol+3; j++) {
                    if (t[i, j] == szam) return false;
                }
            }

            return true;


            //for (int i = 0; i < szamok.Length; i++) {
            //    if (szamok[i] == 0) {
            //        Console.Write(i+1 + " ");
            //    }
            //} 


        }












        static void kiiras(int[,] t) {
            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 9; j++) {
                    Console.Write(t[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args) {

            int[,] sudoku = new int[9, 9]
            {
                {5, 3, 4, 6, 7, 8, 9, 1, 0},
                {6, 7, 2, 1, 9, 5, 3, 4, 8},
                {1, 9, 8, 3, 4, 2, 5, 6, 7},
                {8, 5, 9, 7, 6, 1, 4, 0, 3},
                {4, 2, 6, 8, 5, 3, 7, 9, 1},
                {7, 1, 3, 9, 2, 4, 8, 5, 6},
                {9, 6, 1, 5, 3, 7, 2, 8, 4},
                {2, 8, 7, 4, 1, 9, 6, 3, 5},
                {3, 4, 5, 2, 8, 6, 1, 7, 0} 
            };

            kiiras(sudoku);
            Console.WriteLine();
            lehetosegekKiirasa(sudoku, 9, 9);


            kiiras(Feltoltés(sudoku,9,9));
        }

        
    }
}
