using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurzioGyakorlas {
    internal class Program {

        //osszegzes

        static int osszegzesAlap(List<int> t,int counter,int index) {
            if (index == t.Count) {
                return counter;
            }
            return osszegzesAlap(t, t[index] + counter, index + 1);
        }

        static int osszegzesNemParameter(List<int> t, int index) {
            if(index == t.Count) {
                return 0;
            }
            return t[index] + osszegzesNemParameter(t, index + 1);
        }

        static int osszegzesFelezes(List<int> t,int left,int rigth) {
            if(left > rigth) {
                return 0;
            }
            if(left == rigth) {
                return t[left];
            }
            int middle = (left + rigth) / 2;
            return osszegzesFelezes(t, left, middle) + osszegzesFelezes(t, middle + 1, rigth);
        }

        //megszamolas

        static int megszamolasAlap(List<int> t, int counter, int index) {
            if (index == t.Count) {
                return counter;
            }
            if (t[index] % 2 == 0) {
                return megszamolasAlap(t, counter + 1, index);
            }
            return megszamolasAlap(t, counter, index + 1);
        }

        static int megszamolVisszafele(List<int> t,int counter,int index) {
            if(index < 0) {
                return counter;
            }
            if (t[index] % 2 == 0) {
                return megszamolVisszafele(t, counter + 1, index-1);
            }
            return megszamolVisszafele(t, counter, index-1);
        }

        static int megszamolFelezve(List<int> t, int left, int rigth, int counter) {
            if (left > rigth) {
                return 0;
            }
            if (rigth == left) {
                if (t[left] % 2 == 0) {
                    return 1;
                }
                return 0;
            }

            int middle = (left + rigth) / 2;
            return megszamolFelezve(t, left, middle, counter) + megszamolFelezve(t, middle + 1, rigth, counter);
        }

        //eldontes
        static bool eldontesAlap(List<int> t,int index) {
            if (index == t.Count) {
                return false;
            }
            if (t[index] % 3 == 0) {
                return true;
            }
            return eldontesAlap(t, index + 1);
        }

        static bool eldontesFelezve(List<int> t,int left,int rigth) {
            if(left > rigth) {
                return false;
            }
            if(left == rigth) {
                if (t[left] % 3 == 0) {
                    return true;

                }
                return false;
            }
            int middle = (left + rigth) / 2;

            return eldontesFelezve(t, left, middle) || eldontesFelezve(t, middle + 1, rigth);
        }



        //kivalasztas
        static int kivalasztasAlap(List<int> t,int index) {
            if(index == t.Count) {
                return -1;
            }
            if (t[index] % 3 == 0) {
                return index;
            }
            return kivalasztasAlap(t, index+1);
        }

        static int kivalasztasFelezve(List<int> t,int left,int rigth) {
            if(left > rigth) {
                return -1;
            }
            if(left == rigth) {
                if (t[left] % 3 == 0) {
                    return left;
                }
                return -1;
            }
            int middle = (left + rigth) / 2;

            int bal = kivalasztasFelezve(t, left, middle);
            if(bal != -1) {
                return kivalasztasFelezve(t, left, middle);
            } else {
                return kivalasztasFelezve(t,middle+1,rigth);
            }
        }

        //linearis kereses

        static int linearisKeres(List<int> t,int index) {
            if(index == t.Count) {
                return -1;
            }

            if (t[index] % 3 == 0) {
                return index;
            } 
            //return -1;
            

            return linearisKeres(t, index + 1);
        }


        //maximum kiv

        static int maximumFelezve(List<int> t,int left,int rigth,int maxi) {
            if (left>rigth) {
                return maxi;
            }
            if(left == rigth) {
                if (t[left] > t[maxi]) {
                    maxi = left;
                   
                }
                return maxi;

            }
            int middle = (left + rigth) / 2;
            int bal = maximumFelezve(t, left, middle, maxi);
            int jobb = maximumFelezve(t, middle + 1, rigth, bal);
            return jobb;
        }

        static int maximumAlap(List<int> t,int maxi,int index) {
            if(index == t.Count) {
                return maxi;
            }
            if (t[index] > t[maxi]) {
                maxi = index;
            }
            return maximumAlap(t, maxi, index + 1);
        }

        

        static int kristalyozunk(int szint,int db,int osszeg) {
            if (szint == 0) {
                return osszeg;
            }
            return kristalyozunk(szint - 1, db * 2, osszeg += (db*szint * 10));
        }


        static int bela(int[] t,int index,int ugras) {
            if(index >= t.Length) {
                return ugras;
            }
            if(ugras == 100) {
                return ugras;
            }
            if (index < 0) {
                return ugras;
            }

            if (t[index] % 2 == 0) {
                return bela(t, index+2, ugras +1);
            } else {
                return bela(t, index - 1, ugras + 1);
            }
            
        }

        static List<int> feltoltes(List<int> t,Random rnd,int counter) {
            if(counter == 10) {
                return t;
            }
            
            t.Add(rnd.Next(1, 50));
            return feltoltes(t, rnd, counter + 1);
        }


        //EMANOS PDF 2


        static int LegnagyobbEnergia(List<int> t,int index,int left,int rigth) {
            if (left>rigth) {
                return index;
            }
            if(left == rigth) {
                if (t[left] > t[index]) {
                    index = left;
                }
                return index;
            }
            int mddle = (left + rigth) / 2;
            int bal = LegnagyobbEnergia(t, index, left, mddle);
            return LegnagyobbEnergia(t, bal, mddle + 1, rigth);
        }

        static void Tisztitasa(int[,] t,ref int mana,int x,int y) {
            if(x < t.GetLength(0) && y < t.GetLength(1) && x>= 0 && y >= 0&& t[x,y] == 1) {
                t[x, y] = 2;
                mana--;
                Tisztitasa(t,ref mana, x + 1, y);
                Tisztitasa(t,ref mana, x -1, y);
                Tisztitasa(t,ref mana, x, y+1);
                Tisztitasa(t,ref mana, x, y-1);
            }
            //return;
        }



        static int ToronyMaszas(int n) {
            if(n == 1) {
                return 1;
            }
            if (n == 2) {
                return 1;
            }
            if(n == 3) {
                return 2;
            }
            return ToronyMaszas(n - 1) + ToronyMaszas(n - 3);

        }


        static void Main(string[] args) {
            //List<int> t = new List<int>() { 2, 2,1, 5, 2,2,3 };
            //Console.WriteLine(osszegzesAlap(t,0,0));
            //Console.WriteLine(osszegzesNemParameter(t,0));
            //Console.WriteLine(osszegzesFelezes(t,0,t.Count-1));

            //Console.WriteLine(megszamolasAlap(t,0,0));
            //Console.WriteLine(megszamolVisszafele(t,0,t.Count-1));
            //Console.WriteLine(megszamolFelezve(t,0,t.Count-1,0));

            //Console.WriteLine(eldontesAlap(t, 0));
            //Console.WriteLine(eldontesFelezve(t,0,t.Count-1));


            //Console.WriteLine(kivalasztasAlap(t,0));
            //Console.WriteLine(kivalasztasFelezve(t,0,t.Count-1));


            //Console.WriteLine(linearisKeres(t,0));

            //Console.WriteLine(maximumFelezve(t, 0,t.Count-1,0));
            //Console.WriteLine(maximumAlap(t,0,0));


            //EMANOS PDF DOMPING REKURZIO

            //Console.WriteLine(kristalyozunk(3,1,0));

            //int[] t = new int[] { 2, 3, 4 };

            //int ugras = bela(t, 0, 0);
            //if (ugras < 0) {
            //    Console.WriteLine("Kizuhant");
            //} else if(ugras == 100) {
            //    Console.WriteLine("bennt maradt hetvegere");
            //} else {
            //    Console.WriteLine("Kijutott");
            //}

            //List<int> t = new List<int>();
            //Random rnd = new Random();
            //List<int> t2 = feltoltes(t, rnd, 0);
            //foreach (int item in t2) {
            //    Console.WriteLine(item);
            //}


            //List<int> t = new List<int>() { 12, 45, 7, 89, 23, 56, 4 };
            //Console.WriteLine(LegnagyobbEnergia(t,0,0,t.Count-1));

            //int[,] t = new int[5, 5] {
            //    { 0, 1, 0, 0, 0 },
            //    { 1, 1, 1, 1, 1 },
            //    { 0, 1, 0, 0, 1 },
            //    { 0, 0, 0, 1, 0 },
            //    { 1, 0, 0, 0, 0 }
            //};

            //int mana = 10;
            //Tisztitasa(t, ref mana, 1, 1);
            //Console.WriteLine(mana);

            //Console.WriteLine(ToronyMaszas(5));
        }
    }
}
