using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int n = cin.ni();
        int[] a = new int[n];
        for (int i = 0; i < n; i++) {
            a[i] = cin.ni();
        }

        Console.WriteLine(Math.Ceiling(a.Where(s => s != 0).Average()));
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