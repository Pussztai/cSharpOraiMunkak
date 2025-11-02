using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyaksz {
    internal class Program {
        static void Main(string[] args) {
            //elsoF();
            //masodikF();

            //harmadikF();
            negyedikF();


        }

        static void elsoF() {
            int osszeg = 0;
            int maxi = 0;
            int maxiIndex = 0;
            int[] t = { 6400, -2000, -4300, 8200, 1000, -3400, 600, -900 };
            for (int i = 0; i < t.Length; i++) {
                osszeg += t[i];

                if (osszeg > maxi) {
                    maxi = osszeg;
                    maxiIndex = i;
                }

            }
            Console.WriteLine(maxiIndex + 1);
        }

        static void masodikF() {
            int[] t = { 6400, -2000, -4300, 8200, 1000, -3400, 600, -900 };
            int osszeg = 0;
            foreach (int item in t) {
                osszeg += item;
            }
            Console.WriteLine(osszeg);
        }

        static void harmadikF() {
            int[] t = { 6400, -2000, -4300, 8200, 1000, -3400, 600, -900 };
            int nyeres = 0; int vesztes = 0;
            foreach (int item in t) {
                if (item < 0) {
                    vesztes++;
                } else {
                    nyeres++;
                }
            }

            if(nyeres > vesztes) {
                Console.WriteLine("nyeres");
            }else if (vesztes > nyeres) {
                Console.WriteLine("vesztes");
            } else {
                Console.WriteLine("Egyenlo");
            }
        }

        static void negyedikF() {

            int[] t = { 6400, -2000, -4300, 8200, 1000, -3400, 600, -900 };
            int nyeresC = 0;
            int maxNyeresC = 0;
            int index = 0;
            for (int i = 0; i < t.Length; i++) {
                if (t[i] > 0) {
                    nyeresC++;
                } else {
                    nyeresC = 0;
                }if(nyeresC > maxNyeresC) {
                    maxNyeresC = nyeresC;
                    index = i-1;
                }
            }
            Console.WriteLine(index);
        }
        
    }
}
