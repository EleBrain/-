using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {
    static void Main(string[] args) {

        string s = cin.next();

        SortedList<string, int> counts = new SortedList<string, int>();

        counts.Add("A", 0);
        counts.Add("B", 0);
        counts.Add("C", 0);
        counts.Add("D", 0);
        counts.Add("E", 0);
        counts.Add("F", 0);

        foreach (var item in s) {
            counts[item.ToString()]++; 
        }

        Console.WriteLine(string.Join(" ", counts.Values));

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