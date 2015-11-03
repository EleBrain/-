//using System;

//class Program {
//    static void Main(string[] args) {

//        const double FULL = 360;
//        double minDegree = FULL / 60;
//        double hourDegree = FULL / 12;

//        int n = cin.nextInt();
//        int m = cin.nextInt();

//        double shortDegree = hourDegree * (n % 12) + (hourDegree / 60 * m);
//        double longDegree = minDegree * m;

//        double answer = Math.Abs(longDegree - shortDegree);
//        if (answer > 180) answer = FULL - answer;

//        Console.WriteLine(answer);

//    }
//}

//public class cin {
//    private static string[] s = new string[0];
//    private static int i = 0;

//    private static char[] cs = new char[] { ' ' };

//    public static string next() {
//        if (i < s.Length) return s[i++];
//        string st = Console.ReadLine();
//        while (st == "") st = Console.ReadLine();
//        s = st.Split(cs, StringSplitOptions.RemoveEmptyEntries);
//        i = 0;
//        return next();
//    }

//    public static int nextInt() {
//        return int.Parse(next());
//    }

//    public static long nextLong() {
//        return long.Parse(next());
//    }

//    public static double nextDouble() {
//        return double.Parse(next());
//    }

//}