﻿using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        string s = Console.ReadLine();
        string answer = "NO";
        if (s == "" ||
            (s[s.Length - 2] == 'c' && s[s.Length - 1] == 'h') ||
            s[s.Length - 1] == 'o' ||
            s[s.Length - 1] == 'k' ||
            s[s.Length - 1] == 'u') {

            answer = "YES";

        }

        Console.WriteLine(answer);
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