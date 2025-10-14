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
            int[] t = { 101, 138, 112, 121, 176, 163, 123, 210, 226 };
            int count = 0;
            for (int i = 1; i < t.Length-1; i++) {
                if (t[i] > t[i-1]) {
                    count++;
                }

            }
            Console.WriteLine(count);

            

        }
        static void masodikF() {
            int[] t = { 101, 138, 112, 121, 176, 163, 123, 226, 210 };
            int count = 0;
            for (int i = 1; i < t.Length-1; i++) {
                if (t[i-1] < t[i] && t[i] > t[i + 1]) {
                    count++;
                }

            }
            Console.WriteLine(count);
            
        }

        static void harmadikF() {
            int[] t = { 101, 138, 112, 112, 176, 163, 123, 226, 210 };
            int i = 1;
            while(i<t.Length-1 && t[i] != t[i - 1]) {
                i++;
            }
            Console.WriteLine(i);

            

            
        }

        static void negyedikF() {
            int[] t = { 101, 138, 112, 112, 176, 163, 123, 226, 210 };
            int maxi = 0;
            for (int i = 1; i < t.Length-1; i++) {
                //if (t[i] > t[i - 1]) {
                //    if(t[i] - t[i-1] > maxi) {
                //        maxi = t[i] - t[i - 1];
                //    }
                //} else {
                //    if (t[i-1] - t[i] > maxi) {
                //        maxi = t[i - 1] - t[i];
                //    }
                //}
                if (t[i] - t[i-1] > maxi) {
                    maxi = t[i] - t[i - 1];
                }

            }
            Console.WriteLine(maxi);
        }






    }
}
