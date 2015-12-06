using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {
    static void Main(string[] args) {
        string[] cards = new string[] { "1", "2", "3", "4", "5", "6" };
        int n = cin.ni();

        n -= (n / 30) * 30;

        for (int i = 0; i < n; i++) {
            int mod = i % 5;
            string tmp = cards[mod];
            cards[mod] = cards[mod + 1];
            cards[mod + 1] = tmp;
        }

        Console.WriteLine(string.Concat(cards));

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