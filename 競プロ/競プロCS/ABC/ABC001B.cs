using System;

class Program {
    static void Main(string[] args) {
        int m = cin.ni();
        int vv;
        if (m < 100) {
            vv = 0;
        } else if (m <= 5000) {
            vv = m / 100;
        } else if (m <= 30000) {
            vv = m / 1000 + 50;
        } else if (m <= 70000) {
            vv = (m / 1000 - 30) / 5 + 80;
        } else {
            vv = 89;
        }
        Console.WriteLine(vv.ToString("D2"));

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

