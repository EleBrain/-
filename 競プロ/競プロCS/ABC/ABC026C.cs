//using System;

//class Program {
//    static void Main(string[] args) {
//        string s = Console.ReadLine();
//        int n = int.Parse(s);
//        int[,] B = new int[2, n]; //[0上司  1給料 , 社員番号]
      
//        B[1, 0] = 1;
//        for (int i = 1; i < n ; i++) {
//            s = Console.ReadLine();
//            B[0, i] = int.Parse(s) - 1;
//            B[1, i] = 1;
//        }

//        for (int d = n - 1; d >= 0; --d) {
//            int max = 0;
//            int min = int.MaxValue;
//            for (int sub = d + 1; sub < n; sub++) {
//                if (B[0, sub] == d) {
//                    max = Math.Max(max, B[1, sub]);
//                    min = Math.Min(min, B[1, sub]);
//                }
//            }
//            if (min != int.MaxValue) B[1, d] = max + min + 1;
//        }

//        Console.WriteLine(B[1, 0]);

//    }
//}