namespace SchoolworkForYear12.Work.OOP.TheZoo.ZooAnimals;

public class Animal
{
    protected string name;
    protected int age;
    protected bool isApexPredator;
    protected int numOfCaloriesForADish;

    public Animal(string name, int age, bool isApexPredator, int numOfCaloriesForADish)
    {
        this.name = name;
        this.age = age;
        this.isApexPredator = isApexPredator;
        this.numOfCaloriesForADish = numOfCaloriesForADish;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public bool IsApexPredator
    {
        get => isApexPredator;
        set => isApexPredator = value;
    }

    public int NumOfCaloriesForADish
    {
        get => numOfCaloriesForADish;
        set => numOfCaloriesForADish = value;
    }

    public override string ToString()
    {
        return $"""
                ---------Animal Properties:-----------
                {this.Name},{this.Age},{this.IsApexPredator},{this.NumOfCaloriesForADish}
                --------------------------------------
                """;
    }

    public virtual int Eat()
    {
        return numOfCaloriesForADish*3;
    }
}