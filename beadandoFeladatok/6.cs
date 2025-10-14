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
            masodikF();
            //harmadikF();
            //negyedikF();
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
            

            
        }

        static void negyedikF() {
            
        }






    }
}
