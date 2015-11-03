//using System;
//using System.Collections.Generic;

//class Program {
//    static void Main(string[] args) {

//        int L = cin.nextInt();
//        int N = cin.nextInt();

//        int[] blocks = new int[N];

//        for (int i = 0; i < N; ++i) {
//            blocks[i] = cin.nextInt();
//        }
//        Array.Sort(blocks);

//        int count = 0;
//        for (int i = 0; i < N; i++) {

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