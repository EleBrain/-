using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int l = cin.ni();
        int h = cin.ni();
        int n = cin.ni();
        for (int i = 0; i < n; i++) {
            int a = cin.ni();

            if (a > h) {
                Console.WriteLine(-1);
            } else if (a >= l && a <= h) {
                Console.WriteLine(0);
            } else {
                Console.WriteLine(l - a);
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