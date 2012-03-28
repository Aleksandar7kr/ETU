using System;

class Test
{
    public static void TestMax()
    {
        Console.WriteLine("Please enter x");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter y");
        int y = int.Parse(Console.ReadLine());

        int max = Utils.Max(x, y);
        Console.WriteLine("x = {0}, y = {1}, max = {2}", x, y, max);
    }

    public static void TestSwap()
    {
        Console.WriteLine("Please enter x");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter y");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("x = {0}, y = {1}", x, y);
        Console.WriteLine("Swap!");
        Utils.Swap(ref x, ref  y);
        Console.WriteLine("x = {0}, y = {1}", x, y);
    }

    public static void TestFactorial()
    {
        try
        {
            Console.WriteLine("Please enter n");
            uint n = uint.Parse(Console.ReadLine());
            uint result;
            Utils.Factorial(n, out result);
            Console.WriteLine("Factorial({0}) = {1}", n, result);

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
        }
    }

    public static void TestRecursiveFactorial()
    {
        try
        {
            Console.WriteLine("Please enter n");
            uint n = uint.Parse(Console.ReadLine());
            uint result = Utils.RecursiveFactorial(n);
            Console.WriteLine("Factorial({0}) = {1}", n, result);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
        }
    }

    public static void TestReverse()
    {
        Console.WriteLine("Please enter a string: ");
        string message = Console.ReadLine();
        Utils.StringReverse(ref     message);
        Console.WriteLine(message);
    }

    public static void TestIsFormattable()
    {
        int iVar = 0;
        ulong ulVar = 0;
        string sVar = "test";
        Console.WriteLine("int variable is IFormattable: {0}", Utils.isFormattable(iVar));
        Console.WriteLine("ulong variable is IFormattable: {0}", Utils.isFormattable(ulVar));
        Console.WriteLine("string variable is IFormattable: {0}", Utils.isFormattable(sVar));
    }

    public static void TestDisplay()
    {
        int iVar = 42;
        string sVar = "String";
        Coordinate point = new Coordinate(10.23, 20.234);
        
        Utils.Display(iVar);
        Utils.Display(sVar);
        Utils.Display(point);
    }

    public static void Main()
    {
        //  TestMax();
        //  TestSwap();
        //  TestFactorial();
        //  TestRecursiveFactorial();

        //TestReverse();
        //TestIsFormattable();
        TestDisplay();
        Console.ReadKey();
    }
}