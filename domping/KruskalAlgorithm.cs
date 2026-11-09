
class Program {
    static void Main() {
        int n = 4; // csúcsok száma
        int m = 5; // élek száma

        int[] U = { 0, 0, 1, 1, 2 };
        int[] V = { 1, 2, 2, 3, 3 };
        int[] W = { 4, 2, 5, 1, 3 };

        // ----------- 1. BUBORÉKOS RENDEZÉS SÚLY SZERINT -----------
        for (int i = 0; i < m - 1; i++) {
            for (int j = 0; j < m - i - 1; j++) {
                if (W[j] > W[j + 1]) {
                    int t;

                    t = W[j]; W[j] = W[j + 1]; W[j + 1] = t;
                    t = U[j]; U[j] = U[j + 1]; U[j + 1] = t;
                    t = V[j]; V[j] = V[j + 1]; V[j + 1] = t;
                }
            }
        }

        // ----------- 2. UNION-FIND SZUPER-EGYSZERŰ FORMÁBAN -----------
        int[] parent = new int[n];
        for (int i = 0; i < n; i++)
            parent[i] = i;

        int Find(int x) {
            while (parent[x] != x)
                x = parent[x];
            return x;
        }

        // ----------- 3. KRUSKAL ALGORTIMUS (MINIMÁLIS FESZÍTŐFA) -----------
        Console.WriteLine("MST:");
        int count = 0;

        for (int i = 0; i < m; i++) {
            int a = U[i];
            int b = V[i];

            int ra = Find(a);
            int rb = Find(b);

            if (ra != rb) // nem alkot kört
            {
                Console.WriteLine(a + " - " + b + " (súly: " + W[i] + ")");
                parent[rb] = ra; // union
                count++;

                if (count == n - 1)
                    break;
            }
        }
    }
}