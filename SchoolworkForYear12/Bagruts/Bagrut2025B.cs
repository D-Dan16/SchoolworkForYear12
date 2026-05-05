using SchoolworkForYear12.Work;
// ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
#pragma warning disable CS8604 // Possible null reference argument.

namespace SchoolworkForYear12.Bagruts;

public class Bagrut2025B
{
    public static void Start()
    {
        // #region EX1
        //
        // Node<int> lstA = ServicesNode.CreateLinkedList([5,2,2,4]);
        // Node<int> lstB = ServicesNode.CreateLinkedList([3,4,7]);
        //
        // Console.WriteLine(CreateUnion(lstA, lstB));
        // Console.WriteLine(Intersection(lstA, lstB));
        //
        // #endregion

        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
        q1.AddCollectionToQueue([2,5,4,4,7,2,6]);
        q2.AddCollectionToQueue([2,6,7,1,4,2,1,8,1]);

        Console.WriteLine(IsMConnect(q1,q2,3));
        Console.WriteLine(IsMConnect(q1,q2,2));

        Console.WriteLine(MaxConnect(q1,q2));
        Console.WriteLine(MaxConnect(q2,q1));
    }

    ///EX2 B
    private static int MaxConnect(Queue<int> q1, Queue<int> q2)
    {
        int maxM = 0;

        var shorterSize = Math.Min(Size(q1), Size(q2));
        for (int curM = 0; curM < shorterSize; curM++)
            if (IsMConnect(q1, q2, curM))
                maxM = curM;

        return maxM;
    }

    ///EX2 A
    private static bool IsMConnect(Queue<int> q1, Queue<int> q2, int M)
    {
        var sizeOfQ1 = Size(q1);

        for (int i = M; i > 0; i--)
            if (ValAt(q1, sizeOfQ1 - i) != ValAt(q2, M - i))
                return false;

        return true;
    }

    private static int Size(Queue<int> queue)
    {
        Queue<int> temp = new Queue<int>();

        int counter = 0;
        while (!queue.IsEmpty())
        {
            temp.Insert(queue.Remove());
            counter++;
        }

        while (!temp.IsEmpty())
            queue.Insert(temp.Remove());

        return counter;
    }

    private static int ValAt(Queue<int> queue, int index)
    {
        Queue<int> temp = new Queue<int>();

        var returnedVal = 0;

        int i = 0;
        while (!queue.IsEmpty())
        {
            var takenVal = queue.Remove();
            temp.Insert(takenVal);

            if (i == index)
                returnedVal = takenVal;

            i++;
        }

        while (!temp.IsEmpty())
            queue.Insert(temp.Remove());

        return returnedVal;
    }

    /// EX1 B
    private static Node<int>? Intersection(Node<int> lstA, Node<int> lstB)
    {
        Node<int> newList = null, last = null;

        var trimmedA = CreateUnion(lstA, null);
        var trimmedB = CreateUnion(lstB, null);

        for (Node<int> A = trimmedA; A != null; A = A.GetNext())
        {
            for (Node<int> B = trimmedB; B != null; B = B.GetNext())
            {
                if (A.GetValue() == B.GetValue())
                {
                    var newNode = new Node<int>(A.GetValue());

                    if (last == null)
                    {
                        newList = newNode;
                        last = newNode;
                    }
                    else
                    {
                        last.SetNext(newNode);
                        last = last.GetNext();
                    }
                }

            }
        }

        return newList;
    }

    /// EX1 A
    private static Node<int> CreateUnion(Node<int> lstA, Node<int> lstB)
    {
        Node<int> newList = new Node<int>(lstA.GetValue());

        for (Node<int> curA = lstA; curA != null; curA = curA.GetNext())
            AddIfDoesntContain(newList, curA.GetValue());
        for (Node<int> curB = lstB; curB != null; curB = curB.GetNext())
            AddIfDoesntContain(newList, curB.GetValue());

        return newList;
    }

    private static void AddIfDoesntContain(Node<int> newList, int searched)
    {
        for (Node<int> cur = newList; cur != null; cur = cur.GetNext())
        {
            if (cur.GetValue() == searched) return;

            if (cur.GetNext() == null)
                cur.SetNext(new Node<int>(searched));
        }
    }
}