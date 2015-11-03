using System;

class Program {
    static void Main(string[] args) {
        int deg = cin.ni();
        double dis = cin.ni();
        string dir = "";
        int W = 0;

        if (deg < 113) {
            dir = "N";
        } else if (deg < 338) {
            dir = "NNE";
        } else if (deg < 563) {
            dir = "NE";
        } else if (deg < 788) {
            dir = "ENE";
        } else if (deg < 1013) {
            dir = "E";
        } else if (deg < 1238) {
            dir = "ESE";
        } else if (deg < 1463) {
            dir = "SE";
        } else if (deg < 1688) {
            dir = "SSE";
        } else if (deg < 1913) {
            dir = "S";
        } else if (deg < 2138) {
            dir = "SSW";
        } else if (deg < 2363) {
            dir = "SW";
        } else if (deg < 2588) {
            dir = "WSW";
        } else if (deg < 2813) {
            dir = "W";
        } else if (deg < 3038) {
            dir = "WNW";
        } else if (deg < 3263) {
            dir = "NW";
        } else if (deg < 3488) {
            dir = "NNW";
        } else {
            dir = "N";
        }
        dis = Math.Round(dis / 60, 1, MidpointRounding.AwayFromZero);
        if (dis <= 0.2) {
            dir = "C";
        } else if (dis <= 1.5) {
            W = 1;
        } else if (dis <= 3.3) {
            W = 2;
        } else if (dis <= 5.4) {
            W = 3;
        } else if (dis <= 7.9) {
            W = 4;
        } else if (dis <= 10.7) {
            W = 5;
        } else if (dis <= 13.8) {
            W = 6;
        } else if (dis <= 17.1) {
            W = 7;
        } else if (dis <= 20.7) {
            W = 8;
        } else if (dis <= 24.4) {
            W = 9;
        } else if (dis <= 28.4) {
            W = 10;
        } else if (dis <= 32.6) {
            W = 11;
        } else {
            W = 12;
        }

        Console.WriteLine(dir + " " + W);
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

