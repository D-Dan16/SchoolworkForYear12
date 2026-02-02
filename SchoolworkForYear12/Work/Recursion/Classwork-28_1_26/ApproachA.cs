namespace SchoolworkForYear12.Work.Recursion.Classwork_28_1_26;

public static class ApproachA
{
    public static bool IsPalindrome(Node<int>? lst, int lengthOfSub)
    {
        if (lst == null)
            return true;

        int sizeLst = ServicesNode.count(lst);
        int lastLegalIndex = sizeLst - lengthOfSub;

        int index = 0;
        for (Node<int>? curNode = lst; curNode != null && index <= lastLegalIndex; curNode = curNode.GetNext())
        {
            if (IsElementPalindrome(lst,lengthOfSub,index))
                return true;

            index++;
        }

        return false;
    }

    private static bool IsElementPalindrome(Node<int> lst, int lengthOfSub, int pivotIndex)
    {
        for (int leftPtr = pivotIndex, rightPtr = pivotIndex + lengthOfSub-1; leftPtr <= rightPtr; leftPtr++, rightPtr--)
        {
            if (ServicesNode.getElementAtIndex(lst,leftPtr) != ServicesNode.getElementAtIndex(lst,rightPtr))
                return false;
        }

        return true;
    }
}