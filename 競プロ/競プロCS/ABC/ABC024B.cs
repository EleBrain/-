//using System;

//class Program {
//    static void Main(string[] args) {
//        string[] ss = Console.ReadLine().Split(' ');
//        int n = int.Parse(ss[0]);
//        int t = int.Parse(ss[1]);

//        string s = Console.ReadLine();

//        int total = 0;
//        int lastNum = int.Parse(s);
//        for (int i = 0; i < n - 1; ++i) {
//            int a = int.Parse(Console.ReadLine());
//            total += Math.Min(a - lastNum, t);
//            lastNum = a;
//        }

//        total += t;

//        Console.WriteLine(total);
//    }
//}