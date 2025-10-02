using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faGráf {
    internal class Program {
        static void Main(string[] args) {
            int[] t = new int[] { 1, 5, 5, 4, 2, 30, 0 };
            int i = 0;
            while (i < t.Length && t[i] != 0) {
                i++;
            }
            if (i < t.Length) {
                int index = (int)Math.Floor(i / 2.0);
                int index2 = (int)Math.Floor(i / 2.0 + 1);
                if (t[index] == 0 || t[index2] == 0) {
                    Console.WriteLine("False Rossz a sorozat");
                }else if (t[index] != 0 || t[index2] != 0) {
                    Console.WriteLine("True Jo a sorozat");
                }
            }  

            Console.WriteLine("vege");
        }
    }
}
