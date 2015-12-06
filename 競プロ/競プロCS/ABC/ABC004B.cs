using System;
using System.Linq;

class Program {
    static void Main(string[] args) {

        string[][] map = new string[4][];
        for (int y = 0; y < 4; y++) {
            map[y] = new string[4];
            for (int x = 0; x < 4; x++) {
                map[y][x] = cin.next();
            }
        }
        for (int y = 3; y >= 0; y--) {
            Array.Reverse(map[y]);
            Console.Write(string.Join(" ", map[y]));
            Console.WriteLine();
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
