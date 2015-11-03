//using System;

//class Program {
//    static void Main(string[] args) {
//        int n = cin.ni();
//        int a = cin.ni();
//        int b = cin.ni();
//        int nowPoint = 0;


//        for (int i = 0; i < n; i++) {
//            string s = cin.next();
//            int d = cin.ni();
//            d = Math.Max(d, a);
//            d = Math.Min(d, b);
//            if (s == "East") {
//                nowPoint += d;
//            } else {
//                nowPoint -= d;
//            }
//        }
//        if (nowPoint > 0) {
//            Console.WriteLine("East " + nowPoint);
//        } else if (nowPoint < 0) {
//            Console.WriteLine("West " + Math.Abs(nowPoint));
//        } else {
//            Console.WriteLine(0);
//        }

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

//    public static int ni() {
//        return int.Parse(next());
//    }

//    public static long nextLong() {
//        return long.Parse(next());
//    }

//    public static double nextDouble() {
//        return double.Parse(next());
//    }

//}

