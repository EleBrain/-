using System;              
using System.Collections.Generic;
using System.Linq;

class Program {

    static void Main(string[] args) {
        Dictionary<string, int> rd = new Dictionary<string, int>();
        int n = cin.ni();
        for (int i = 0; i < n; i++) {
            string s = cin.next();
            if (!rd.ContainsKey(s)) rd[s] = 0;
            rd[s]++;
        }

        Console.WriteLine(rd.First(d => d.Value == rd.Max(r => r.Value)).Key);
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