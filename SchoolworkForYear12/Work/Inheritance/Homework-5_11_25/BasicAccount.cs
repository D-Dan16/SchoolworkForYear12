namespace SchoolworkForYear12.Work.Inheritance.Homework_5_11_25;

public class BasicAccount
{
    private int _bankId;
    private int _bankNumber;
    private int _accountProviderNumber;
    private string _ownerId;
    private double _accountBalance;

    public BasicAccount(int bankId, int bankNumber, int accountProviderNumber, string ownerId, double accountBalance)
    {
        _bankId = bankId;
        _bankNumber = bankNumber;
        _accountProviderNumber = accountProviderNumber;
        _ownerId = ownerId;
        _accountBalance = accountBalance;
    }

    public int GetBankId()
    {
        return _bankId;
    }

    public int GetBankNumber()
    {
        return _bankNumber;
    }

    public int GetAccountProviderNumber()
    {
        return _accountProviderNumber;
    }

    public string GetOwnerId()
    {
        return _ownerId;
    }

    public double GetAccountBalance()
    {
        return _accountBalance;
    }


    bool Deposit(double amount)
    {
        if (amount < 0)
        {
            return false;
        }

        this._accountBalance += amount;
        return true;
    }
}