//using System;

//class Program {
//    static void Main(string[] args) {

//        int count = 0;
//        char[] abc = { 'a', 'b', 'c' };
//        int N = int.Parse(Console.ReadLine());
                             
//        if (N % 2 == 0) {
//            Console.WriteLine(-1);
//        } else {
//            string S = Console.ReadLine();
//            int harf = N / 2;
//            if (S[harf] != 'b') {
//                Console.WriteLine(-1);
//                return;
//            }
                 
//            //acbacb   ほしい文字
//            //021021   ほしいインデックス
//            //120120   このままループするとこのインデックス
//            //102102   マイナスをかけて反転する
//            //021021   2を足してずらす
//            for (int i = 1; i < harf + 1; ++i) {
//                if (S[harf + i] != abc[(count + 2) % 3]) {
//                    Console.WriteLine(-1);
//                    return;
//                }
//                if (S[harf - i] != abc[2 + -((count + 2) % 3)]) {
//                    Console.WriteLine(-1);
//                    return;
//                }

//                count++;
//            }
//            Console.WriteLine(count);
//        }

//    }
//}
