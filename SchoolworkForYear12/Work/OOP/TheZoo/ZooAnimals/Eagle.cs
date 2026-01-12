using SchoolworkForYear12.Work.OOP.TheZoo.ZooAnimals;

namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Eagle : Bird
{
    private double lengthOfBeak;

    public Eagle(
        string name,
        int age,
        bool isApexPredator,
        int numOfCaloriesForADish,
        double maxHeightOfFlight,
        double lengthOfWings,
        double lengthOfBeak
    ) : base(name, age, isApexPredator, numOfCaloriesForADish, maxHeightOfFlight, lengthOfWings)
    {
        this.lengthOfBeak = lengthOfBeak;
    }


    public double LengthOfBeak
    {
        get => lengthOfBeak;
        set => lengthOfBeak = value;
    }

    public override string ToString()
    {
        return $"""
                {base.ToString()}
                -------------Eagle Properties:-----------
                {lengthOfBeak}
                ------------------------------------------
                """;
    }

}