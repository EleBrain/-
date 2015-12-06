using System;
using System.Collections.Generic;

public struct data {
    public int x;
    public int y;
    public int c;
    public data(int x, int y, int c) {
        this.x = x;
        this.y = y;
        this.c = c;
    }
}

class Program {

    private static int r;
    private static int c;
    private static string[,] maze;
    private static int[,] count;
    private static Queue<data> que = new Queue<data>();

    static void Main(string[] args) {
        r = cin.ni();
        c = cin.ni();
        int sy = cin.ni() - 1;
        int sx = cin.ni() - 1;
        int gy = cin.ni() - 1;
        int gx = cin.ni() - 1;
        maze = new string[r, c];
        count = new int[r, c];

        for (int ri = 0; ri < r; ri++) {
            string s = Console.ReadLine();
            for (int ci = 0; ci < c; ci++) {
                maze[ri, ci] = s[ci].ToString();
                count[ri, ci] = -1;
            }
        }
        serch(new data(sy, sx, 0));


        Console.WriteLine(count[gy, gx]);
    }
    private static void serch(data p) {
        int x = p.x;
        int y = p.y;
        int c = p.c;

        if (x < 0 || y < 0) return;
        if (x >= Program.c || y >= r) return;
        if (count[y, x] != -1) return;
        if (maze[y, x] != ".") return;
        count[y, x] = c;
        que.Enqueue(new data(x - 1, y, c + 1));
        que.Enqueue(new data(x + 1, y, c + 1));
        que.Enqueue(new data(x, y - 1, c + 1));
        que.Enqueue(new data(x, y + 1, c + 1));
        while (que.Count > 0) {
            serch(que.Dequeue());
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