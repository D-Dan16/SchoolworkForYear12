using SchoolworkForYear12.Work.Inheritance.TheZoo;

namespace SchoolworkForYear12.Work.OOP.TheZoo.ZooAnimals;

public class Crocodile : Reptile
{
    protected bool hasGoneThroughTeethSurgery;


    public Crocodile(string name, int age, bool isApexPredator, int numOfCaloriesForADish, double lengthOfTail, bool hasGoneThroughTeethSurgery) : base(name, age, isApexPredator, numOfCaloriesForADish, lengthOfTail)
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

    public override int Eat()
    {
        return numOfCaloriesForADish*4;
    }

}