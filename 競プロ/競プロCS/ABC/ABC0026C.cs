using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {
    static void Main(string[] args) {
        int n = cin.ni();
        int[] salary = new int[n];
        List<int>[] sub = new List<int>[n];
        for (int i = 0; i < n; i++) {
            sub[i] = new List<int>();
        }
        for (int i = 1; i < n; i++) {
            sub[cin.ni() - 1].Add(i);
        }
        for (int i = n - 1; i >= 0; i--) {
            if (sub[i].Any()) {
                salary[i] = sub[i].Min(s => salary[s]) + sub[i].Max(s => salary[s]) + 1;
            } else {
                salary[i] = 1;
            }
        }

        Console.WriteLine(salary[0]);

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