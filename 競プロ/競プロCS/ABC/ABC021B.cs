//using System;

//namespace ABC021 {
//    class Program {
//        static void Main(string[] args) {

//            int n = int.Parse(Console.ReadLine());
//            string[] ab = Console.ReadLine().Split(' ');
//            int a = int.Parse(ab[0]);
//            int b = int.Parse(ab[1]);
//            int k = int.Parse(Console.ReadLine());
//            bool[] isVisited = new bool[101];

//            if (n - 2 < k) {
//                Console.WriteLine("NO");
//                return;
//            }

//            isVisited[a] = true;
//            isVisited[b] = true;
//            string[] p = Console.ReadLine().Split(' ');

//            for (int i = 0; i < k; ++i) {
//                int v = int.Parse(p[i]);
//                if (isVisited[v]) {
//                    Console.WriteLine("NO");
//                    return;
//                } else {
//                    isVisited[v] = true;
//                }
//            }
//            Console.WriteLine("YES");
//        }
//    }
//}
