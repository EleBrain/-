﻿using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int n = cin.ni();
        int[] pens = new int[1000002];

        for (int i = 0; i < n; i++) {
            int a = cin.ni();
            int b = cin.ni();
            pens[a]++;
            pens[b + 1]--;
        }
        for (int i = 1; i < pens.Length; i++) {
            pens[i] += pens[i - 1];
        }
        Console.WriteLine(pens.Max());
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