using SchoolworkForYear12.Work.Inheritance.Homework_5_11_25;

namespace SchoolworkForYear12.Work.Inheritance.Homework_5_1_26;

public class ElectricCar : Car
{
    private Date batteryReplacementDate;

    public ElectricCar(string manufacturer, string yearOfCreation, string registrationNumber, int curVelocity, Date batteryReplacementDate)
        : base(manufacturer, yearOfCreation, registrationNumber, curVelocity)
    {
        this.batteryReplacementDate = batteryReplacementDate;
    }

    public ElectricCar(string manufacturer, string yearOfCreation, string registrationNumber, double mileage, int curVelocity, Date batteryReplacementDate)
        : base(manufacturer, yearOfCreation, registrationNumber, curVelocity,
            mileage
        )
    {
        this.batteryReplacementDate = batteryReplacementDate;
    }

    public ElectricCar(ElectricCar other)
        : base(other)
    {
        this.batteryReplacementDate = new Date(other.batteryReplacementDate);
    }

    public Date BatteryReplacementDate
    {
        get => batteryReplacementDate;
        set => batteryReplacementDate = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return base.ToString() + $",{batteryReplacementDate}";
    }

    public void RefreshBattery()
    {
        Date curDate = Date.GetCurDate();
        curDate.SetYear(curDate.GetYear() + 1);
        batteryReplacementDate = curDate;
    }

}