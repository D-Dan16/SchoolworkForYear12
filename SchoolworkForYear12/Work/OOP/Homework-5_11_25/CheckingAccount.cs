// ReSharper disable FieldCanBeMadeReadOnly.Local
namespace SchoolworkForYear12.Work.Inheritance.Homework_5_11_25;

public class CheckingAccount
{
    private int _bankId;
    private int _bankNumber;
    private int _accountProviderNumber;
    private string _ownerId;
    private double _accountBalance;
    private double _maxAllowedOverdraft;

    public CheckingAccount(int bankId, int bankNumber, int accountProviderNumber, string ownerId, double accountBalance)
    {
        _bankId = bankId;
        _bankNumber = bankNumber;
        _accountProviderNumber = accountProviderNumber;
        _ownerId = ownerId;
        _accountBalance = accountBalance;
        _maxAllowedOverdraft = 10000;
    }

    public CheckingAccount(int bankId, int bankNumber, int accountProviderNumber, string ownerId, double accountBalance, double maxAllowedOverdraft)
    {
        _bankId = bankId;
        _bankNumber = bankNumber;
        _accountProviderNumber = accountProviderNumber;
        _ownerId = ownerId;
        _accountBalance = accountBalance;
        _maxAllowedOverdraft = maxAllowedOverdraft;
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

    public double GetMaxAllowedOverdraft()
    {
        return _maxAllowedOverdraft;
    }

    public double SetMaxAllowedOverdraft(double value)
    {
        return _maxAllowedOverdraft = value > 0 ? value : 0;
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
                maxAllowedOverdraft={_maxAllowedOverdraft}
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

    bool Withdraw(double amount)
    {
        if (amount < 0)
        {
            return false;
        }

        if (amount > _maxAllowedOverdraft && amount > _accountBalance)
            return false;

        _accountBalance -= amount;
        return true;
    }
}