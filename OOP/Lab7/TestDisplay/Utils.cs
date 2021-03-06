﻿class Utils
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


    public static uint RecursiveFactorial(uint n, uint result = 1)
    {
        try
        {
            if (n != 0)
            {
                checked
                {
                    result *= n;
                    return RecursiveFactorial(n - 1, result);
                }

            }
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e);
            return 0;
        }
        return result;
    }

    public static void StringReverse(ref string str)
    {
        string revStr = "";
        
        for (int i = str.Length - 1; i >= 0; i--)
        {
            revStr += str[i];
        }
        str = revStr;
    }

    public static bool isFormattable(object x)
    {
        return x is System.IFormattable;
    }

    public static void Display(object x)
    {
        IPrintable ip = x as IPrintable;
        if (ip != null)
        {
            ip.Print();
        }
        else
        {
            System.Console.WriteLine(x.ToString());
        }
    }

}
