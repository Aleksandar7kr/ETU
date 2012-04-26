using System;

class CreateAccount
{
    // Test Harness
    static void Main() 
    {
        BankAccount acc1;

		acc1 = new BankAccount();

		acc1.Deposit(100);
		acc1.Withdraw(50);
		acc1.Deposit(75);
		acc1.Withdraw(50);
        acc1.Withdraw(30);
		acc1.Deposit(40);

        Write(acc1, "acc1");
        Console.ReadKey();
    }

    static void Write(BankAccount acc, string name)
    {
        Console.WriteLine(name);
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
		Console.WriteLine("Transactions:");
		foreach (BankTransaction tran in acc.Transactions()) 
		{
			Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.GetWhen(), tran.GetAmount());
		}
		Console.WriteLine();
    }
}
