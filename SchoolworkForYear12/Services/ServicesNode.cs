namespace SchoolworkForYear12.Work;

public static class ServicesNode
{
    public static Node<T> AddNode<T>(Node<T>? head,Node<T>? after,T value)
    {
        var newNode = new Node<T>(value);

        if (head == null)
            return newNode;

        if (after == null)
        {
            newNode.SetNext(head);
            return newNode;
        }

        var curNode = head;
        while (curNode != null)
        {
            if (curNode == after)
            {
                var nodeToLinkTo = curNode.GetNext();
                curNode.SetNext(newNode);
                newNode.SetNext(nodeToLinkTo);

                break;
            }

            curNode = curNode.GetNext();
        }

        return head;
    }

    public static Node<T>? CreateLinkedList<T>(T[] elements)
    {
        Node<T>? curNode = null, prevNode = null;
        for (var i = elements.Length - 1; i >= 0; i--)
        {
            curNode = new Node<T>(elements[i],prevNode);
            prevNode = curNode;
        }

        return curNode;
    }

    public static int count(Node<int> lst)
    {
        int counter = 0;
        for (Node<int> cur = lst; cur != null; cur = cur.GetNext())
            counter++;

        return counter;
    }

    public static int getElementAtIndex(Node<int> lst, int index)
    {
        int count = 0;
        var curNode = lst;

        while (count < index)
        {
            curNode = curNode.GetNext();
            count++;
        }

        return curNode.GetValue();
    }
}