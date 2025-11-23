static void Main(string[] args) {

    int a = 3;
    int x = 42;
    int b = 7;
    int modgec = 100;

    for (int i = 0; i < 5; i++) {
        x = ((a * x + b) % modgec);
        Console.WriteLine(x);
    }




    //}
}