//using System;

//namespace ARC001CS {


//    public enum WinLose {
//        UNKNOWN,
//        WALL,
//        WIN,
//        LOSE,
//    }

//    class Program {
//        static void Main(string[] args) {


//            string[] ss = Console.ReadLine().Split(' ');
//            int H = int.Parse(ss[0]);
//            int W = int.Parse(ss[1]);

//            //番兵法
//            WinLose[,] map = new WinLose[H + 2, W + 2];

//            //一番外を壁にする
//            for (int i = 0; i < W + 2; ++i) {
//                map[0, i] = WinLose.WALL;
//                map[H + 1, i] = WinLose.WALL;
//            }
//            for (int i = 1; i < H + 1; ++i) {
//                map[i, 0] = WinLose.WALL;
//                map[i, W + 1] = WinLose.WALL;
//            }

//            //入力から移動不可のマスを壁にする
//            for (int h = 0; h < H; ++h) {
//                char[] lineChars = Console.ReadLine().ToCharArray();
//                for (int w = 0; w < W; ++w) {
//                    if (lineChars[w] == '#') {
//                        map[h + 1, w + 1] = WinLose.WALL;
//                    }
//                }
//            }

//            for (int h = H + 1; h > 0; --h) {
//                for (int w = W + 1; w > 0; --w) {
//                    if (map[h, w] != WinLose.UNKNOWN) continue;

//                    if (map[h + 1, w] == WinLose.LOSE ||
//                        map[h, w + 1] == WinLose.LOSE ||
//                        map[h + 1, w + 1] == WinLose.LOSE) {
//                        map[h, w] = WinLose.WIN;
//                    } else {
//                        map[h, w] = WinLose.LOSE;
//                    }
//                }
//            }
//            if (map[1, 1] == WinLose.WIN) {
//                Console.WriteLine("First");
//            } else {
//                Console.WriteLine("Second");
//            }
//        }
//    }
//}
