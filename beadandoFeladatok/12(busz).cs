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

            harmadikF();
            //negyedikF();


        }

        static void elsoF() {
            int[] t = { 10, 0, 18, 15, 22, 10, 14, 28, 4, 6, 0, 9 }; 
            int i = 0;
            while (i < t.Length - 2 && t[i] > t[i + 1]) {
                i+=2; 
            }
            if (i < t.Length - 2) {
                Console.WriteLine("nem igaz");
                Console.WriteLine(i);
            } 
            else { Console.WriteLine("igaz"); 
            }




        }

        static void masodikF() {
            int[] t = { 2, 0, 4, 1, 15, 11, 100, 14, 16, 2, 0, 109 };
            int maxi = 0;

            for (int i = 0; i < t.Length; i += 2) {
                if (t[i] > t[maxi]) {
                    maxi = i;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine(t[maxi]);



        }

        static void harmadikF() {
            int[] t = { 2, 0, 4, 1, 15, 11, 100, 14, 16, 2, 0, 109 };
            int ulohelyekSZ = 50;
            int buszHely = 0;    
            int counter = 0;     

            for (int i = 0; i < t.Length; i += 2) 
            {
                buszHely += t[i];     
                buszHely -= t[i + 1]; 

                  

                if (buszHely > ulohelyekSZ)
                    counter++;        
            }

            Console.WriteLine(counter);


        }

        static void negyedikF() {
            int[] t = { 2, 0, 4, 1, 15, 11, 100, 14, 16, 2, 0, 109};
            int ulohelyekSZ = 50;
            int buszHely = 0;

            int i = 0;
            while (i<t.Length&& buszHely < ulohelyekSZ * 2) {
                buszHely += t[i];
                buszHely -= t[i + 1];
                i += 2;
            }

            if (i < t.Length) {
                Console.WriteLine("volt");
            } else {
                Console.WriteLine("nem volt");
            }

        }

    }
}
