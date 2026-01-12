namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Snake : Reptile
{
    protected bool isVenomous;


    public Snake(string name, int age, string apexPredator, string numOfCaloriesForADish, double lengthOfTail, bool isVenomous) : base(name, age, apexPredator, numOfCaloriesForADish, lengthOfTail)
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

}