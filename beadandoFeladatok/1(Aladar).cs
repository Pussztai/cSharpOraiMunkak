using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dogaraGyakszi {
    internal class Program {
        static void Main(string[] args) {
            //elsoF();
            //masodikF();
            //harmadikF();
            //negyedikF();
        }
        static void elsoF() {
            int[] t = { 3, 1, -4, -4, 3, 0, 2, 3, -1, -1, -3, -2, 4, 1, -2, -1, 2, -3, 3, 4 };
            int teljes = 0;
            int elore = 0;
            for (int i = 0; i < t.Length; i++) {
                teljes += Math.Abs(t[i]);
                if (t[i] > 0) {
                    elore += t[i];
                }


            }

            Console.WriteLine(Math.Round(((double)teljes / elore - 1) * 100, 2));
        }

        static void masodikF() {

            int[] t = {3, 1, -4, -4, 3, 0, 2, 3, -1, -1, -3, -2, 4, 1, -2, -1, 2, -3, 3, 4};
            int hossz = 0;
            int maxHossz = 0;
            for (int i = 0; i < t.Length; i++) {


                if (t[i] >= 0) {
                    hossz++;
                    if(hossz > maxHossz) {
                        maxHossz = hossz;
                    }

                } else {
                    hossz = 0;
                }
                
            }
            Console.WriteLine(maxHossz);
                
        }

        static void harmadikF() {
            int maxi = 0;
            int[] t = { 3, 1, -6, -4, 3, 0, 2, 3, -1, -1, -3, -2, 6, 1, -2, -1, 2, -3, 3, 4 };
            for (int i = 0; i < t.Length; i++) {
                if (Math.Abs(t[i]) > maxi) {
                    maxi = t[i];
                }

            }
            int count = 0;
            foreach (int item in t) {
                if (Math.Abs(item) == maxi) {
                    count++;
                }
            }
            Console.WriteLine(count);

        }

        static void negyedikF() {
            int i = 0;
            int[] t = { 3, 1, -6, -4, 3, 0, 2, 3, -1, -1, -3, -2, 6, 1, -2, -1, 2, -3, 3, 4 };
            while(i<t.Length && t[i] != 0) {
                i++;
            }
            if (i < t.Length) {
                Console.WriteLine("igen");
            } else {
                Console.WriteLine("nem");
            }
        }






    }
}
