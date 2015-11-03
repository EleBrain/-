using System;

class Program {
    static void Main(string[] args) {
        string W = cin.next();

        W = W.Replace("a", "");
        W = W.Replace("i", "");
        W = W.Replace("u", "");
        W = W.Replace("e", "");
        W = W.Replace("o", "");
        Console.WriteLine(W);

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

