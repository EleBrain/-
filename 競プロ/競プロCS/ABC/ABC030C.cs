using System;

class Program {
    static void Main(string[] args) {
        int n = cin.ni();
        int m = cin.ni();
        int x = cin.ni();
        int y = cin.ni();

        int[] aa = new int[100002];
        int[] ba = new int[100002];
        int answer = 0;

        for (int i = 0; i < n; i++) {
            aa[i] = cin.ni();
        }

        for (int i = 0; i < m; i++) {
            ba[i] = cin.ni();
        }


        int now = 0;
        int aPos = 0;
        int bPos = 0;

        while (true) {
            if (canFlight(ref now, aa, ref aPos)) {
                now += x;
                if (canFlight(ref now, ba, ref bPos)) {
                    now += y;
                    answer++;
                } else {
                    break;
                }
            } else {
                break;
            }
        }

        Console.WriteLine(answer);
    }

    private static bool canFlight(ref int now, int[] flightList, ref int pos) {

        for (; flightList[pos] != 0; pos++) {
            if (now <= flightList[pos]) {
                now = flightList[pos];
                return true;
            }
        }
        return false;
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

