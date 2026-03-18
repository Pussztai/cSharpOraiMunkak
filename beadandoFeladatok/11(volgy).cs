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
            int[] t = { 0, 500, 100, 700, 350, 650, 20, 550, 10, 0 };
            int legnagyobbVolgy = 0;
            for (int i = 1; i < t.Length-1; i++) {

                if ((t[i-1] > t[i] && t[i] < t[i+1]) && t[i] > legnagyobbVolgy) {
                    legnagyobbVolgy = t[i];
                }

            }

            Console.WriteLine(legnagyobbVolgy);

        }

        static void masodikF() {
            int[] t = { 0, 500, 100, 700, 350, 650, 20, 550, 10, 0 };
            int mini = 0;
            for (int i = 1; i < t.Length-1; i++) {
                if (t[i-1] < t[i] && t[i] > t[i + 1]) {
                    if (t[i] < t[mini]) {
                        mini = i;
                    }
                }

            }
            Console.WriteLine(mini + 1);

        }

        static void harmadikF() {
            int[] t = { 0, 500, 100, 700, 350, 650, 20, 550, 10, 0 };
            int szintK = 500;
            int count = 0;
            for (int i = 1; i < t.Length-1; i++) {
                int kulonbseg = Math.Abs(t[i] - t[i + 1]);
                if (kulonbseg > szintK) {
                    count++;
                }

            }
            Console.WriteLine(count);

        }

        static void negyedikF() {
            int[] t = { 0, 500, 100, 700, 350, 650, 20, 550, 10, 0 };
            int lejtoC = 1;
            int maxLejtoC = 0;
            for (int i = 1; i < t.Length-1; i++) {
                if (t[i] > t[i + 1]) {
                    lejtoC++;
                } else {
                    lejtoC = 1;
                }if(lejtoC > maxLejtoC) {
                    maxLejtoC = lejtoC;
                }

            }
            Console.WriteLine(maxLejtoC);
        }

    }
}
