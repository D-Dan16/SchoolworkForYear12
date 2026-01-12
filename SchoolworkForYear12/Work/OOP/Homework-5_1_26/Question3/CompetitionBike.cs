using SchoolworkForYear12.Work.Inheritance.Homework_5_11_25;

namespace SchoolworkForYear12.Work.Inheritance.Homework_5_1_26.Question3;

public class CompetitionBike : Bike
{
    private Date lastFixDate;


    public CompetitionBike(string color, int maxVelocity, double mileage, Date lastFixDate) : base(color, maxVelocity, mileage)
    {
        this.lastFixDate = lastFixDate;
    }
}