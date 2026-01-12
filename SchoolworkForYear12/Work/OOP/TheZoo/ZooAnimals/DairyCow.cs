using SchoolworkForYear12.Work.OOP.TheZoo.ZooAnimals;

namespace SchoolworkForYear12.Work.Inheritance.TheZoo;

public class DairyCow : Cow
{
    private double litersOfMilkThatCanProduceInADay;

    public DairyCow(string name, int age, bool isApexPredator,
        int numOfCaloriesForADish,
        int milkInCalories,
        int numOfMonthsOfPregnancy,
        int numOfCalves,
        double litersOfMilkThatCanProduceInADay
    ) : base(name, age,
        isApexPredator, numOfCaloriesForADish,
        milkInCalories, numOfMonthsOfPregnancy,
        numOfCalves
    )
    {
        this.litersOfMilkThatCanProduceInADay = litersOfMilkThatCanProduceInADay;
    }

    public double LitersOfMilkThatCanProduceInADay
    {
        get => litersOfMilkThatCanProduceInADay;
        set => litersOfMilkThatCanProduceInADay = value;
    }

    public override string ToString()
    {
        return $"""
                {base.ToString()}
                -------------DairyCow Properties:-----------
                {litersOfMilkThatCanProduceInADay}
                ------------------------------------------
                """;
    }

}