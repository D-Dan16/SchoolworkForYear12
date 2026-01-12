using SchoolworkForYear12.Work.OOP.TheZoo.ZooAnimals;

namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Mammal : Animal
{
    protected int MilkInCalories;
    protected int NumOfMonthsOfPregnancy;

    public Mammal(string name, int age, bool isApexPredator, int numOfCaloriesForADish, int milkInCalories, int numOfMonthsOfPregnancy) : base(name, age, isApexPredator, numOfCaloriesForADish)
    {
        this.MilkInCalories = milkInCalories;
        this.NumOfMonthsOfPregnancy = numOfMonthsOfPregnancy;
    }

    public int MilkInKalories
    {
        get => MilkInCalories;
        set => MilkInCalories = value;
    }

    public int NumOfMonthesOfPregnancy
    {
        get => NumOfMonthsOfPregnancy;
        set => NumOfMonthsOfPregnancy = value;
    }

    public override string ToString()
    {
        return $"""
                {base.ToString()}
                -------------Mammal Properties:-----------------
                {MilkInCalories},{NumOfMonthsOfPregnancy}
                ------------------------------------------------
                """;
    }

    public override int Eat()
    {
        return base.Eat()+MilkInCalories;
    }

}