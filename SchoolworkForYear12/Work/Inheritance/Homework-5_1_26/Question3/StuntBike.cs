namespace SchoolworkForYear12.Work.Inheritance.Homework_5_1_26.Question3;

public class StuntBike : Bike
{
    private bool appropriateForCompetition;
    private double maxJumpingHeight;

    public StuntBike(string color, int maxVelocity, double mileage, bool appropriateForCompetition, double maxJumpingHeight) : base(color, maxVelocity, mileage)
    {
        this.appropriateForCompetition = appropriateForCompetition;
        this.maxJumpingHeight = maxJumpingHeight;
    }

    public void Jump(double height) {}
}