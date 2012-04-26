
using System;

class CreateAccount
{
    static void Main() 
    {
        BankAccount berts = NewBankAccount();
        Write(berts);
        TestDeposit(berts);
        Write(berts);
        TestWithdraw(berts);
        Write(berts);
        
        BankAccount freds = NewBankAccount();
        Write(freds);
        TestDeposit(freds);
        Write(freds);
        TestWithdraw(freds);
        Write(freds);
        
        Console.ReadKey();
    }
    
    static BankAccount NewBankAccount()
    {       
        BankAccount acc = new BankAccount();
     //   Console.Write("Enter the account number   : ");
     //   long number = long.Parse(Console.ReadLine());        
        Console.Write("Enter the account balance! : ");
        decimal balance = decimal.Parse(Console.ReadLine());
        acc.SetAccArgs(balance);
        return acc;
    }
    
    static void Write(BankAccount toWrite)
    {
        Console.WriteLine("Account number is {0}",  toWrite.GetAccNo());
        Console.WriteLine("Account balance is {0}", toWrite.GetAccBal());
        Console.WriteLine("Account type is {0}", toWrite.GetAccType());
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
