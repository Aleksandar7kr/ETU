// Krasilnikov Aleksandr
// group 9301
// lab1 exercise4 - "Divide by zero"h

class Divider
{
    static void Main(string[] args)
    {
        int a, b;
        string temp;
        int result; //int?

        try
        {
            System.Console.WriteLine("Please enter first number:");
            temp = System.Console.ReadLine();
            a = int.Parse(temp);

            System.Console.WriteLine("Please enter second number:");
            temp = System.Console.ReadLine();
            b = int.Parse(temp);
        
            result = a / b;
            System.Console.WriteLine("Complete! {0} / {1} = {2}", a, b, result);
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine("Error!!! {0}", e);
        }
        System.Console.ReadKey();
    }
}