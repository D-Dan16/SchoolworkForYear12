namespace SchoolworkForYear12.Work.Queue.Classwork_12_7_25;

public static class Program
{
    public static void Start()
    {
        var fastQueue = new Queue<int>().AddCollectionToQueue([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        var slowQueue = new Queue<int>().AddCollectionToQueue([101, 102, 103, 104, 105, 106]);

        DoubleQueue qq = new DoubleQueue(slowQueue, fastQueue);

        StartService(qq);
    }

    private static void StartService(DoubleQueue qq)
    {
        Console.WriteLine("What would you like to do? type: 'I' to insert customer, 'S' to serve a customer, and 'E' to exit");
        char action;
        while ((action = Console.ReadLine()[0]) != 'E')
        {
            if (action == 'I')
            {
                Console.WriteLine("Insert new customer, and its type (0 = fast queue, 1 = slow queue");
                qq.AddCustomerToQueue(
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine())
                );
            }
            else if (action == 'S')
            {
                Console.WriteLine($"Customer that is being served: {qq.TakeCustomer()}");
            }

            Console.WriteLine("What would you like to do? type: 'I' to insert customer, 'S' to serve a customer, and 'E' to exit");
        }
    }
}

public class DoubleQueue
{
    private Queue<int> slowQueue;
    private Queue<int> fastQueue;

    public DoubleQueue(Queue<int> slowQueue, Queue<int> fastQueue)
    {
        this.slowQueue = slowQueue;
        this.fastQueue = fastQueue;
    }

    public Queue<int> SlowQueue
    {
        get => slowQueue;
        set => slowQueue = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Queue<int> FastQueue
    {
        get => fastQueue;
        set => fastQueue = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Queue<int> GetQueue(int type)
    {
        return type == 1 ? slowQueue : fastQueue;
    }

    public void AddCustomerToQueue(int bankAccountNum, int typeOfQueue)
    {
        if (typeOfQueue == 1)
            slowQueue.Insert(bankAccountNum);
        else
            fastQueue.Insert(bankAccountNum);
    }

    private long customerNum = 0;

    public int TakeCustomer()
    {
        customerNum++;

        if (fastQueue.IsEmpty())
            return slowQueue.Remove();
        if (slowQueue.IsEmpty())
            return fastQueue.Remove();

        return customerNum % 5 == 0 ? fastQueue.Remove() : slowQueue.Remove();
    }
}