static void Main() {
    int[] t = { 3, 4, 1, 5, 6, 3 };
    for (int i = 0; i < t.Length-1; i++) {
        for (int j = 0; j < t.Length- i-1; j++) {
            if (t[j] > t[j + 1]) {
                int temp = t[j];
                t[j] = t[j+1];
                t[j + 1] = temp;
            }
        }
    }


    foreach (int item in t) {
        Console.WriteLine(item);
    }
    
}