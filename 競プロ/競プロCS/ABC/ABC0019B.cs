using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {
    static void Main(string[] args) {
        string s = cin.next();
        StringBuilder res = new StringBuilder();
        char lastChar = s[0];
        int count = 1;
        for (int i = 1; i < s.Length; i++) {
            if (s[i] == lastChar) {
                count++;
            } else {
                res.Append(lastChar);
                res.Append(count);
                count = 1;
                lastChar = s[i];
            }
        }
        res.Append(lastChar);
        res.Append(count);
        Console.WriteLine(res);

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