using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {
    static void Main(string[] args) {
        int n = cin.ni();
        int a = cin.ni();
        int b = cin.ni();
        int now = 0;
        for (int i = 0; i < n; i++) {
            string s = cin.next();
            if (s == "East") {
                now += Math.Min(Math.Max(cin.ni(), a), b);
            } else {
                now -= Math.Min(Math.Max(cin.ni(), a), b);
            }
        }
        string d = "";
        if (now > 0) {
            d = "East ";
        } else if (now < 0) {
            d = "West ";
        }
        Console.WriteLine(d + Math.Abs(now));
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