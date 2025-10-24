namespace SchoolworkForYear12.Work.Recursion;

// ReSharper disable once InconsistentNaming
public static class Classwork_25_10_25
{
    public static void Main()
    {
        Start();
    }

    private static void Start()
    {
        Console.WriteLine(FlipString("abc"));

        PrintEvenDigits(26754);

        PrintNumFromLeft(26754);

        //didnt get ex39

        PrintSidra(4, 3, 8);

        PrintIncreasingJumpsSequence(8);

        int[][] array2D = new int[][]
        {
            [1, 5, 3],
            [7, 2, 9],
            [4, 6, 8]
        };

        PrintMaxValueInEachRowOf2DArray(array2D,0);

        PrintSub2DArray(array2D, 1, 0);


    }

    /**
     * ex46
     */
    private static void PrintSub2DArray(int[][] array2D, int curY, int curX)
    {
        if(curY == array2D.Length)
            return;

        PrintRemainingOfCollections(array2D[curY], curX);

        PrintSub2DArray(array2D, curY+1, curX);
    }

    private static void PrintRemainingOfCollections(int[] collection, int curX)
    {
        if (curX == collection.Length)
            return;

        Console.WriteLine(collection[curX]);

        PrintRemainingOfCollections(collection, curX+1);
    }

    /**
     * ex45
     */
    private static void PrintMaxValueInEachRowOf2DArray(int[][] array2D, int curRow)
    {
        if (curRow == array2D.Length)
            return;

        Console.WriteLine(GetMaxValueFromRow(array2D[curRow],0));

        PrintMaxValueInEachRowOf2DArray(array2D, curRow+1);
    }

    private static int GetMaxValueFromRow(int[] collection,int index)
    {
        if (index == collection.Length)
            return 0;

        return Math.Max(collection[index], GetMaxValueFromRow(collection, index + 1));


    }

    /**
     * ex41
     */
    private static void PrintIncreasingJumpsSequence(int goalElement)
    {
        PrintEachDigitOfNum(goalElement,1,1);
    }

    private static void PrintEachDigitOfNum(int goalElement, int curElement, int curValue)
    {
        if (curElement > goalElement)
            return;

        Console.WriteLine(curValue);

        curValue += curElement;

        PrintEachDigitOfNum(goalElement, curElement+1, curValue);
    }

    /**
     * ex40
     */
    private static void PrintSidra(int a1, int d, int numOfElements)
    {
        if (numOfElements == 0)
            return;

        PrintSidra(a1, d, numOfElements-1);
        Console.WriteLine(a1+d*(numOfElements-1));
    }

    /**
     * ex38
     */
    private static void PrintNumFromLeft(int num)
    {
        var flippedNum = int.Parse(FlipString(num.ToString()));

        PrintEachDigitOfNum(flippedNum);
    }

    private static void PrintEachDigitOfNum(int num)
    {
        if (num == 0)
            return;

        Console.WriteLine(num%10);

        PrintEachDigitOfNum(num/10);
    }

    /**
     * ex37
     */
    private static void PrintEvenDigits(int num)
    {
        if (num == 0)
            return;

        PrintEvenDigits(num/10);

        if (num%2==0)
            Console.WriteLine(num%10);
    }

    /**
     * ex34
     */
    private static string FlipString(string str)
    {
        return FlipString(0, str);
    }

    private static string FlipString(int index, string str)
    {
        if (index == str.Length)
            return "";

        return FlipString(index+1, str) + str[index];
    }
}