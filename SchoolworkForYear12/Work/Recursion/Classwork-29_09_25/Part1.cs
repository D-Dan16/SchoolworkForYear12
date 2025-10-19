namespace SchoolworkForYear12.Work.Recursion.Classwork_29_09_25;

public static class Part1
{
    public static void Start()
    {
        SumNumbers(5);

        ProductOfUneven(5);

        SumOfEven(9);

        GetLeftDigit(2875);

        GetQuotient(16, 3);
    }

    //ex7
    private static int GetQuotient(int firstNum, int secondNum)
    {
        if (firstNum < secondNum)
            return 0;

        return 1 + GetQuotient(firstNum - secondNum, secondNum);
    }


    //ex6
    private static int GetLeftDigit(int num)
    {
        if (num / 10 == 0)
            return num;

        return GetLeftDigit(num / 10);
    }

    //ex5
    private static int SumOfEven(int n)
    {
        if (n <= 2)
            return n;
        
        //always align the number to be even
        if (n % 2 == 1)
            SumOfEven(n - 1);

        return SumOfEven(n - 2) + n;
    }

    //ex2
    private static int ProductOfUneven(int n)
    {
        if (n <= 1)
            return n;
        
        //always align the number to be odd
        if (n % 2 == 0)
            ProductOfUneven(n - 1);

        return ProductOfUneven(n - 2) * n;
    }

    //ex1
    private static int SumNumbers(int n)
    {
        if (n == 1) return 1;
        return SumNumbers(n - 1) + n;
    }
}