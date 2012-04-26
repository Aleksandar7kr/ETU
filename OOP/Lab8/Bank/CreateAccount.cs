
using System;

class CreateAccount
{
    static void Main() 
    {
        BankAccount acc1, acc2, acc3, acc4;

        acc1 = new BankAccount();
        acc2 = new BankAccount(AccountType.Deposit);
        acc3 = new BankAccount(100);
        acc4 = new BankAccount(AccountType.Deposit, 500);

        Write(acc1, "acc1");
        Write(acc2, "acc2");
        Write(acc3, "acc3");
        Write(acc4, "acc4");        

        Console.ReadKey();
    }
    
   
    static void Write(BankAccount toWrite, string name)
    {
        Console.WriteLine(name);
        Console.WriteLine("Account number is {0}",  toWrite.GetAccNo());
        Console.WriteLine("Account balance is {0}", toWrite.GetAccBal());
        Console.WriteLine("Account type is {0}", toWrite.GetAccType());
        Console.WriteLine();
    }

    public static void TestDeposit(BankAccount acc)
    {
        Console.WriteLine("Enter amount to deposit");
        decimal amount = decimal.Parse(Console.ReadLine());
        acc.AddDeposit(amount);
    }

    public static void TestWithdraw(BankAccount acc)
    {
        Console.WriteLine("Enter amount to withdraw");
        decimal amount = decimal.Parse(Console.ReadLine());
        acc.Withdraw(amount);
    }
}
