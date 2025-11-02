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
            int szigetC = 0;
            double[] t = { 0, 10, 100, 700, 350.0, 0, 0, 0, 20, 50, 10, 0 };
            double elozo = 0;
            for (int i = 0; i < t.Length; i++) {
                if (elozo == 0 && t[i] != 0) {
                    szigetC++;
                }
                elozo = t[i];
                

            }
            Console.WriteLine(szigetC);

        }

        static void masodikF() {
            double[] t = { 0, 10, 100, 700, 350.0, 0, 0, 0, 20, 50, 10, 0 };
            int szigetC = 0;
            int maxSzigetC = 0;
            for (int i = 0; i < t.Length; i++) {
                if (t[i] > 0) {
                    szigetC++;
                } else {
                    szigetC = 0;
                }
                    
                if (szigetC > maxSzigetC) {
                    maxSzigetC = szigetC;
                }



                
            }
            Console.WriteLine(maxSzigetC);
        }

        static void harmadikF() {
            double[] t = { 0, 10, 100, 700, 350.0, 0, 0, 0, 20, 50, 10, 10 };
            int i = 0;
            while(i<t.Length-1 && !(t[i] > 0 &&t[i] == t[i+1])) {
                i++;
            }
            if (i < t.Length-1) {
                Console.WriteLine( "van");
            } else {
                Console.WriteLine("nincs");
            }

        }

        static void negyedikF() {
            double[] t = { 0, 10, 100, 200, 350.0, 0, 0, 0, 20, 50, 10, 10 };
            int maxi = 0;
            for (int i = 1; i < t.Length; i++) {
                if (t[i] > t[maxi]) {
                    maxi = i;
                }

            }
            Console.WriteLine(maxi+1);
        }

    }
}
