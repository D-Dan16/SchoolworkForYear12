using SchoolworkForYear12.Work.Inheritance.TheZoo;

namespace SchoolworkForYear12.Work.OOP.TheZoo.ZooAnimals;

public class Hippo : Mammal
{
    protected double fatPercentage;


    public Hippo(string name, int age, bool isApexPredator, int numOfCaloriesForADish, int milkInCalories, int numOfMonthsOfPregnancy, double fatPercentage) : base(name, age, isApexPredator, numOfCaloriesForADish, milkInCalories, numOfMonthsOfPregnancy)
    {
        this.fatPercentage = fatPercentage;
    }

    public double FatPercentage
    {
        get => fatPercentage;
        set => fatPercentage = value;
    }
    
    public override string ToString()
    {
        return $"""
                {base.ToString()}
                -------------Hipo Properties:-----------
                {fatPercentage}
                ------------------------------------------
                """;
    }

    
    
}