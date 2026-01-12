using SchoolworkForYear12.Work.Inheritance.Homework_5_11_25;

namespace SchoolworkForYear12.Work.Inheritance.Homework_5_1_26;

public class Main
{
    public static void Start()
    {
        Car car1 = new Car("Yotsrim","2008","1111", 0,10);
        ElectricCar car2 = new ElectricCar("Yotsrim1","2010","2222", 0,10,new Date(1,1,2027));

        Console.WriteLine(car1);
        Console.WriteLine(car2);

        int accelarationAmount = int.Parse(Console.ReadLine() ?? string.Empty);
        car1.Accelerate(accelarationAmount);

        car2.SlowDown();
        car2.SlowDown();
        car2.SlowDown();

        // And so on..
        // Like this is just bullshit like it doesn't test any shit...


    }
}