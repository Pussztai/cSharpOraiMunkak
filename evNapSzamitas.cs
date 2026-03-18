using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvNapSzamitas {
    internal class Program {
        static void Main(string[] args) {
            int szuletesiEv = Convert.ToInt32(Console.ReadLine());
            int szuletesiHonap = Convert.ToInt32(Console.ReadLine());
            int szuletesiNap= Convert.ToInt32(Console.ReadLine());

            int celEv = Convert.ToInt32(Console.ReadLine());
            int celHonap = Convert.ToInt32(Console.ReadLine());
            int celNap = Convert.ToInt32(Console.ReadLine());

            int szuletesiOssz = szuletesiEv * 365 + szuletesiHonap * 30 + szuletesiNap;
            int celOssz = celEv * 365 + celHonap * 30 + celNap;

            Console.WriteLine(celOssz-szuletesiOssz);
        }
    }
}
