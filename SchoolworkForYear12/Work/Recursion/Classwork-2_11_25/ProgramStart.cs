namespace SchoolworkForYear12.Work.Recursion.Classwork_2_11_25;

public static class ProgramStart
{
    public static void Main_()
    {
        int[] elements = [1,2,3,4,5];
        var head = CreateLinkedList(elements);
        var head2 = CreateLinkedList(elements);
        var head3 = CreateLinkedList(elements);

        Console.WriteLine(ServicesNode.AddNode(head, head!.GetNext().GetNext(), 1000));
        Console.WriteLine(ServicesNode.AddNode(head2,head2!.GetNext(), 1000));
        Console.WriteLine(ServicesNode.AddNode(head3,null, 1000));
        Console.WriteLine(ServicesNode.AddNode(null,null, 1000));
    }

    private static Node<T>? CreateLinkedList<T>(T[] elements)
    {
         Node<T>? curNode = null, prevNode = null;
        for (var i = elements.Length - 1; i >= 0; i--)
        {
            curNode = new Node<T>(elements[i],prevNode);
            prevNode = curNode;
        }

        return curNode;
    }
}