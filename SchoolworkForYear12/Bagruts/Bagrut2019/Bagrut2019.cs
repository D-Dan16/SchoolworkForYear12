namespace SchoolworkForYear12.Bagruts;

public class Bagrut2019
{
    public static void start()
    {
    }

    private static void ThreeFlashlight(Flashlight[] arr, int total)
    {
        if (arr.Length < 3)
            return;

        bool found = false;

        for (int first = 0; first < arr.Length-2 && !found; first++)
            for (int second = first+1; second < arr.Length-1 && !found; second++)
                for (int third = second+1; third < arr.Length && !found; third++)
                    if (arr[first].Price + arr[second].Price + arr[third].Price == total)
                    {
                        Console.WriteLine(arr[first].Model);
                        Console.WriteLine(arr[second].Model);
                        Console.WriteLine(arr[third].Model);

                        found = true;
                    }
    }
}