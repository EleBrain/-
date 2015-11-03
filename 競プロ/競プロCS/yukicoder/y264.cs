//using System;

//class Program {
//    static void Main(string[] args) {

//        int N = cin.nextInt();
//        int L = cin.nextInt();
//        string result = "Drew";

//        if (N == 0 && L == 1 ||
//            N == 1 && L == 2 ||
//            N == 2 && L == 0) {
//            result = "Won";
//        } else if (N == 0 && L == 2 ||
//            N == 1 && L == 0 ||
//            N == 2 && L == 1) {
//            result = "Lost";
//        }

//        Console.WriteLine(result);
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