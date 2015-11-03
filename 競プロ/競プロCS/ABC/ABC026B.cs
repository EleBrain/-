//using System;

//class Program {
//    static void Main(string[] args) {
//        string s = Console.ReadLine();
//        int n = int.Parse(s);
//        int[] r = new int[n];

//        for (int i = 0; i < n; i++) {
//            s = Console.ReadLine();
//            r[i] = int.Parse(s);
//        }
//        bool isEven = (n % 2 == 0);

//        Array.Sort(r);

//        double area = 0;
//        for (int i = n - 1; i >= 0; --i) {
//            double tmpArea = r[i] * r[i];
//            if (isEven && (i % 2 != 0) || !isEven && (i % 2 == 0)) {
//                area += tmpArea;
//            } else {
//                area -= tmpArea;
//            }
//        }
//        area *= Math.PI;
//        Console.WriteLine(area);

//    }
//}