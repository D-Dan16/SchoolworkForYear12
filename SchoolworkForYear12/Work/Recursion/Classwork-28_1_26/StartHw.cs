namespace SchoolworkForYear12.Work.Recursion.Classwork_28_1_26;

public class StartHw
{
    public static void Start()
    {
        var listATrue = ServicesNode.CreateLinkedList([-1, -2, -3, -4, -5, -6, 9, 8, 7, 6, 7, 8, 9, -7, -8]);
        var listBTrue = ServicesNode.CreateLinkedList([-1, -2, -3, -4, -5, -6, 8, 7, 6, 6, 7, 8]);

        var listAFalse = ServicesNode.CreateLinkedList([-1, -2, -3, -4, -5, -6, 9, 8, 8, 6, 7, 8, 9, -7, -8]);
        var listBFalse = ServicesNode.CreateLinkedList([-1, -2, -3, -4, -5, -6, 8, 7, 6, 6, 7, 8]);

        //Iterative
        ApproachA.IsPalindrome(listATrue,7);
        //Recursive
        ApproachB.IsPalindrome(listATrue,7);
    }
}