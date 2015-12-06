using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        string s = cin.next();
        string t = cin.next();
        bool frg = true;

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == t[i] ||
                s[i] == '@' && "atcoder".Contains(t[i]) ||
                "atcoder".Contains(s[i]) && t[i] == '@') {

            } else {
                frg = false;
                break;
            }
        }

        if (frg) {
            Console.WriteLine("You can win");
        } else {
            Console.WriteLine("You will lose");
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

