using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {
    static void Main(string[] args) {
        int n = cin.ni();
        string s = Console.ReadLine();
        string b = "b";
        if (s == b) {
            Console.WriteLine(0);
            return;
        }

        for (int i = 1; i < n + 1; i++) {
            if (i % 3 == 1) {
                b = "a" + b + "c";
            } else if (i % 3 == 2) {
                b = "c" + b + "a";
            } else {
                b = "b" + b + "b";
            }
            if (s == b) {
                Console.WriteLine(i);
                return;
            }
        }

        Console.WriteLine(-1);
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