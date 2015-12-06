using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        char[] s = cin.next().ToCharArray();
        int n = cin.ni();

        for (int i = 0; i < n; i++) {
            int l = cin.ni() - 1;
            int r = cin.ni() - 1;
            char[] rvs = s.Skip(l).Take(r - l + 1).Reverse().ToArray();

            for (int j = 0; j <= r - l; j++) {
                s[l + j] = rvs[j];
            }
        }
        Console.WriteLine(s);
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