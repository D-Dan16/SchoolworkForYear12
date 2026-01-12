namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Bird : Animal
{
    protected double maxHeightOfFlight;
    protected double lengthOfWings;


    public Bird(string name, int age, string apexPredator, string numOfCaloriesForADish, double maxHeightOfFlight, double lengthOfWings) : base(name, age, apexPredator, numOfCaloriesForADish)
    {
        this.maxHeightOfFlight = maxHeightOfFlight;
        this.lengthOfWings = lengthOfWings;
    }

    public double MaxHeightOfFlight
    {
        get => maxHeightOfFlight;
        set => maxHeightOfFlight = value;
    }

    public double LengthOfWings
    {
        get => lengthOfWings;
        set => lengthOfWings = value;
    }
    
    
    public override string ToString()
    {
        return $"""
                {base.ToString()}
                -------------Bird Properties:-----------
                {maxHeightOfFlight},{lengthOfWings}
                ------------------------------------------
                """;
    }

}