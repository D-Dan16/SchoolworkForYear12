namespace SchoolworkForYear12.Work.Inheritance.Homework_5_1_26.Question3;

public class MountainBike : Bike
{
    private int maxHeightToRide;
    private bool isHighGear;

    public MountainBike(string color, int maxVelocity, double mileage, int maxHeightToRide, bool isHighGear)
        : base(color, maxVelocity, mileage)
    {
        this.maxHeightToRide = maxHeightToRide;
        this.isHighGear = isHighGear;
    }

    public int MaxHeightToRide
    {
        get => maxHeightToRide;
        set => maxHeightToRide = value;
    }


    public void SetHighGear() {}
}