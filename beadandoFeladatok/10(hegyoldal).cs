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
            int[] t = { 90, 100, 170, 350, 550, 550, 890, 1000, 1100 };
            int i = 0;
            while (i < t.Length - 1 && !(t[i] == t[i+1])) {
                i++;
            }
            if (i < t.Length - 1) {
                Console.WriteLine(i+1);
            } else {
                Console.WriteLine(-1);
            }

        }

        static void masodikF() {
            int[] t = { 9300, 10310, 110, 350, 550, 550, 890, 1020, 1100 };
            int mini = 0;
            for (int i = 1; i < t.Length - 1; i++) {
                int kulonbseg = t[i + 1] - t[i];
                if (kulonbseg >0&& kulonbseg<t[mini]) {
                    mini = i;
                }
            }
            Console.WriteLine(mini+1);

        }

        static void harmadikF() {
            int[] t = { 90, 100, 170, 350, 550, 550, 890, 1000, 1100 };
            double osszeg = 0;
            int db = 0;
            for (int i = 0; i < t.Length-1; i++) {
                int emelkedes = t[i + 1] - t[i];
                if(emelkedes > 0) {
                    double szog = Math.Atan(emelkedes / 10.0);
                    osszeg += szog;
                    db++;
                }

            }
            double atlag = osszeg / db;
            Console.WriteLine(Math.Round(atlag,3));

        }

        static void negyedikF() {
            int[] t = { 90, 100, 170, 350, 550, 550, 890, 1000, 1100 };
            int i = 0;
            while(i<t.Length-1 && !(t[i] > t[i + 1])) {
                i++;
            }
            if (i < t.Length-1) {
                Console.WriteLine("nem folytonos");
            } else {
                Console.WriteLine("igen folytonos");
            }
        }

    }
}
