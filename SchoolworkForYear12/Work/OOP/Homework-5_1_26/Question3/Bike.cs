namespace SchoolworkForYear12.Work.Inheritance.Homework_5_1_26.Question3;

public class Bike
{
    private string color;
    private int maxVelocity;
    private double mileage;

    public Bike(string color, int maxVelocity, double mileage)
    {
        this.color = color;
        this.maxVelocity = maxVelocity;
        this.mileage = mileage;
    }

    public string Color
    {
        get => color;
        set => color = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int MaxVelocity
    {
        get => maxVelocity;
        set => maxVelocity = value;
    }

    public double Mileage
    {
        get => mileage;
        set => mileage = value;
    }

    public void Ride(double distance) { }
}