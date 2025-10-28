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
            int[] t = { 2, 1, 2, 3, 5, 7, 6, 6, 4, 3 };
            int counter = 0;
            foreach (var item in t) {
                if (item < 5) {
                    counter++;
                }

            }
            Console.WriteLine(counter);
        }

        static void masodikF() {
            int[] t = { 2, 1, 2, 3, 5, 12, 6, 6, 4, 3 };
            int maxi = 0;
            int index = 0;
            for (int i = 0; i < t.Length-1; i++) {
                int kulonbseg = Math.Abs(t[i] - t[i + 1]);
                if(kulonbseg > maxi) {
                    maxi = kulonbseg;
                    index = i;
                }

            }
            Console.WriteLine($"{index +1}, {index + 2} kozott {maxi}");
        }

        static void harmadikF() {
            int[] t = {2, 1, 2, 3, 5, 12, 6, 6, 4, 3 };
            int mini = 0;
            int maxi =0;
            for (int i = 1; i < t.Length; i++) {
                if (t[i] > t[maxi]) {
                    maxi = i;
                }
                if (t[i] < t[mini]) {
                    mini = i;
                }
                

            }
            Console.WriteLine(t[maxi] - t[mini]);
        }

        static void negyedikF() {
            int[] t = { 2, 1, 2, 3, 5, 12, 6, 6, 4, 3 };
            int n = t.Length;

            double osszeg = 0;
            double osszegNegyzet = 0;

            for (int i = 0; i < n; i++) {
                osszeg += t[i];           
                osszegNegyzet += t[i] * t[i];
            }

            double atlag = osszeg / n;

            double szoras = Math.Sqrt((osszegNegyzet - n * atlag * atlag) / (n - 1));

            Console.WriteLine(Math.Round(szoras, 3));
        }

    }
}
