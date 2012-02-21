// Krasilnikov Aleksandr
// group 9301
// lab2 exercise2 - struct test

using System;

public enum AccountType { Cheking, Deposit }

public struct BankAccount
{
    public long accNo;
    public decimal accBal;
    public AccountType accType;
}

    class StructTest
{
    static BankAccount CreateAccount()
    {
        Random generator = new Random();

        BankAccount acc;
        acc.accNo = generator.Next(10000000);
        acc.accBal = Math.Round(Convert.ToDecimal(generator.Next(10000) * generator.NextDouble()), 2);
        acc.accType = Convert.ToBoolean(generator.Next(2)) ? AccountType.Deposit : AccountType.Cheking;
        return acc;
    }

    static void PrintAccInfo(ref BankAccount acc)
    {
        Console.WriteLine("===Account information===");
        Console.WriteLine("№: {0}", acc.accNo);
        Console.WriteLine("balance: {0}$", acc.accBal);
        Console.WriteLine("status: {0}", acc.accType); 
    }
        
    static void Main(string[] args)
    {
        BankAccount goldAccoutn = CreateAccount();
        PrintAccInfo(ref goldAccoutn);
        Console.ReadKey();
    }
}
