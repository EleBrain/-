using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int n = cin.ni();
        int[] a = new int[n];
        int[] points = new int[n];
        for (int i = 0; i < n; i++) {
            a[i] = cin.ni();
        }

        //高橋君が選んだ番号
        for (int i = 0; i < n; i++) {
            points[i] = int.MinValue;
            int aokiMax = int.MinValue;

            //青木君が選んだ番号
            for (int j = 0; j < n; j++) {
                if (i == j) continue;
                int tmpTakahasiPoint = 0;
                int tmpAokiPoint = 0;
                int min = Math.Min(i, j);
                int max = Math.Max(i, j);
                bool isEven = true;
                //得点
                for (int k = min; k < max + 1; k++) {
                    if (isEven) {
                        tmpTakahasiPoint += a[k];
                    } else {
                        tmpAokiPoint += a[k];
                    }
                    isEven = !isEven;
                }
                if (aokiMax < tmpAokiPoint) {
                    aokiMax = tmpAokiPoint;
                    points[i] = tmpTakahasiPoint;
                }
            }
        }
        Console.WriteLine(points.Max());

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