using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaGrafHazi {
    internal class Program {
        static void Main(string[] args) {
            Random rnd = new Random(709);
            int n = 20;
            int[] t = new int[n];

            //valami oskutatas (csak tippelek hogy igy kell megcsinalni, nem irtam melle peldat)

            

            for (int i = 0; i < n; i++) {
                t[i] = rnd.Next(0, 10);

            }
            Console.WriteLine("tomb: ");
            foreach (int item in t) {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Os agak");
                Console.WriteLine((i * i) + 2);

            }

            int ugras = 2;
            int osszeg = 0;

            for (int i = 0; i < n; i++) {
                if (osszeg < t.Length) {
                    Console.WriteLine("Os (jobb oldalt)");
                    Console.WriteLine(t[osszeg]);
                    Console.WriteLine(osszeg);
                }
                osszeg += ugras;
                ugras *= 2;

            }


            //min atlag kereses


            double min = 2000;
            int index = 0;
            for (int i = 1; i <= n-1; i++) {
                double atlag = (t[0] + t[i]) / 2.0;
                if (atlag < min) {
                    min = atlag;
                    index = i;
                }
            }
            Console.WriteLine(index);
            Console.WriteLine(min);



        }
    }
}
