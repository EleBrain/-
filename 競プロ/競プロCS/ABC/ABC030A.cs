using System;

class Program {
    static void Main(string[] args) {
        double tm = cin.nextInt();
        double tw = cin.nextInt();
        double am = cin.nextInt();
        double aw = cin.nextInt();

        double tr = tw / tm;
        double ar = aw / am;
        if (tr > ar) {
            Console.WriteLine("TAKAHASHI");
        } else if (tr < ar) {
            Console.WriteLine("AOKI");
        } else {
            Console.WriteLine("DRAW");
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

    public static int nextInt() {
        return int.Parse(next());
    }

    public static long nextLong() {
        return long.Parse(next());
    }

    public static double nextDouble() {
        return double.Parse(next());
    }

}