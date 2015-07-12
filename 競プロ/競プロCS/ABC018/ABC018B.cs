using System;
using System.Text;

namespace ABC018CS {
    class Program {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i) {
                string[] border = Console.ReadLine().Split(' ');
                int start = int.Parse(border[0]) - 1;
                int end = int.Parse(border[1]);
                s = reverse(s, start, end);
            }
            Console.WriteLine(s);
        }

        static string reverse(string BaseStr, int start, int end) {

            StringBuilder ss = new StringBuilder();
            int changeLength = end - start;
            string changeStr = BaseStr.Substring(start, changeLength);
            for (int i = 0; i < start; ++i) {
                ss.Append(BaseStr[i]);
            }
            for (int i = changeLength - 1; i >= 0; --i) {
                ss.Append(changeStr[i]);
            }
            for (int i = end; i < BaseStr.Length; ++i) {
                ss.Append(BaseStr[i]);
            }
            return ss.ToString();
        }
    }
}
