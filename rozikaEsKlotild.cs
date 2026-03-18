using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rozikaEsKlotild {
    internal class Program {
        static void Main(string[] args) {
            int k = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (k <= n) {
                k += k;
                i += 1;
            }
            Console.WriteLine(i);
        }
    }
}
