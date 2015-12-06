using System;

class Program {

    static void Main(string[] args) {
        int txa = cin.ni();
        int tya = cin.ni();
        int txb = cin.ni();
        int tyb = cin.ni();
        int T = cin.ni();
        int V = cin.ni();
        int n = cin.ni();

        for (int i = 0; i < n; i++) {
            int x = cin.ni();
            int y = cin.ni();
            if ( Math.Sqrt((x - txb) * (x - txb) + (y - tyb) * (y - tyb)) +
                Math.Sqrt((x - txa) * (x - txa) + (y - tya) * (y - tya)) 
                <= T * V) {
                Console.WriteLine("YES");
                return;
            }
        }
        Console.WriteLine("NO");
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