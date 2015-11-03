using System;

class program {
    static void Main(string[] args) {
        string s = Console.ReadLine();
        string[] ss = s.Split(' ');
        for (int i = 0; i < ss.Length; i++) {
            if(i != 0) Console.Write(" ");
            switch (ss[i]) {
                case "Right":
                    Console.Write(">");
                    break;
                case "Left":
                    Console.Write("<");
                    break;
                case "AtCoder":
                    Console.Write("A");
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine();
    }
}



