namespace SchoolworkForYear12.Work.BinaryTrees;

// ReSharper disable once InconsistentNaming
public class Homework_23_4_26
{
    public static void Start()
    {
        var tree = BinTreeHelper.BuildTreeFromArrays(
            [1,3,10,5,2,-8,-8,6,7,8,9],
            [10,3,1,-8,2,-8,5,7,6,8,9]
        );

        Console.WriteLine(FindClosestCommonAncestor(tree,tree.GetRight().GetLeft(),tree.GetRight().GetRight().GetRight()));
        Console.WriteLine(FindClosestCommonAncestor(tree,tree.GetLeft(),tree.GetLeft().GetLeft()));
        Console.WriteLine(FindClosestCommonAncestor(tree,tree.GetRight().GetLeft(),tree.GetRight().GetLeft().GetRight()));
    }

    /// This doesn't work as intended. This is just too challenging of a task.
    private static BinNode<int>? FindClosestCommonAncestor(
        BinNode<int>? tree,
        BinNode<int> node1,
        BinNode<int> node2
    )
    {
        if (tree == null)
            return null;

        if (IsCommonAncestor(tree, node1, node2))
        {
            var commonAncestorL = FindClosestCommonAncestor(tree.GetLeft(), node1, node2);
            var commonAncestorR = FindClosestCommonAncestor(tree.GetRight(), node1, node2);

            // There is no closer common ancestor; this means this cur node is the closest one
            if (commonAncestorL == null && commonAncestorR == null)
                return tree;
        }

        return null;
    }

    private static bool IsCommonAncestor(
        BinNode<int>? binNode,
        BinNode<int> descendentA,
        BinNode<int> descendentB
    ) => CountMatches(binNode, descendentA, descendentB) == 2;

    private static int CountMatches(
        BinNode<int>? binNode,
        BinNode<int> descendentA,
        BinNode<int> descendentB)
    {
        if (binNode == null)
            return 0;

        int currentMatch = 0;

        if (binNode == descendentA)
            currentMatch++;

        if (binNode == descendentB)
            currentMatch++;

        int leftMatches = CountMatches(binNode.GetLeft(), descendentA, descendentB);
        int rightMatches = CountMatches(binNode.GetRight(), descendentA, descendentB);

        return currentMatch + leftMatches + rightMatches;
    }
}