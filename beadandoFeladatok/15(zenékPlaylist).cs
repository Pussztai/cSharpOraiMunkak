using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace gyaksz {
    internal class Program {
        static void Main(string[] args) {
            //elsoF();
            //masodikF();

            //harmadikF();
            negyedikF();


        }

        static void elsoF() {
            int[] t = { 100, 110, 200, 150, 300, 180, 150, 150, 100, 100 };
            int osszeg = 0;
            foreach (int item in t) {
                osszeg += item;


            }
            Console.WriteLine($"{osszeg} mp = {osszeg / 60} perc + {osszeg % 60} masodperc");

        }

        static void masodikF() {
            int[] t = { 100, 110, 200, 150, 300, 180, 150, 150, 100, 100 };

            //int K = 280;
            int i = 0;
            while (i < t.Length && t[i] < 280) {
                i++;
            }
            if (i < t.Length) {
                Console.WriteLine($"volt, {i + 1}");
            } else {
                Console.WriteLine("nem volt");
            }





        }

        static void harmadikF() {
            int[] t = new int[10] { 100, 110, 200, 150, 300, 180, 150, 150, 100, 100 };
            int osszeg = 0;
            int i = 0;
            while (i < t.Length) {
                osszeg += t[i];
                if ((i + 1) % 5 == 0) {
                    int maradek = osszeg % 60;
                    if (maradek != 0) {
                        osszeg += 60 - (osszeg % 60);
                    }
                    //Console.WriteLine(t[i]);
                    
                }
                i++;
            }
            Console.WriteLine($"{osszeg} = {osszeg / 60} perc");
        }

    
            
            


    

        static void negyedikF() {
            int[] t = { 100, 110, 200, 150, 300, 180, 150, 150, 100, 100 };
            int K = 4;
            int osszeg = 0;
            for (int i = 0; i < K; i++) {
                osszeg += t[i];

            }
            int maradek = osszeg % 60;
            if (maradek != 0) {
                osszeg += (60 - maradek);
            }
            int kor = (osszeg - 1) / 180 + 1;
            Console.WriteLine(kor);


        }

    }
}
