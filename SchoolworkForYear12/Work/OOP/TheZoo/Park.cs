using SchoolworkForYear12.Work.Inheritance.TheZoo;
using SchoolworkForYear12.Work.OOP.TheZoo.ZooAnimals;

namespace SchoolworkForYear12.Work.OOP.TheZoo;

public class Park
{
    private Animal[] animalsInPark = new Animal[1000];
    private int amountOfAnimals;

    public Park(Animal[] animalsInPark)
    {
        amountOfAnimals = 0;
        for (int i = 0; i < animalsInPark.Length; i++)
        {
            animalsInPark[i] = animalsInPark[i];
            amountOfAnimals++;
        }
    }

    public Animal[] AnimalsInPark
    {
        get => animalsInPark;
        set => animalsInPark = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int AmountOfAnimals
    {
        get => amountOfAnimals;
    }

    public void Add(Animal animal)
    {
        if (amountOfAnimals < 0)
            return;

        if (amountOfAnimals < 1000)
        {
            animalsInPark[amountOfAnimals] = animal;
            amountOfAnimals++;
        }
    }

    public Animal[] GetDangerousAnimals(Animal[] animals)
    {
        List<Animal> listOfDangerousAnimals = new List<Animal>();
        foreach (var animal in animals)
        {
            if (animal.Age > 10 && animal.IsApexPredator)
                listOfDangerousAnimals.Add(animal);
        }

        return listOfDangerousAnimals.ToArray();
    }

    public int CountDangerousReptilesAndPoultry(Animal[] animals)
    {
        int counter = 0;
        foreach (var animal in animals)
        {
            if (animal is Reptile or Bird && animal.IsApexPredator)
                counter++;
        }

        return counter;
    }
}