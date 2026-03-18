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
            int[] t = { 3, 14, 18, 32, 14, 23, 28, 27, 26, 40 };
            int counter = 0;
            for (int i = 0; i < t.Length; i++) {
                
                if ((((double)t[i] / 40.0) * 100) > 69) {
                    counter++;

                }
            }
            Console.WriteLine(((double)counter/t.Length)*100);
            




        }

        static void masodikF() {
            int[] t = { 3, 37, 18, 38, 14, 23, 28, 27, 39, 40 };
            int egyes = 0;int otos = 0;
            for (int i = 0; i < t.Length; i++) {
                double szazalek = (double)(t[i] / 40.0)*100;
                if (szazalek >= 85) {
                    otos++;
                } else if(szazalek<=29) {
                    egyes++;
                }
            }

            if(otos > egyes) {
                Console.WriteLine("tobb otos");
            }else if(egyes > otos) {
                Console.WriteLine("tobb eggyes");
            } else {
                Console.WriteLine("egyenlo");
            }



        }

        static void harmadikF() {
            int[] t = { 3, 37, 18, 3, 3, 3, 28, 27, 39, 40 };
            
            int maxCount = 0;
            for (int i = 0; i < t.Length; i++) {
                int count = 0;
                for (int j = 0; j < t.Length; j++) {
                    if (t[i] == t[j]) {
                        count++;
                    }

                }
                if(count > maxCount) {
                    maxCount = count;
                }

            }
            Console.WriteLine(maxCount);


        }

        static void negyedikF() {
            int[] t = { 3, 37, 0, 38, 3, 3, 28, 27, 39, 40 };
            int i = 0;
            while(i<t.Length&& t[i] != 0) {
                i++;
            }
            if (i < t.Length) {
                Console.WriteLine("volt");
            } else {
                Console.WriteLine("nem");
            }

        }

    }
}
