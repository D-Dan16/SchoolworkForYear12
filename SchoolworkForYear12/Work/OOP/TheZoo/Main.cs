using SchoolworkForYear12.Work.Inheritance.TheZoo;
using SchoolworkForYear12.Work.OOP.TheZoo.ZooAnimals;

namespace SchoolworkForYear12.Work.OOP.TheZoo;

public static class Main
{
    public static void Start()

    {
        Animal[] animals =
        [
            new Cow("Bessie", 5, false, 6000, 700, 9, 1),
            new Hippo("Hippo Henry", 7, false, 8000, 1200, 8, 28.5),
            new Hippo("Hippo Gloria", 10, false, 9000, 1500, 8, 32.0),
            new Hippo("Hippo Moto Moto", 5, false, 10000, 1800, 8, 35.5),
            new Bird("Shira", 4, false, 320, 140.0, 0.4),
            new Eagle("Aquila", 3, true, 1500, 3500.0, 2.1, 7.5),
            new Snake("Viper", 4, true, 500, 1.2, true),
            new Bird("Robin", 2, false, 300, 100.0, 0.25)
        ];

        int sumOfCalories = 0;
        foreach (Animal animal in animals)
            sumOfCalories += animal.Eat();
        Console.WriteLine(sumOfCalories);

        MakeAllBirdsSing(animals);

        MakeAllBirdsAndSnakesDance(animals);

        Console.WriteLine(CalculateHippoWithHighestFatPercentage(animals));


    }

    private static string CalculateHippoWithHighestFatPercentage(Animal[] animals)
    {
        double hippoWithHighestFatPercentage = -1;
        string nameOfHipoWithHighestFatPercentage = "";

        foreach (var animal in animals)
        {
            if (animal is Hippo hippo)
            {
                if (hippo.FatPercentage > hippoWithHighestFatPercentage)
                    nameOfHipoWithHighestFatPercentage = hippo.Name;
            }
        }

        return nameOfHipoWithHighestFatPercentage;
    }

    private static void MakeAllBirdsAndSnakesDance(Animal[] animals)
    {
        foreach (var animal in animals)
        {
            switch (animal)
            {
                case Bird bird:
                    bird.Dance();
                    break;
                case Snake snake:
                    snake.Dance();
                    break;
            }
        }
    }

    private static void MakeAllBirdsSing(Animal[] animals)
    {
        foreach (var animal in animals)
            if (animal is Bird bird)
                bird.Sing();
    }

}