namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Crocodile : Reptile
{
    protected bool hasGoneThroughTeethSurgery;


    public Crocodile(string name, int age, string apexPredator, string numOfCaloriesForADish, double lengthOfTail, bool hasGoneThroughTeethSurgery) : base(name, age, apexPredator, numOfCaloriesForADish, lengthOfTail)
    {
        this.hasGoneThroughTeethSurgery = hasGoneThroughTeethSurgery;
    }

    public bool HasGoneThroughTeethSurgery
    {
        get => hasGoneThroughTeethSurgery;
        set => hasGoneThroughTeethSurgery = value;
    }
    
    public override string ToString()
    {
        return $"""
                {base.ToString()}
                -------------Crocodile Properties:-----------
                {hasGoneThroughTeethSurgery}
                ------------------------------------------
                """;
    }

}