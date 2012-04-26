class BankAccount 
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    
    private static long nextAccNo = 123;

    public BankAccount()
    {
        accNo = BankAccount.MakeNextAccNo();
        accBal = 0;
        accType = AccountType.Checking;
    }

    public BankAccount(AccountType type)
    {
        accNo = BankAccount.MakeNextAccNo();
        accBal = 0;
        accType = type;
    }

    public BankAccount(decimal balance)
    {
        accNo = BankAccount.MakeNextAccNo();
        accBal = balance;
        accType = AccountType.Checking;
    }
    public BankAccount(AccountType type, decimal balane)
    {
        accNo = BankAccount.MakeNextAccNo();
        accBal = balane;
        accType = type;
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
        nextAccNo += 1;
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
