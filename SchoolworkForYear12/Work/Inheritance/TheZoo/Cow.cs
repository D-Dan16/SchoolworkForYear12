namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class Cow : Mammal
{
    protected int numOfCalvs;


    public Cow(string name, int age, string apexPredator, string numOfCaloriesForADish, int milkInKalories, int numOfMonthesOfPregnancy, int numOfCalvs) : base(name, age, apexPredator, numOfCaloriesForADish, milkInKalories, numOfMonthesOfPregnancy)
    {
        this.numOfCalvs = numOfCalvs;
    }

    public int NumOfCalvs
    {
        get => numOfCalvs;
        set => numOfCalvs = value;
    }
    
    public override string ToString()
    {
        return $"""
                {base.ToString()}
                -------------Cow Properties:-----------
                {numOfCalvs}
                ------------------------------------------
                """;
    }

}