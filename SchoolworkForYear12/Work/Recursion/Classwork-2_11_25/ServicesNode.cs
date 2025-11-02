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
}