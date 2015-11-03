using System;

class Program {
    static void Main(string[] args) {
        int xa = cin.ni();
        int ya = cin.ni();
        int xb = cin.ni();
        int yb = cin.ni();
        int xc = cin.ni();
        int yc = cin.ni();


        xb -= xa;
        yb -= ya;
        xc -= xa;
        yc -= ya;

        double area = Math.Abs(xb * yc - yb * xc) / 2.0d;

        Console.WriteLine(area);
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

