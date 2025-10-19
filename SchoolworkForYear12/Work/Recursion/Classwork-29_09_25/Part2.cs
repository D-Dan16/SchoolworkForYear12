namespace SchoolworkForYear12.Work.Recursion.Classwork_29_09_25;

public static class Part2
{
    public static void Main()
    {
        Start();
    }

    static void Start()
    {
        Console.WriteLine(CalcSumOfSequence(5));

        Console.WriteLine(CalcSumOfSequenceWithRadical(5));

        Console.WriteLine(CalcSquareOfFibonacci(5));

        int[] arr = [4,6,7,8,9,10];

        Console.WriteLine(SumElementsUntil(4, arr));

        Console.WriteLine(SumElementsFrom(4, arr));

        Console.WriteLine(CountPositiveElementsUntilIndex(3, arr));

        Console.WriteLine(IsArraySorted(arr));

        Console.WriteLine(FindIndexOfElement(arr, 8));

        Console.WriteLine(HasPrimeInArray(arr));

        int[,] arr2D = new[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine(IsMatBiggerThan(arr2D, 3));

        Console.WriteLine(CountNumIn2DArray(4, arr2D, arr2D.GetLength(0) - 1));



    }

    /** ex30 */
    static int CountNumIn2DArray(int lookedForNum, int[,] arr2D, int row)
    {
        if (row < 0)
            return 0;

        return
            IsThereNumInRow(lookedForNum, row, arr2D) ? 1 : 0  +
            CountNumIn2DArray(lookedForNum, arr2D, row - 1);
    }

    private static bool IsThereNumInRow(int checkedNum, int selectedRow, int[,] arr2D, int elementNum = 0)
    {
        if (elementNum > arr2D.GetLength(1) - 1)
            return false;

        if (arr2D[selectedRow, elementNum] == checkedNum)
            return true;

        return IsThereNumInRow(checkedNum, selectedRow, arr2D, elementNum + 1);
    }


    /**
     * ex28
     */
    static bool IsMatBiggerThan(int[,] arr2D, int comparedVal)
    {
        return IsMatBiggerThan(arr2D, comparedVal, 0);
    }

    static bool IsMatBiggerThan(int[,] arr2D, int lookedForNum, int row)
    {
        if (row > arr2D.GetLength(0))
            return true;

        if (!IsRowBiggerThan(lookedForNum))
            return false;

        return IsMatBiggerThan(arr2D, lookedForNum, row+1);

        bool IsRowBiggerThan(int comparisonValue, int elementNum = 0)
        {
            if (elementNum > arr2D.GetLength(1))
                return true;

            if (arr2D[row, elementNum] < comparisonValue)
                return false;

            return IsRowBiggerThan(comparisonValue, elementNum + 1);
        }
    }

    /**
     * ex25
     */
    static bool HasPrimeInArray(int[] arr)
    {
        return HasPrimeInArray(arr, 0);
    }

    static bool HasPrimeInArray(int[] arr, int index)
    {
        if (index > arr.Length - 1)
            return false;

        if (IsPrime(arr[index]))
            return true;

        return HasPrimeInArray(arr, index+1);
    }

    static bool IsPrime(int integer,int divisor = 2)
    {
        if (divisor >= Math.Sqrt(integer))
            return true;

        if (integer % divisor == 0)
            return false;

        return IsPrime(integer, divisor + 1);
    }

    /**
     * ex22
     */
    static int FindIndexOfElement(int[] arr, int element)
    {
        return FindIndexOfElement(arr, element,0);
    }

    static int FindIndexOfElement(int[] arr, int element, int index)
    {
        if (index > arr.Length - 1)
            return -1;

        if (arr[index] == element)
            return index;

        return FindIndexOfElement(arr, element, index+1);
    }


    /**
     * ex21
     */
    static bool IsArraySorted(int[] arr, int index = 1)
    {
        if (index >= arr.Length - 1)
            return true;

        if (arr[index] > arr[index - 1])
            return false;

        return IsArraySorted(arr, index + 1);
    }


    /**
    * ex20
    */
    static int CountPositiveElementsUntilIndex(int index, int[] arr)
    {
        if (index < 0 || index >= arr.Length) return 0;
        return (arr[index] > 0 ? 1 : 0) + CountPositiveElementsUntilIndex(index - 1, arr);
    }


    /**
     * ex19
     */
    static int SumElementsFrom(int index, int[] arr)
    {
        if (index < 0 || index >= arr.Length) return 0;
        return arr[index] + SumElementsFrom(index + 1, arr);
    }

    /**
     * ex18
     */
    static int SumElementsUntil(int index, int[] arr)
    {
        if (index < 0 || index >= arr.Length) return 0;
        return arr[index] + SumElementsUntil(index - 1, arr);
    }


    /**
     * ex17
     */
    static int CalcSquareOfFibonacci(int index)
    {
        switch (index)
        {
            case 1:
                return 0;
            case 2:
                return 1;
        }

        return CalcSquareOfFibonacci(index, 3, 1, 1, 0);
    }

    static int CalcSquareOfFibonacci(
        int goalIndex,
        int curIndex,
        int curValue,
        int valueBefore,
        int valueBefore2Times
    ) {
        if (curIndex == goalIndex)
            return valueBefore;

        valueBefore2Times = valueBefore;
        valueBefore = curValue;
        curValue = (int)(Math.Pow(valueBefore2Times, 2) + Math.Pow(valueBefore, 2));

        return CalcSquareOfFibonacci(goalIndex, curIndex+1, curValue, valueBefore, valueBefore2Times);
    }

    /**
     * ex15
     */
    static double CalcSumOfSequenceWithRadical(int num)
    {
        if (num == 1)
            return 1;

        int addedValue = (int)(num % 2 == 0 ?
            -Math.Sqrt(2*num-1) :
            2*num-1);

        return addedValue + CalcSumOfSequenceWithRadical(num - 1);

    }

    /**
     * ex14
     */
    static int CalcSumOfSequence(int num)
    {
        if (num == 1)
            return 2;

        int addedValue = num % 2 == 1 ? num * 2 : (int)Math.Pow(num, 2);

        return addedValue + CalcSumOfSequence(num - 1);
    }
}