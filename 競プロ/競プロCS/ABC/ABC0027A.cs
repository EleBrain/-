using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {
    static void Main(string[] args) {
        int l1 = cin.ni();
        int l2 = cin.ni();
        int l3 = cin.ni();

        if(l1 == l2) {
            Console.WriteLine(l3);
        } else if(l1 == l3) {
            Console.WriteLine(l2);
        } else if (l2 == l3) {
            Console.WriteLine(l1);
        }

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