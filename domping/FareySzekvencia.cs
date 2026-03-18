internal class Program {

    
    static bool gcd(int a,int b) {

        while (b != 0) {
            int r = a % b;
            a = b;
            b = r;
        }
        return a == 1;
    }
    

    static void Main(string[] args) {


        int n = 5;
        
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j < i; j++) {
                if (gcd(i, j)) {
                    Console.WriteLine($"{j}/{i}");
                }
            }
        }

        


    }
}