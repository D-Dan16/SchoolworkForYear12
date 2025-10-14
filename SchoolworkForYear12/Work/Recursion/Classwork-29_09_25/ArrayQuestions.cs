namespace SchoolworkForYear12.Work.Recursion.Classwork_29_09_25;

public static class ArrayQuestions
{
    public static void Main()
    {
        Start();
    }

    private static void Start()
    {
        int[] arr = [4,6,7,8,9,10];
        SumElementsUntil(8, arr);

        CountPositiveElementsUntilIndex(4, arr);

        IsArraySorted(arr);

        IsNotContainingPrimes(arr);

        int[,] arr2D = new[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        CountNumIn2DArray(arr2D,5,arr2D.GetLength(0)-1);

        //TODO: EX20

        const string str = "This is a STRING, that ALSO contains 12345";
        CountLowerCaseInString(str);

        PrintDividers(16);

        PrintElements(7, 3, 5);

        PrintAlternatingSequence(10);

        //TODO: rest

    }

    /**
     * ex30
     */
    private static void PrintAlternatingSequence(int numOfElements)
    {
        if (numOfElements == 0)
            return;

        PrintAlternatingSequence1(4,0);
        return;

        void PrintAlternatingSequence1(int curNum, int index)
        {
            if (index == numOfElements)
                return;

            Console.WriteLine(curNum);

            var offset = index % 2 == 0 ? -1 : 2;
            var newNum = curNum + offset;

            PrintAlternatingSequence1(newNum, index + 1);
        }
    }

    /**
     * ex28
     */
    private static void PrintElements(int curElement, int distanceBetweenElements, int numOfElementsToPrint)
    {
        if (numOfElementsToPrint == 0)
            return;

        Console.WriteLine(curElement);

        PrintElements(curElement+distanceBetweenElements, distanceBetweenElements, numOfElementsToPrint-1);
    }

    /**
     * ex25
     */
    private static void PrintDividers(int num)
    {
        if (num is 1 or 2)
            return;

        PrintDividers(num,2);
        return;

        static void PrintDividers(int num, int divisor)
        {
            if (divisor*2 >= num)
                return;

            PrintDividers(num, divisor+1);

            if (num % divisor == 0)
                Console.WriteLine(divisor);
        }
    }

    // ReSharper disable once UnusedMethodReturnValue.Local
    /**
     * ex21
     */
    private static int CountLowerCaseInString(string str)
    {
        return CountLowerCaseInString(str, 0);

        static int CountLowerCaseInString(string str, int curCharIndex)
        {
            if (curCharIndex >= str.Length)
                return 0;

            int incrementIfIsLowerCase = str[curCharIndex] >= 97 && str[curCharIndex] <= 122 ? 1 : 0;

            return
                incrementIfIsLowerCase +
                CountLowerCaseInString(str, curCharIndex + 1);
        }
    }

    /**
     * ex19
     */
    private static int CountNumIn2DArray(int[,] arr2D, int lookedForNum, int row)
    {
        if (row < 0)
            return 0;

        return
            IsThereNumInRow(lookedForNum, row) ? 1 : 0  +
            CountNumIn2DArray(arr2D, lookedForNum, row - 1 );

        bool IsThereNumInRow(int checkedNum, int selectedRow, int elementNum = 0)
        {
            if (elementNum > arr2D.GetLength(1))
                return false;

            if (arr2D[selectedRow, elementNum] == checkedNum)
                return true;

            return IsThereNumInRow(checkedNum, selectedRow, elementNum + 1);
        }
    }

    /**
     * ex18
     */
    private static bool IsNotContainingPrimes(int[] arr,int index = 0)
    {
        if (index >= arr.Length - 1)
            return true;

        if (!IsPrime(arr[index]))
            return false;

        return IsNotContainingPrimes(arr, index + 1);

        bool IsPrime(int integer,int divisor = 2)
        {
            if (divisor >= Math.Sqrt(integer))
                return true;

            if (integer % divisor == 0)
                return false;

            return IsPrime(integer, divisor + 1);
        }
    }

    /**
     * ex17
     */
    private static bool IsArraySorted(int[] arr, int index = 0)
    {
        if (index >= arr.Length - 1)
            return true;

        if (arr[index] > arr[index - 1])
            return false;

        return IsArraySorted(arr, index + 1);
    }

    /**
     * ex15
     */
    private static int CountPositiveElementsUntilIndex(int index, int[] arr)
    {
        if (index < 0 || index >= arr.Length) return 0;
        return (arr[index] > 0 ? 1 : 0) + CountPositiveElementsUntilIndex(index - 1, arr);
    }

    /**
     * ex14
     */
    private static int SumElementsUntil(int index, int[] arr)
    {
        if (index < 0 || index >= arr.Length) return 0;
        return arr[index] + SumElementsUntil(index - 1, arr);
    }
}