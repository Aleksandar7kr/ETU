using System;
using System.IO;

public class BankTransaction
{
    private readonly decimal amount;
    private readonly DateTime when;

    public BankTransaction(decimal tranAmount)
    {
        amount = tranAmount;
        when = DateTime.Now;
    }

    public decimal GetAmount()
    {
        return amount;
    }

    public DateTime GetWhen()
    {
        return when;
    }

    ~BankTransaction()
    {
        StreamWriter report = new StreamWriter("report.txt", true);
        report.WriteLine("Data/Time: {0}\tAmount: {1}", when, amount);
        report.Close();
     //   GC.SuppressFinalize(this);
    }
}

