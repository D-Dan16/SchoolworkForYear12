using SchoolworkForYear12.Work.Inheritance.TheZoo;

namespace SchoolworkForYear12.Work.OOP.TheZoo.ZooAnimals;

public class Cow : Mammal
{
    protected int numOfCalves;


    public Cow(string name, int age, bool isApexPredator, int numOfCaloriesForADish, int milkInCalories, int numOfMonthsOfPregnancy, int numOfCalves) : base(name, age, isApexPredator, numOfCaloriesForADish, milkInCalories, numOfMonthsOfPregnancy)
    {
        this.NumOfCalves = numOfCalves;
    }

    public int NumOfCalves
    {
        get => NumOfCalves;
        set => NumOfCalves = value;
    }
    
    public override string ToString()
    {
        return $"""
                {base.ToString()}
                -------------Cow Properties:-----------
                {NumOfCalves}
                ------------------------------------------
                """;
    }

    public override int Eat()
    {
        return base.Eat()/4;
    }
}