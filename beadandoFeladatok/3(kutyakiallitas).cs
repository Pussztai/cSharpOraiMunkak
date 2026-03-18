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


            //            int osszeg = 0;
            //            int maxosszeg = 0;
            //            int nyerteskutyaID = 0;
            //            for (int i = 1; i < t.Length-1; i++) {
            //                if(i % 3 == 0) {

            //                    osszeg = 0;

            //                } else {
            //                    osszeg += t[i];
            //                    if (osszeg > maxosszeg) {
            //                        maxosszeg = osszeg;
            //                        nyerteskutyaID = i;
            //                    }
            //                }

            //            }
            //            Console.WriteLine(nyerteskutyaID);

            int[] t = { 10, 4, 7, 3, 8, 6, 9, 8, 10, 5, 8, 10 };
            int maxOsszeg = 0;
            int veglegesOsszeg = 0;
            int nyertesKutya = 0;
            for (int i = 0; i < 3; i++) {
                maxOsszeg = 0;
                for (int j = 0; j < 4; j++) {
                    maxOsszeg += i * 4 + j;
                    
                }
                if(maxOsszeg > veglegesOsszeg) {
                    veglegesOsszeg = maxOsszeg;
                    nyertesKutya = i + 1;
                }
            }
            Console.WriteLine();

        }
        static void masodikF() {
            int[] t = { 10, 4, 7, 3, 8, 6, 9, 8, 10, 5, 8, 10 };
            //int osszegElsoKat = 0;
            //int elsoCount = 0;
            //for (int i = 0; i < t.Length; i+=3) {
            //    osszegElsoKat += t[i];
            //    elsoCount++;
            //}
            //Console.WriteLine($"Elso kategoria atlag: " + (double)osszegElsoKat/elsoCount);

            //int osszegMasodikKat = 0;
            //int SecCount = 0;
            //for (int i = 1; i < t.Length-1; i += 3) {
            //    osszegMasodikKat += t[i];
            //    SecCount++;
            //}
            //Console.WriteLine($"Elso kategoria atlag: " + (double)osszegMasodikKat / SecCount);

            //int osszegHarmadikKat = 0;
            //int thirdCount = 0;
            //for (int i = 2; i < t.Length; i += 3) {
            //    osszegHarmadikKat += t[i];
            //    thirdCount++;
            //}
            //Console.WriteLine($"Elso kategoria atlag: " + (double)osszegHarmadikKat / thirdCount);

            //jobb valtozat

            int osszegElsoKat = 0, elsoCount = 0;
            int osszegMasodikKat = 0, masodikCount = 0;
            int osszegHarmadikKat = 0, harmadikCount = 0;

            for (int i = 0; i < t.Length; i++) {
                if (i % 3 == 0) {
                    osszegElsoKat += t[i];
                    elsoCount++;
                } else if (i % 3 == 1) {
                    osszegMasodikKat += t[i];
                    masodikCount++;
                } else {
                    osszegHarmadikKat += t[i];
                    harmadikCount++;
                }
            }

            Console.WriteLine("elso : " + (double)osszegElsoKat/elsoCount);
            Console.WriteLine("masodik : " + (double)osszegMasodikKat/masodikCount);
            Console.WriteLine("harmadik : " + (double)osszegHarmadikKat/harmadikCount);
        }

        static void harmadikF() {
            int[] t = { 10, 4, 7, 3, 8, 6, 9, 8, 10, 8, 5, 10 };

            int okossagCount = 0;
            for (int i = 0; i < t.Length; i++) {
                if(i % 3 == 0) {
                    if (t[i] > t[i + 1]) {
                        okossagCount++;
                    }
                }

            }
            Console.WriteLine(okossagCount + " volt okosabb nigga");
        }

        static void negyedikF() {
            int[] t = { 10, 10, 7, 3, 8, 6, 9, 8, 10, 8, 5, 10 };
            int pontszamOsszegek = 0;
            int maxiPont = 0;
            int db = 0;
            for (int i = 0; i < t.Length; i++) {
                pontszamOsszegek += t[i];
                if ((i + 1) % 3 == 0) {
                    if(pontszamOsszegek == maxiPont) {
                        db++;
                    }
                    if(pontszamOsszegek > maxiPont) {
                        maxiPont = pontszamOsszegek;

                    }
                    pontszamOsszegek = 0;
                }

            }

            bool voltEHoltverseny = (db >= 1);

            Console.WriteLine(voltEHoltverseny);
        }






    }
}
