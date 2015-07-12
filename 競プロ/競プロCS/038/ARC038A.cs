//using System;

//namespace ARC001CS {
//    class Program {
//        static void Main(string[] args) {

//            int n = int.Parse(Console.ReadLine());
//            int score = 0;
//            int[] A = new int[n];
//            string[] ss = Console.ReadLine().Split(' ');
//            for (int i = 0; i < n; ++i) {
//                A[i] = int.Parse(ss[i]);
//            }

//            Array.Sort(A);
//            Array.Reverse(A);
//            for (int i = 0; i < n; ++i) {
//                if (i % 2 == 0) {
//                    score += A[i];
//                }
//            }
//            Console.WriteLine(score);

//        }
//    }
//}

