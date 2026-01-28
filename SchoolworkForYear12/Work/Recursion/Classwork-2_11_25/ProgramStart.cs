namespace SchoolworkForYear12.Work.Recursion.Classwork_2_11_25;

public static class ProgramStart
{
    public static void Main_()
    {
        int[] elements = [1,2,3,4,5];
        var head = ServicesNode.CreateLinkedList(elements);
        var head2 = ServicesNode.CreateLinkedList(elements);
        var head3 = ServicesNode.CreateLinkedList(elements);

        Console.WriteLine(ServicesNode.AddNode(head, head!.GetNext().GetNext(), 1000));
        Console.WriteLine(ServicesNode.AddNode(head2,head2!.GetNext(), 1000));
        Console.WriteLine(ServicesNode.AddNode(head3,null, 1000));
        Console.WriteLine(ServicesNode.AddNode(null,null, 1000));
    }


}