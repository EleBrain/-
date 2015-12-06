using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int a = cin.ni();
        int b = cin.ni();
        int c = cin.ni();

        int ar = 1;
        int br = 1;
        int cr = 1;

        if (a < b) {
            ar++;
        } else {
            br++;
        }
        if (a < c) {
            ar++;
        } else {
            cr++;
        }
        if (b < c) {
            br++;
        } else {
            cr++;
        }

        Console.WriteLine(ar);
        Console.WriteLine(br);
        Console.WriteLine(cr);

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