namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Animal
{
    protected string name;
    protected int age;
    protected string apexPredator;
    protected string numOfCaloriesForADish;

    public Animal(string name, int age, string apexPredator, string numOfCaloriesForADish)
    {
        this.name = name;
        this.age = age;
        this.apexPredator = apexPredator;
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

    public string ApexPredator
    {
        get => apexPredator;
        set => apexPredator = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string NumOfCaloriesForADish
    {
        get => numOfCaloriesForADish;
        set => numOfCaloriesForADish = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return $"""
                ---------Animal Properties:-----------
                {this.Name},{this.Age},{this.ApexPredator},{this.NumOfCaloriesForADish}
                --------------------------------------
                """;
    }
}