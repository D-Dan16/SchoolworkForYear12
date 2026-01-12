namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Snake : Reptile
{
    protected bool isVenomous;


    public Snake(string name, int age, bool isApexPredator, int numOfCaloriesForADish, double lengthOfTail, bool isVenomous) : base(name, age, isApexPredator, numOfCaloriesForADish, lengthOfTail)
    {
        this.isVenomous = isVenomous;
    }

    public bool IsVenomous
    {
        get => isVenomous;
        set => isVenomous = value;
    }
    
    public override string ToString()
    {
        return $"""
                {base.ToString()}
                -------------Snake Properties:-----------
                {isVenomous}
                ------------------------------------------
                """;
    }

    public void Dance()
    {
        Console.WriteLine("The snake dances!");
    }

}