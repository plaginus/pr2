public class Operation
{
    public static int RootsCalculating(double a, double b, double c, ref double x1, ref double x2)
    {
        double d = (b * b) - (4 * a * c);
        switch (d)
        {
            case > 0:
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return 1;
            case < 0:
                return -1;
            default:
                x1 = x2 = -b / (2 * a);
                return 0;
        } 
    }

        public static bool Tringle(double a, double b, double c, out double s)
    {
        if (Is_tringle(a, b, c))
        {
            double p = (a * 3) / 2.0;
            s = Math.Sqrt(p * Math.Pow(p - a, 3));
            return true;
        }
        else 
        {
            s = 0;
            return false;
        }

    }
    public static bool Tringle(double a, out double s)
    {
        double p = (a * 3) / 2.0;
        s = Math.Sqrt(p * Math.Pow(p - a, 3));
        return true;
    }

    private static bool Is_tringle(double a, double b, double c)
    {
        if (a + b > c && a + c > b && c + b > a) return true;
        else return false;
    }

}
