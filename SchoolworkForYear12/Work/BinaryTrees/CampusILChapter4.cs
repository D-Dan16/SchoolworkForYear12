

public static class CampusILChapter4
{
    public static void Start()
    {
        var tree1 = BinTreeHelper.BuildTreeFromArrays([1,2,3,2,9,5], [3,2,2,1,9,5]);
        PrintAllNumbers(tree1);
    }


    public static void PrintAllNumbers(BinNode<int> bt)
    {
        if (bt == null)
            return;

        if (!bt.HasLeft() && !bt.HasRight())
            Console.Write(bt.GetValue());

        MoveToNextStep(bt.GetLeft(), bt.GetValue());
        MoveToNextStep(bt.GetRight(), bt.GetValue());

        void MoveToNextStep(BinNode<int> node, int summationOfDigits)
        {
            if (node == null)
                return;

            summationOfDigits = summationOfDigits * 10 + node.GetValue();

            if (!node.HasLeft() && !node.HasRight())
            {
                Console.Write($"{summationOfDigits} ");
                return;
            }

            MoveToNextStep(node.GetLeft(), summationOfDigits);
            MoveToNextStep(node.GetRight(),summationOfDigits);
        }
    }
}