// Krasilnikov Aleksandr
// group 9301
// lab1 exercise4 - "Divide by zero"

class Divider
{
    static void Main(string[] args)
    {
        int a, b;
        string temp;
        int result; //int?

        try
        {
            // ввод делимого в переменную a
            System.Console.WriteLine("Please enter first number:");
            temp = System.Console.ReadLine();
            a = int.Parse(temp);

            // ввод делителя в переменную b
            System.Console.WriteLine("Please enter second number:");
            temp = System.Console.ReadLine();
            b = int.Parse(temp);

            // вычисление и вывод результата
            result = a / b;
            System.Console.WriteLine("Complete! {0} / {1} = {2}", a, b, result);
        }
        catch (System.Exception e)
        {
            // обработка возможных искличений:
            // System.DivideByZeroException
            // System.FormarException
            System.Console.WriteLine("Error!!! {0}", e);
        }
        System.Console.ReadKey();
    }
}