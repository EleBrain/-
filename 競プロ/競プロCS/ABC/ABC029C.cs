//using System;

//class Program {

//    static string[] ABC = new string[] { "a", "b", "c" };
//    static void Main(string[] args) {
//        int[] indexs = new int[8];
//        int abcLen = ABC.Length;
//        int n = int.Parse(Console.ReadLine());
//        while (indexs[0] < abcLen) {
//            string s = "";
//            for (int i = 0; i < n; i++) {
//                s += ABC[indexs[i]];
//            }
//            indexs[n - 1]++;
//            for (int i = n - 1; i > 0; i--) {
//                if (indexs[i] == abcLen) {
//                    indexs[i - 1]++;
//                    indexs[i] = 0;
//                }
//            }

//            Console.WriteLine(s);
//        }
//    }
//}