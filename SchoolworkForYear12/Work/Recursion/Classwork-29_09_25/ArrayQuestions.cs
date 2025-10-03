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
    }

    /**
     * ex17
     */
    private static bool IsArraySorted(int[] arr)
    {
        return IsArraySorted(arr, 0);
    }

    private static bool IsArraySorted(int[] arr, int index)
    {
        if (index == arr.Length - 1)
            return true;

        if (arr[index] > arr[index - 1])
            return false;

        return IsArraySorted(arr, index + 1);
    }

    /**
     * ex15
     */
    //TODO: fix algo
    private static int CountPositiveElementsUntilIndex(int index, int[] arr)
    {
        if (index > arr.Length - 1)
            return -1;
        else
            return CountPositiveElementsUntilIndex(index+1, arr);
    }

    private static int CountPositiveElementsUntilIndexHelper(int index, int[] arr)
    {
        if (index == -1) return 0;

        int toAdd = arr[index] > 0 ? arr[index] : 0;

        return toAdd + CountPositiveElementsUntilIndexHelper(index - 1, arr);
    }

    /**
     * ex14
     */
    private static int SumElementsUntil(int index, int[] arr)
    {
        if (index > arr.Length - 1)
            return -1;
        else
            return SumElementsUntilHelper(index, arr);
    }

    private static int SumElementsUntilHelper(int index, int[] arr)
    {
        if (index == 0) return arr[0];

        return arr[index] + SumElementsUntilHelper(index - 1, arr);
    }
}