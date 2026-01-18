namespace SchoolworkForYear12.Work.BinaryTrees;

public class Classwork_18_1_26
{
    public static void Start()
    {
        BinNode<int> ex1 =
            new BinNode<int>(
                new BinNode<int>(
                    new BinNode<int>(7),
                    3,
                    new BinNode<int>(1)
                ),
                5,
                new BinNode<int>(
                    new BinNode<int>(8),
                    2,
                    new BinNode<int>(
                        null,
                        6,
                        new BinNode<int>(4)
                    )
                )
            );


        BinNode<int> ex1TrueB =
            new BinNode<int>(
                new BinNode<int>(4),
                2,
                new BinNode<int>(
                    new BinNode<int>(1),
                    5,
                    new BinNode<int>(3)
                )
            );
        
        BinNode<int> ex1FalseB =
            new BinNode<int>(
                new BinNode<int>(4),
                2,
                new BinNode<int>(
                    new BinNode<int>(1),
                    100,
                    new BinNode<int>(3)
                )
            );
        
        
        BinNode<int> ex2True =
            new BinNode<int>(
                new BinNode<int>(
                    new BinNode<int>(7),
                    3,
                    new BinNode<int>(1)
                ),
                5,
                new BinNode<int>(
                    new BinNode<int>(8),
                    2,
                    new BinNode<int>(
                        null,
                        6,
                        new BinNode<int>(4)
                    )
                )
            );
        
        BinNode<int> ex2False =
            new BinNode<int>(
                new BinNode<int>(
                    new BinNode<int>(7),
                    3,
                    new BinNode<int>(1)
                ),
                5,
                new BinNode<int>(
                    new BinNode<int>(8),
                    1,
                    new BinNode<int>(
                        null,
                        6,
                        new BinNode<int>(4)
                    )
                )
            );


        Console.WriteLine(IsContained(ex1, ex1TrueB));
        Console.WriteLine(IsContained(ex1, ex1FalseB));

        Console.WriteLine(IsCounterTree(ex2True,8));
        Console.WriteLine(IsCounterTree(ex2False,8));
        
        
    }

    public static bool IsContained(BinNode<int> t1, BinNode<int> t2)
    {
        if (t1 == null)
        {
            return false;
        }

        if (t2 == null)
        {
            return true;
        }

        return HasElement(t1, t2.GetValue()) 
               && IsContained(t1, t2.GetLeft()) 
               && IsContained(t1, t2.GetRight());
    }

    public static bool IsCounterTree(BinNode<int> tr, int num)
    {
        return IsCounterTree(tr, num, 1);
    }
    
    public static bool IsCounterTree(BinNode<int> tr, int num, int searched)
    {
        if (searched > num)
            return true;
        
        if (!HasElement(tr,searched))
            return false;
        
        return IsCounterTree(tr, num, searched+1);
    }

    private static bool HasElement(BinNode<int> curNode, int element)
    {
        if (curNode == null)
        {
            return false;
        }

        if (curNode.GetValue() == element)
        {
            return true;
        }

        return HasElement(curNode.GetLeft(), element) || HasElement(curNode.GetRight(), element);
    }
}