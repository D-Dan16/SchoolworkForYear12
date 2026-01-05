using Unit4.CollectionsLib;

namespace SchoolworkForYear12.Work.BinaryTrees;

public class Homework_5_1_25
{
    public static void Start()
    {
        BinNode<int> tree1 = BinTreeHelper.BuildTreeFromArrays([1, 3, 5, 2, -8, 9, 6, 7, 8, 9], [3,1,-8,2,9,5,7,6,8,9]);
        PrintTreeLevelOrder(tree1,-1);

    }

    public static void PrintTreeLevelOrder<T>(BinNode<T> tree, int wantedLevel)
    {
        PrintTreeLevelOrder(tree,wantedLevel,0);
    }

    private static void PrintTreeLevelOrder<T>(BinNode<T> curNode,int wantedLevel, int curLevel)
    {
        if (curNode == null) return;

        if (curLevel == wantedLevel)
        {
            Console.WriteLine(curNode.GetValue());
            return;
        }

        PrintTreeLevelOrder(curNode.GetLeft(), wantedLevel, curLevel+1);
        PrintTreeLevelOrder(curNode.GetRight(), wantedLevel, curLevel+1);
    }
}