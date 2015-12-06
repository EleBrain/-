using System;

class Program {
    static void Main(string[] args) {
        int n = cin.ni();
        int x = cin.ni();
        int total = 0;

        for (int i = 0; i < n; i++) {
            int tmp = cin.ni();
            if ((x & 1) == 1) {
                total += tmp;
            }
            x = x >> 1;
        }

        Console.WriteLine(total);
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