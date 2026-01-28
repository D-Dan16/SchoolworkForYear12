namespace SchoolworkForYear12.Work.Recursion.Classwork_28_1_26;

public static class ApproachA
{
    public static bool IsPalindrome(Node<int>? lst, int n)
    {
        if (lst == null)
            return true;

        int index = 0;
        for (Node<int>? curNode = lst; curNode != null; curNode = curNode.GetNext())
        {
            if (IsElementPalindrome(lst,n,index))
                return true;

            index++;
        }

        return false;
    }

    private static bool IsElementPalindrome(Node<int> lst, int n, int index)
    {
        if (index < n ||  )
    }
}