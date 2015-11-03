//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ARC {
//    class ARC042A {
//        static void Main(string[] args) {
//            int N = cin.nextInt();
//            int P = cin.nextInt();
//            int[,] DP = new int[2, N];

//            for (int i = 0; i < N; i++) {
//                DP[0, i] = cin.nextInt();
//                DP[1, i] = cin.nextInt();
//            }

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