using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int n = cin.ni();
        int m = cin.ni();
        List<int>[] friendList = new List<int>[n];
        for (int i = 0; i < n; i++) {
            friendList[i] = new List<int>();
        }
        for (int i = 0; i < m; i++) {
            int a = cin.ni() - 1;
            int b = cin.ni() - 1;
            friendList[a].Add(b);
            friendList[b].Add(a);
        }

        for (int i = 0; i < n; i++) {
            HashSet<int> fofList = new HashSet<int>();
            foreach (var f in friendList[i]) {
                foreach (var fof in friendList[f]) {
                    if (fof == i) continue;
                    if (friendList[i].Contains(fof)) continue;
                    fofList.Add(fof);
                }
            }
            Console.WriteLine(fofList.Count);
        }
        //クエリ式に失敗(´・ω・｀)
        //for (int i = 0; i < n; i++) {
        //    int count =
        //        (from f in friendList[i]  　　　//友達
        //         from fof in friendList[f]      //友達の友達
        //         where i != fof && !friendList[i].Contains(fof)     //自分と友達を除く
        //         group ).Distinct().Count();    //重複の削除　うまくいっていない
        //    Console.WriteLine(count);
        //}

    }
}

public class cin {
    private static string[] s = new string[0];
    private static int i = 0;

    private static char[] cs = new char[] { ' ' };

    public static string next() {
        if (i < s.Length) return s[i++];
        string st = Console.ReadLine();
        while (st == "") st = Console.ReadLine();
        s = st.Split(cs, StringSplitOptions.RemoveEmptyEntries);
        i = 0;
        return next();
    }

    public static int ni() {
        return int.Parse(next());
    }

    public static long nextLong() {
        return long.Parse(next());
    }

    public static double nextDouble() {
        return double.Parse(next());
    }

}