namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Mammal : Animal
{
    protected int milkInKalories;
    protected int numOfMonthesOfPregnancy;

    public Mammal(string name, int age, string apexPredator, string numOfCaloriesForADish, int milkInKalories, int numOfMonthesOfPregnancy) : base(name, age, apexPredator, numOfCaloriesForADish)
    {
        this.milkInKalories = milkInKalories;
        this.numOfMonthesOfPregnancy = numOfMonthesOfPregnancy;
    }

    public int MilkInKalories
    {
        get => milkInKalories;
        set => milkInKalories = value;
    }

    public int NumOfMonthesOfPregnancy
    {
        get => numOfMonthesOfPregnancy;
        set => numOfMonthesOfPregnancy = value;
    }

    public override string ToString()
    {
        return $"""
                {base.ToString()}
                -------------Mammal Properties:-----------------
                {milkInKalories},{numOfMonthesOfPregnancy}
                ------------------------------------------------
                """;
    }
    
}