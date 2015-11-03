//using System;
//using System.Collections.Generic;


//class Program {
//    static void Main(string[] args) {

//        SortedSet<int> hs = new SortedSet<int>();
//        int res = 0;
//        int[] ia = new int[5];
//        for (int i = 0; i < 5; i++) {
//            ia[i] = cin.nextInt();
//        }

//        for (int i = 0; i < 5; i++) {
//            for (int j = 0; j < i; j++) {
//                for (int k = 0; k < j; k++) {
//                    hs.Add(ia[i] + ia[j] + ia[k]);
//                }
//            }
//        }

//        //三番目に大きな数を取り出す方法がわからんかった
//        int count = 0;
//        foreach (var item in hs) {
//            if (count++ == hs.Count - 3) res = item;
//        }
//        Console.WriteLine(res);
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