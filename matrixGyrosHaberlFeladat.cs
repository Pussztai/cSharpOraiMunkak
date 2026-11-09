using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gyros_Haberl_ {
    internal class Program {
        static void Main(string[] args) {
            string[] Bence = new string[] {"hagyma", "csípős", "sajt", "saláta", "uborka", "paradicsom" };
            string[] Mate = new string[] {"csípős", "paradicsom", "káposzta", "saláta", "hagyma", "paprika" };

            //mindketten(Bence, Mate);
            //eggyikNem(Bence, Mate);

            //foreach (KeyValuePair<string, int> item in szotarHasznalat() ){
            //    Console.WriteLine($"{item.Key}: {item.Value} alkalommal");
            //}

            Beolvasas();

        }

        static void Beolvasas() {
            string path = "C:\\Users\\User\\Desktop\\bevetel.txt";

            string[] sorok = File.ReadAllLines(path);
            
            int hossz = sorok.Length;
            int maxOszlop = 0;

            for (int i = 0; i < hossz; i++) {
                string[] ertekek = sorok[i].Split(' ');
                if (ertekek.Length > maxOszlop) {
                    maxOszlop = ertekek.Length;
                }
            }


            int[,] matrix = new int[hossz, maxOszlop];
            for (int i = 0; i < hossz; i++) {
                string[] ertekek = sorok[i].Split(' ');
                
                for (int j = 0; j < ertekek.Length; j++) {
                    matrix[i,j] = int.Parse(ertekek[j]);
                }
                       
            }

            for (int i = 0;i < hossz; i++) {
                for (int j = 0; j < maxOszlop; j++) {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }




        static void mindketten(string[] h1, string[] h2) {
            
            for (int i = 0; i < h1.Length; i++) {
                for (int j = 0; j < h2.Length; j++) {
                    if (h1[i] == h2[j]) {
                        Console.WriteLine(h1[i]);
                    }
                }
            }
        }

        static Dictionary<string,int> szotarHasznalat() {
            string[] varosok = new string[] { "Budapest", "Cegléd", "Kecskemét",
                "Pécs", "Budapest", "Szolnok", "Budapest", "Debrecen",
                "Szolnok", "Budapest", "Budapest", "Cegléd", "Szolnok" };
            Dictionary<string, int> varosSzamlalo = new Dictionary<string, int>();

            foreach (string nev in varosok) {
                if (varosSzamlalo.ContainsKey(nev)) {
                    varosSzamlalo[nev]++;
                } else {
                    varosSzamlalo[nev] = 1;
                }
            }

            return varosSzamlalo;


        }

        static void eggyikNem(string[] h1, string[] h2) {
            int i = 0;
            while (i < h2.Length) {
                bool vanEbenne = false;
                int j = 0;
                while (j < h1.Length && !vanEbenne) {
                    if (h2[i] == h1[j]) {
                        vanEbenne = true;
                        
                    }
                    j++;
                    
                }
                
                if (!vanEbenne) {
                    Console.WriteLine(h2[i]);
                }
                i++;
                

            }
            
        }
    }
}
