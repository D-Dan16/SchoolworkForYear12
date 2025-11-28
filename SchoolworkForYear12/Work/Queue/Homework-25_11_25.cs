// ReSharper disable MemberCanBePrivate.Global
namespace SchoolworkForYear12.Work.Queue;

public class Homework_25_11_25
{
    public static void Start()
    {
        var queue = new Queue<int>();
        CopyListToQueue(queue, [1, 2, 3, 4, 5, 6]);

        Console.WriteLine(queue);

        Console.WriteLine(sizeQueue(queue));

        Console.WriteLine(maxQueue(queue));

        Console.WriteLine(CopyQueue(queue));

        insertSorted(3,queue);

        Console.WriteLine(IsSorted(queue));

        Console.WriteLine(CountElementInQueue(queue, 3));

        var queueB = new Queue<int>();
        CopyListToQueue(queueB,[3,4,6,8,10,14]);
        Console.WriteLine(MergeQueue(queue,queueB));


        Console.WriteLine(DeleteK(queue,3));

        Console.WriteLine(LastInQueue(queue));

        Console.WriteLine(DeleteLastInQueue(queue));

        Console.WriteLine(ReverseQueue(queue));

        var palQ = new Queue<char>();
        CopyListToQueue(palQ,['1','a','b','b','a','1']);

        Console.WriteLine(IsQueuePalindrom(palQ));

        var queueC = new Queue<int>();
        CopyListToQueue(queueC,[2,4,4,4,5,5,6,7,8,8,8,9]);
        Console.WriteLine(RemoveDuplicatsInQueue(queueC));

        Console.WriteLine(GetCommonQueue(queue,queueB));
    }

    /**
     * ex14
     */
    private static Queue<int> GetCommonQueue(Queue<int> queueA, Queue<int> queueB)
    {
        var commonQueue = new Queue<int>();
        var cQueueA = CopyQueue(queueA);
        var cQueueB = CopyQueue(queueB);

        while (!cQueueA.IsEmpty())
        {
            var element = cQueueA.Remove();

            if (CountElementInQueue(cQueueB,element) >= 1)
            {
                Delete1ElementFromQueue(cQueueB, element);
                commonQueue.Insert(element);
            }
        }

        return commonQueue;
    }

    private static void Delete1ElementFromQueue(Queue<int> queue, int elementToDelete)
    {
        var holderQ = new Queue<int>();

        bool hasDeletedAlready = false;
        while (!queue.IsEmpty())
        {
            var val = queue.Remove();

            if (hasDeletedAlready || val != elementToDelete)
                holderQ.Insert(val);
            else
                hasDeletedAlready = true;
        }

        while (!holderQ.IsEmpty())
            queue.Insert(holderQ.Remove());

    }

    /**
     * ex13
     */
    private static Queue<int> RemoveDuplicatsInQueue(Queue<int> queue)
    {
        var holderQ = new Queue<int>();

        for (; !queue.IsEmpty(); queue.Remove())
        {
            var element = queue.Head();

            if (CountElementInQueue(queue,element) == 1)
            {
                holderQ.Insert(element);
            }
        }

        while (!holderQ.IsEmpty())
        {
            queue.Insert(holderQ.Remove());
        }

        return queue;
    }

    /**
     * ex12
     */
    private static bool IsQueuePalindrom(Queue<char> palQ)
    {
        var cQueue = CopyQueue(palQ);

        while (!cQueue.IsEmpty())
        {
            if (cQueue.Remove() != DeleteLastInQueue(cQueue))
            {
                return false;
            }
        }

        return true;
    }

    /**
     * ex11
     */
    private static Queue<int> ReverseQueue(Queue<int> queue)
    {
        var cQueue = CopyQueue(queue);

        var reversedQueue = new Queue<int>();

        while (!cQueue.IsEmpty())
            reversedQueue.Insert(DeleteLastInQueue(cQueue));

        return reversedQueue;
    }

    /**
     * ex10
     */
    private static T DeleteLastInQueue<T>(Queue<T> queue)
    {
        var holderQ = new Queue<T>();

        var size = sizeQueue(queue);
        for (int i = 0; i < size - 1; i++)
        {
            holderQ.Insert(queue.Remove());
        }

        var valueToReturn = queue.Remove();

        while (!holderQ.IsEmpty())
        {
            queue.Insert(holderQ.Remove());
        }

        return valueToReturn;
    }

    /**
     * ex9
     */
    private static int LastInQueue(Queue<int> queue)
    {
        var cQueue = CopyQueue(queue);

        for (int i = 0; i < sizeQueue(queue) - 1; i++)
        {
            cQueue.Remove();
        }

        return cQueue.Head();
    }

    /**
     * ex8
     */
    private static Queue<int> DeleteK(Queue<int> queue, int indexToRemove)
    {
        if (indexToRemove < 0 | indexToRemove >= sizeQueue(queue))
            return null!;


        var tempQ = new Queue<int>();

        var curIndex = 0;
        while (!queue.IsEmpty())
        {
            var element = queue.Remove();

            if (curIndex != indexToRemove)
                tempQ.Insert(element);

            curIndex++;
        }

        while (!tempQ.IsEmpty())
        {
            queue.Insert(tempQ.Remove());
        }

        return queue;
    }

    /**
     * ex7
     */
    private static Queue<int> MergeQueue(Queue<int> queueA, Queue<int> queueB)
    {
        var cQueueA = CopyQueue(queueA);
        var cQueueB = CopyQueue(queueB);
        var mergedQueue = new Queue<int>();

        while (!cQueueA.IsEmpty() && !cQueueB.IsEmpty())
        {
            // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
            if (cQueueB.Head() > cQueueA.Head())
                mergedQueue.Insert(cQueueA.Remove());
            else
                mergedQueue.Insert(cQueueB.Remove());
        }

        while (!cQueueA.IsEmpty())
        {
            mergedQueue.Insert(cQueueA.Remove());
        }

        while (!cQueueB.IsEmpty())
        {
            mergedQueue.Insert(cQueueB.Remove());
        }


        return mergedQueue;

    }

    /**
     * ex6
     */
    private static int CountElementInQueue(Queue<int> queue, int chosenElement)
    {
        var cQueue = CopyQueue(queue);

        int counter = 0;

        while (!cQueue.IsEmpty())
        {
            if (cQueue.Remove() == chosenElement)
                counter++;
        }

        return counter;
    }

    /**
     * ex5
     */
    private static bool IsSorted(Queue<int> queue)
    {
        if (queue.IsEmpty())
            return true;

        var cQueue = CopyQueue(queue);

        var prevVal = cQueue.Remove();

        while (!cQueue.IsEmpty())
        {
            var comparedVal = cQueue.Remove();
            if (comparedVal < prevVal)
                return false;

            prevVal = comparedVal;
        }

        return true;
    }

    /**
     * ex4.
     */
    private static void insertSorted(int elementToPut, Queue<int> queue)
    {
        if (queue.IsEmpty())
        {
            queue.Insert(elementToPut);
            return;
        }

        var holderQ = new Queue<int>();

        bool hasPutElement = false;
        while (!queue.IsEmpty())
        {
            var comparedVal = queue.Remove();
            if (!hasPutElement && elementToPut < comparedVal)
            {
                holderQ.Insert(elementToPut);
                hasPutElement = true;
            }

            holderQ.Insert(comparedVal);
        }

        while (!holderQ.IsEmpty())
        {
            queue.Insert(holderQ.Remove());
        }
    }

    /**
     * ex2
     */
    private static int maxQueue(Queue<int> queue)
    {
        int max = Int32.MinValue;
        Queue<int> cQueue = CopyQueue(queue);
        while (!cQueue.IsEmpty())
            max = Math.Max(cQueue.Remove(), max);

        return max;
    }

    /**
     * ex3. used also for earlier ex.
     */
    public static Queue<T> CopyQueue<T>(Queue<T> queue)
    {
        var copy = new Queue<T>();
        var holderForOgList = new Queue<T>();

        while (!queue.IsEmpty())
        {
            var val = queue.Remove();
            copy.Insert(val);
            holderForOgList.Insert(val);
        }

        while (!holderForOgList.IsEmpty())
            queue.Insert(holderForOgList.Remove());

        return copy;
    }

    /**
     * ex1
     */
    private static int sizeQueue<T>(Queue<T> queue)
    {
        int count = 0;
        var cQueue = CopyQueue(queue);
        while (!cQueue.IsEmpty())
        {
            cQueue.Remove();
            count++;
        }

        return count;
    }

    // ReSharper disable once MemberCanBePrivate.Global
    public static void CopyListToQueue<T>(Queue<T> queue,T[] arr)
    {
        foreach (var element in arr)
        {
            queue.Insert(element);
        }
    }

}