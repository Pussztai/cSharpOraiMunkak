using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terkovezes {
    internal class Program {
        static void Main(string[] args) {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int oszlop = (int)Math.Ceiling((double)a / c);
            int sor = (int)Math.Ceiling((double)b / c);

            Console.WriteLine(oszlop*sor);
        }
    }
}
