namespace SchoolworkForYear12.Bagruts;

public class Flashlight
{
    private string model;
    private double price;

    public Flashlight(string model, double price)
    {
        this.model = model;
        this.price = price;
    }

    public string Model
    {
        get => model;
        set => model = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Price
    {
        get => price;
        set => price = value;
    }

}