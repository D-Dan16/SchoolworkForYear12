using SchoolworkForYear12.Work.OOP.TheZoo.ZooAnimals;

namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Reptile : Animal
{
    protected double lengthOfTail;


    public Reptile(string name, int age, bool isApexPredator, int numOfCaloriesForADish, double lengthOfTail) : base(name, age, isApexPredator, numOfCaloriesForADish)
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