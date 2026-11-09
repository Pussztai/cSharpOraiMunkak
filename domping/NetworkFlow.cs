using System;

class Program
{
    static int csucsokSzama = 6; // csúcsok száma
    static int[,] kapacitas = new int[6, 6];  // élek kapacitása
    static int[,] aramlas = new int[6, 6];    // éleken átfolyt áram
    static bool[] meglatogatott = new bool[6]; // DFS jelölés

    // DFS útkeresés a Ford-Fulkersonhoz
    static int DFS(int aktualis, int nyelo, int maximalis)
    {
        if (aktualis == nyelo) return maximalis; // elértük a nyelőt

        meglatogatott[aktualis] = true;

        for (int kovCsucs = 0; kovCsucs < csucsokSzama; kovCsucs++)
        {
            int szabadKapacitas = kapacitas[aktualis, kovCsucs] - aramlas[aktualis, kovCsucs];

            if (!meglatogatott[kovCsucs] && szabadKapacitas > 0)
            {
                int kuldheto = DFS(kovCsucs, nyelo, Math.Min(maximalis, szabadKapacitas));
                if (kuldheto > 0)
                {
                    aramlas[aktualis, kovCsucs] += kuldheto;
                    aramlas[kovCsucs, aktualis] -= kuldheto;
                    return kuldheto;
                }
            }
        }

        return 0; // nincs út
    }

    static void Main()
    {
        // -------- Kapacitások beállítása --------
        kapacitas[0, 1] = 8;
        kapacitas[0, 4] = 3;
        kapacitas[1, 2] = 9;
        kapacitas[2, 4] = 7;
        kapacitas[2, 5] = 2;
        kapacitas[4, 3] = 4;
        kapacitas[4, 2] = 7;
        kapacitas[3, 5] = 5;

        int forras = 0; // forrás csúcs
        int nyelo = 5;  // nyelő csúcs

        int maximalisAram = 0;

        // -------- Ford-Fulkerson ciklus --------
        while (true)
        {
            // jelölések nullázása minden iterációban
            for (int i = 0; i < csucsokSzama; i++)
                meglatogatott[i] = false;

            int kuldott = DFS(forras, nyelo, int.MaxValue);

            if (kuldott == 0) break; // nincs több út

            maximalisAram += kuldott;
        }

        Console.WriteLine("Maximális áramlás: " + maximalisAram);
    }
}
