using System;

class Program {
    static void Main(string[] args) {
        int N = cin.nextInt();
        int[] a = new int[100];
        int total = 0;
        int count = 0;

        for (int i = 0; i < N; i++) {
            a[i] = cin.nextInt();
            total += a[i];
        }
        if (total % N == 0) {
            int average = total / N;
            int t = 0;
            for (int i = 0; i < N - 1; i++) {
                t += a[i];
                if (t != average * (i + 1)) count++;
            }
            Console.WriteLine(count);
        } else {
            Console.WriteLine(-1);
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