namespace SchoolworkForYear12.Work.Inheritance.Homework_5_11_25;

public class SavingAccount
{
    private int _bankId;
    private int _bankNumber;
    private int _accountProviderNumber;
    private string _ownerId;
    private double _accountBalance;
    private Date _expirationDate;

    public SavingAccount(int bankId, int bankNumber, int accountProviderNumber, string ownerId, double accountBalance, Date expirationDate)
    {
        _bankId = bankId;
        _bankNumber = bankNumber;
        _accountProviderNumber = accountProviderNumber;
        _ownerId = ownerId;
        _accountBalance = accountBalance;
        _expirationDate = new Date(expirationDate);
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

    public Date GetMaxAllowedOverdraft()
    {
        return _expirationDate;
    }

    public Date SetExpirationDate(Date otherDate)
    {
        return _expirationDate = _expirationDate.CompareTo(otherDate) < 0 ? otherDate : _expirationDate;
    }

    public override string ToString()
    {
        return $"""
                -----------------  {GetHashCode()},{GetType()}   ----------------
                bankID={_bankId},
                bankNumber={_bankNumber},
                accountProviderNumber={_accountProviderNumber},
                ownerId={_ownerId},
                accountBalance={_accountBalance},
                expirationDate={_expirationDate}
                ------------------------------------------
                """;
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

    bool Withdraw(double amount,Date date)
    {
        if (amount < 0 || amount > _accountBalance)
        {
            return false;
        }

        if (date.CompareTo(_expirationDate) < 0)
            return false;

        _accountBalance -= amount;
        return true;
    }

}