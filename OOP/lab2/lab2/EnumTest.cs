// Krasilnikov Aleksandr
// group 9301
// lab2 exercise1 - enum test

using System;

enum AccountType { Cheking, Deposit }

class EnumTest
{
    static void Main(string[] args)
    {
        AccountType goldAccount = AccountType.Cheking;
        AccountType platinumAccount = AccountType.Deposit;

        Console.WriteLine("goldAccount status: {0}", goldAccount);
        Console.WriteLine("platinumAccount status: {0}", platinumAccount);
        Console.ReadKey();
    }
}
