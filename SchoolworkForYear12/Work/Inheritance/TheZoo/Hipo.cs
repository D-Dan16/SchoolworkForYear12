namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Hipo : Mammal
{
    protected double fatPercentage;


    public Hipo(string name, int age, string apexPredator, string numOfCaloriesForADish, int milkInKalories, int numOfMonthesOfPregnancy, double fatPercentage) : base(name, age, apexPredator, numOfCaloriesForADish, milkInKalories, numOfMonthesOfPregnancy)
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