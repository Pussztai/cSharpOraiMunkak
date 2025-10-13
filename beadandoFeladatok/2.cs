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
            int[] t = { 160, 185, 159, 185, 167, 174, 172, 185 };
            int j = 1;
            while(j<t.Length-1 && !(t[j] < t[j-1] && t[j] < t[j + 1])) {
                j++;
            }
            Console.WriteLine(j + 1);



        }
        static void masodikF() {
            int[] t = { 185, 158, 159, 160, 167, 174, 172, 185 };
            int counter = 0;
            for (int i = 1; i < t.Length-1; i++) {
                if (t[i - 1] >= t[i] || t[i] >= t[i + 1]) {
                    counter++;
                }
            }
        }

        static void harmadikF() {
            int[] t = { 185, 158, 159, 160, 167, 174, 172, 185 };
            double osszeg = 0;
            foreach (int item in t) {
                osszeg += item;
            }
            double atlag = osszeg / t.Length;
            int tobbAtlagTobb = 0;
            int kevesebbAtlagTobb = 0;
            foreach (int item in t) {
                if(item > atlag) {
                    tobbAtlagTobb++;
                } else {
                    kevesebbAtlagTobb++;
                }
            }
            if(tobbAtlagTobb>kevesebbAtlagTobb) Console.WriteLine("Tobb atlagnal tobb");
            else if (kevesebbAtlagTobb > tobbAtlagTobb) Console.WriteLine("kevesebb atlagnal tobb");
            else Console.WriteLine("Egyenlő");
        }

        static void negyedikF() {
            int[] t = { 185, 175, 182, 159, 167, 174, 172, 185 };
            int hossz = 0;
            int maxhossz = 0;
            int kezdet = 0;
            for (int i = 1; i < t.Length-1; i++) {
                if (t[i-1] < t[i] && t[i] < t[i + 1]) {
                    hossz+=3;
                    kezdet = i;
                    if(hossz > maxhossz) {
                        maxhossz = hossz;
                        kezdet = i;
                    }
                } else {
                    hossz = 0;
                }
            }
            Console.WriteLine($"{maxhossz} : {kezdet}");
        }






    }
}
