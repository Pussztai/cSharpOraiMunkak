using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dogaraGyakszi {
    internal class Program {
        static void Main(string[] args) {
            //numero();
            //masodikF();
            //harmadikF();
            negyedikF();
        }

        static void numero() {
            int[] t = { 12500, -33000, -13000, -1000, 26000, -6200, -2700, -3000 };
            int osszeg = 0;
            for (int i = 0; i < t.Length; i++) {
                osszeg += t[i];
            }

            Console.WriteLine(osszeg);
            

            

        }
        static void masodikF() {
            int osszeg = 0;
            int db = 0;
            int[] t ={ 12500, -33000, -13000, -1000, 26000, -6200, -2700, -3000 };
            for (int i = 0; i < t.Length; i++) {
                if (osszeg < 0 && t[i] < 0) {
                    db++;
                }
                osszeg += t[i];
                

            }
            Console.WriteLine(db);
            
            
        }

        static void harmadikF() {
            int[] t = { 12500, -33000, -13000, -1000, 76000, -6200, -2700, -3000 };
            int maxi = 0;
            int osszeg = 0;
            int maxIndex = 0;
            for (int i = 0; i < t.Length; i++) {
                osszeg += t[i];
                if(osszeg > maxi) {
                    maxi = osszeg;
                    maxIndex = i + 1;
                }

            }
            Console.WriteLine($"na " + maxIndex + ". tranzakcio utan volt a legtobb");

            

            
        }

        static void negyedikF() {
            int[] t = { 12500, -33000, -13000, -1000, 76000, -6200, -2700, -3000 };
            int betet = 0;
            int kivet = 0;
            for (int i = 0; i < t.Length; i++) {
                if (t[i] < 0) {
                    kivet++;
                } else {
                    betet++;
                }


            }

            if(betet > kivet) Console.WriteLine("Betetbol");
            else if(kivet > betet) Console.WriteLine("Kivetbol");
            else Console.WriteLine("Egyenlo");
        }






    }
}
