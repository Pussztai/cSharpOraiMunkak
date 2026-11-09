using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;

namespace dogaraGyakszi {
    internal class Program {
        static void Main(string[] args) {
            //numero();
            //masodikF();
            //harmadikF();
            negyedikF();
        }

        static void numero() {
            double[] t = { 27.3, 26.8, 25.7, 26.3, 27.3, 27.2, 27, 27.3 };
            int maxi = 0; 
            int db = 1;
            for (int i = 1; i < t.Length; i++) {
                if (t[i] > t[maxi]) {
                    maxi = i; 
                    db = 1;   
                } else if (t[i] == t[maxi]) {
                    db++;   
                }
            }
            Console.WriteLine(db);
        }
        static void masodikF() {
            double[] t = { 27.3, 30.2, 19.2, 26.3, 27.3, 27.2, 27, 10.2 };

            double min = 50;
            double max = 0;
            for (int i = 1; i < t.Length; i++) {
                if (t[i] > max) {
                    max = t[i];
                }
                if (t[i] < min) {
                    min = t[i];
                }
            }
            Console.WriteLine(max - min);
        }

        static void harmadikF() {
            double[] t = { 27.3, 30.2, 19.2, 26.3, 27.3, 27.2, 27, 10.2 };
            double osszeg = 0;
            foreach (int item in t) {
                osszeg += item;
            }
            double atlag = osszeg / t.Length;
            int nagyobb = 0; int kisebb = 0; int egyenlo = 0;
            foreach (int item in t) {
                if (item > atlag) {
                    nagyobb++;
                } else if(item < atlag) {
                    kisebb++;
                } else {
                    egyenlo++;
                }

            }
            
            if (nagyobb > kisebb && nagyobb > egyenlo) {
                Console.WriteLine("nagyobbol tobb");
            }else if(kisebb > nagyobb && kisebb > egyenlo) {
                Console.WriteLine("kisebbol tobb");
            } else {
                Console.WriteLine("egyenlo");
            }



        }

        static void negyedikF() {
            double[] t = { 27.3, 30.2, 19.2, 26.3, 27.3, 27.2, 27, 10.2 };
            int i = 0;
            while(i<t.Length && t[i] >= 0) {
                i++;
            }
            if(i < t.Length) Console.WriteLine("teli honap");
            else Console.WriteLine("nem teli honap");

            
        }






    }
}
