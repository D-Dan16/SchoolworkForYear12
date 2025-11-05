namespace SchoolworkForYear12.Work.Inheritance.Homework_5_11_25;

public class MainProgram
{
    public static void Main()
    {
        Start();
    }

    private static void Start()
    {
        var basicAccount = new BasicAccount(1111, 2, 0525093696, "123456789", 1000);
        var savingAccount = new SavingAccount(1111, 2, 0525093696, "123456789", 1000, new Date(18,11,2030));
        var checkingAccount = new CheckingAccount(1, 2, 3, "123456789", 10000.0, 1000.0);


        Console.WriteLine(basicAccount);
        Console.WriteLine(savingAccount);
        Console.WriteLine(checkingAccount);

    }
}