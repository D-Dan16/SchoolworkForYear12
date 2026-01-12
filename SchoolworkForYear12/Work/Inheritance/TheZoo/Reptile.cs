namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Reptile : Animal
{
    protected double lengthOfTail;


    public Reptile(string name, int age, string apexPredator, string numOfCaloriesForADish, double lengthOfTail) : base(name, age, apexPredator, numOfCaloriesForADish)
    {
        this.lengthOfTail = lengthOfTail;
    }

    public double LengthOfTail
    {
        get => lengthOfTail;
        set => lengthOfTail = value;
    }
    
    public override string ToString()
    {
        return $"""
                {base.ToString()}
                -------------Reptile Properties:-----------
                {lengthOfTail}
                ------------------------------------------
                """;
    }
}