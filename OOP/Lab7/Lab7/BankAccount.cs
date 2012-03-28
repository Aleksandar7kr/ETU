class BankAccount 
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    
    private static long nextAccNo = 123;

    public void SetAccArgs(decimal balance)
    {
        accNo = BankAccount.MakeNextAccNo();
        accBal = balance;
        accType = AccountType.Checking;
    }

    public long GetAccNo()
    {
        return accNo;
    }

    public decimal GetAccBal()
    {
        return accBal;
    }

    public AccountType GetAccType()
    {
        return accType;
    }

    private static long MakeNextAccNo()
    {
        nextAccNo = nextAccNo+1;
        return nextAccNo;
    }

    public decimal AddDeposit(decimal summ)
    {
        return accBal += summ; 
    }

    public bool Withdraw(decimal summ)
    {
        if (summ <= accBal)
        {
            accBal -= summ;
            return true;
        }
        return false;
    }

    public void TransferFrom(BankAccount target, decimal summ)
    {
        if (Withdraw(summ))
        {
            target.AddDeposit(summ);
        }
    }
}
