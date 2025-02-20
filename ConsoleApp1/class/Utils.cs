public class Utils
{
    public static int Greater(int a, int b)
    {
        return Math.Max(a, b);
    }

    public static void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }

    public static bool Factorial(int n, out int answer)
    {
        int count;
        int f = 1;
        bool is_ok = true;
        try
        {
            checked
            {
                for (count = 2; count <= n; count++)
                {
                    f *= count;
                }
            }
        }
        catch (Exception)
        {
            f = 0;
            is_ok = false;
        }
        answer = f;
        return is_ok;
    }
}
