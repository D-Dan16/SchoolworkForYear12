namespace SchoolworkForYear12.Work.Inheritance.Homework_5_1_26;

public class Car
{
    private string manufacturer;
    private string yearOfCreation;
    private string registrationNumber;
    private double mileage;
    private int curVelocity;

    public Car(string manufacturer, string yearOfCreation, string registrationNumber, int curVelocity)
    {
        this.manufacturer = manufacturer;
        this.yearOfCreation = yearOfCreation;
        this.registrationNumber = registrationNumber;
        this.curVelocity = curVelocity;
        this.mileage = 0;
    }

    // ReSharper disable once ConvertToPrimaryConstructor
    public Car(string manufacturer, string yearOfCreation, string registrationNumber, int curVelocity, double mileage)
    {
        this.manufacturer = manufacturer;
        this.yearOfCreation = yearOfCreation;
        this.registrationNumber = registrationNumber;
        this.mileage = mileage;
        this.curVelocity = curVelocity;
    }

    public Car(Car other)
    {
        this.manufacturer = other.manufacturer;
        this.yearOfCreation = other.yearOfCreation;
        this.registrationNumber = other.registrationNumber;
        this.mileage = other.mileage;
        this.curVelocity = other.curVelocity;
    }

    public override string ToString()
    {
        return $"""
                Car:
                {manufacturer},{yearOfCreation},{registrationNumber},{mileage},{curVelocity}
                """;
    }


    public string Manufacturer
    {
        get => manufacturer;
        set => manufacturer = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string YearOfCreation
    {
        get => yearOfCreation;
        set => yearOfCreation = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string RegistrationNumber
    {
        get => registrationNumber;
        set => registrationNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Mileage
    {
        get => mileage;
        set => mileage = value;
    }

    public int CurVelocity
    {
        get => curVelocity;
        set => curVelocity = value;
    }

    public void Accelerate(int velocityAdd)
    {
        if (velocityAdd < 0) return;

        this.curVelocity = Math.Min(curVelocity + velocityAdd, 120);
    }

    public void SlowDown()
    {
        curVelocity = Math.Max(curVelocity-10,0);
    }

    public void UpdateMileage(double kmh, double hours)
    {
        mileage += kmh * hours;
    }
}