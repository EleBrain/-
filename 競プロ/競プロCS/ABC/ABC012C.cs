using System;

class Program {
    static void Main(string[] args) {
        int n = 2025 - cin.ni();

        for (int i = 1; i < 10; i++) {
            for (int j = 1; j < 10; j++) {
                int ans = i * j;
                if (ans == n) {
                    Console.WriteLine(i + " x " + j); 
                }
                if (ans >= n) continue;
            }
        }
    }
}

public class cin {
    private static string[] s = new string[0];
    private static int i = 0;

    private static char[] cs = new char[] { ' ' };

    public static string next() {
        if (i < s.Length) return s[i++];
        string st = Console.ReadLine();
        while (st == "") st = Console.ReadLine();
        s = st.Split(cs, StringSplitOptions.RemoveEmptyEntries);
        i = 0;
        return next();
    }

    public static int ni() {
        return int.Parse(next());
    }

    public static long nextLong() {
        return long.Parse(next());
    }

    public static double nextDouble() {
        return double.Parse(next());
    }

}