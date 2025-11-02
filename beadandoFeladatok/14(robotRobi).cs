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
            char[] t = {'E','E', 'D', 'D', 'N', 'D', 'N', 'K', 'N', 'E', 'N', 'E', 'N', 'E', 'N', 'E', 'D', 'D', 'K', 'K', 'N' };
            int aksi = 50;
            int i = 0;
            
            while (i < t.Length) {
                aksi += 5;
                if (i==0||t[i] != t[i-1]) {
                    aksi += 3;
                } 
                i++;
            }

            if(aksi > 200) {
                Console.WriteLine("kurvara nem eleg");
            } else {
                Console.WriteLine("eleg");
            }
            




        }

        static void masodikF() {
            char[] t = { 'E', 'D', 'D', 'N', 'D', 'N', 'K', 'N', 'E', 'N', 'E', 'N', 'E', 'N', 'E', 'D', 'D', 'K', 'K', 'N' };
            int count = 0;

            for (int i = 0; i < t.Length - 1; i++) {
                if ((t[i] == 'E' && t[i + 1] == 'D') ||
                    (t[i] == 'D' && t[i + 1] == 'E') ||
                    (t[i] == 'N' && t[i + 1] == 'K') ||
                    (t[i] == 'K' && t[i + 1] == 'N')) {
                    count++;
                }
            }

            Console.WriteLine(count);



        }

        static void harmadikF() {
            char[] t = { 'E', 'D', 'D', 'N', 'D', 'N', 'K', 'N', 'E', 'N', 'E', 'N', 'E', 'N', 'E', 'D', 'D', 'K', 'K', 'N' };


            string ujsorozat = "";
            int i = 0;
            while (i < t.Length - 1) {
                if ((t[i] == 'E' && t[i + 1] == 'D') ||
                    (t[i] == 'D' && t[i + 1] == 'E') ||
                    (t[i] == 'N' && t[i + 1] == 'K') ||
                    (t[i] == 'K' && t[i + 1] == 'N')) {
                    i += 2;
                } else {
                    ujsorozat += t[i];
                    i++;
                }
                
            }
            Console.WriteLine(ujsorozat);
            


        }

        static void negyedikF() {
            char[] t = { 'E', 'D', 'D', 'N', 'D', 'N', 'K', 'N', 'E', 'N', 'E', 'N', 'E', 'N', 'E', 'D', 'D', 'K', 'K', 'N' };

            int x = 0; 
            int y = 0; 
            foreach(char cucc in t) {
                switch (cucc) {
                    case 'E':
                        x ++ ;
                        break;
                    case 'D':
                        x -- ;
                        break;
                    case 'K':
                        y ++ ;
                        break;
                    default:
                        y --;
                        break;
                }
            }

            Console.WriteLine(Math.Abs(x) + Math.Abs(y));

        }

    }
}
