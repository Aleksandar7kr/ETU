// Krasilnikov Aleksandr
// group 9301
// lab1 exercise1 - "Hello, UserName"

class Greeter
{
    static void Main(string[] args)
    {
        string userName;
        System.Console.WriteLine("Please enter your name:");
        userName = System.Console.ReadLine();
        System.Console.WriteLine("Hello, {0}", userName);
        System.Console.ReadKey();
    }
}