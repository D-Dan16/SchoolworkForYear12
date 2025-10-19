namespace SchoolworkForYear12.Work.Recursion.Classwork_19_10_25;

public static class QuadraticFormula
{
    static void Main()
    {
        Start();
    }

    private static void Start()
    {
        Console.WriteLine("Enter N to stop. Y to continue ");
        char kelet = Console.ReadLine()![0];

        while (kelet != 'N')
        {
            Console.WriteLine("Input the three");
            var a = int.Parse(Console.ReadLine()!);
            var b = int.Parse(Console.ReadLine()!);
            var c = int.Parse(Console.ReadLine()!);

            var numberOfSolutions = GetNumberOfSolutions(a,b,c);
            Console.WriteLine($"Num of solutions: {numberOfSolutions}");

            PrintSolution(
                a,
                b,
                c,
                numberOfSolutions
            );

            Console.WriteLine("Enter N to stop. Y to continue ");
            kelet = Console.ReadLine()![0];
        }

    }

    private static void PrintSolution(int a, int b, int c, int numOfSolutions)
    {
        switch (numOfSolutions)
        {
            case 0:
                break;
            case 1:
                Console.WriteLine(-b/2*a);
                break;
            case 2:
                double discriminant = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
                Console.WriteLine(
                    (-b+discriminant)/2*a + " with " +
                    (-b-discriminant)/2*a
                );
                break;
        }
    }

    private static int GetNumberOfSolutions(int a, int b, int c)
    {
        var discriminant = Math.Sqrt(Math.Pow(b,2)-4*a*c);
        switch (discriminant)
        {
            case > 0:
                return 2;
            case 0:
                return 1;
            default:
                return 0;
        }
    }
}