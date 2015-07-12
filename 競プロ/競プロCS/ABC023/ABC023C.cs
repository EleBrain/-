using System;

class Program {
    static void Main(string[] args) {

        int H = 10;
        int W = 10;
        bool[,] fields = new bool[H, W];
        int[] CandysH = new int[H];
        int[] CandysW = new int[W];

        int N;

        for (int h = 0; h < H; h++) {
            for (int w = 0; w < W; w++) {
                if (fields[h, w]) {
                    CandysH[h]++;
                    CandysW[w]++;
                }
            }
        }


    }
}
