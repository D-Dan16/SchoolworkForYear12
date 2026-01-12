namespace SchoolworkForYear12.Work.OOP.TheZoo.ZooAnimals;

public class Bird : Animal
{
    protected double maxHeightOfFlight;
    protected double lengthOfWings;


    public Bird(string name, int age, bool isApexPredator, int numOfCaloriesForADish, double maxHeightOfFlight, double lengthOfWings) : base(name, age, isApexPredator, numOfCaloriesForADish)
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


    public override int Eat()
    {
        return numOfCaloriesForADish*2;
    }

    public void Sing()
    {
        Console.WriteLine("The bird goes chirp chirp chirp");
    }

    public void Dance()
    {
        Console.WriteLine("The bird dances!");
    }
}