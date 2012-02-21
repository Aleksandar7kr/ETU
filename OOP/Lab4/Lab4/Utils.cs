class Utils
{
    public static int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a; a = b; b = temp;
    }

    public static bool Factorial(uint n, out uint result)
    {
        result = 1;
        if (n == 0) return true;
        try
        {
            for (uint i = 2; i <= n; ++i)
            {
                checked
                {
                    result *= i;
                }
            }
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e);
            return false;
        }
        return true;
    }

    public static bool RecursiveFactorial(uint n, uint result = 1)
    {
        if (n != 0)
        {
            try
            {
                ;
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                return false;
            }
        }
        return true;
    }
}
