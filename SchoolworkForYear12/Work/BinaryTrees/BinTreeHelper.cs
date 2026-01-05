
using Unit4.CollectionsLib;

public static class BinTreeHelper
{
    public static BinNode<T> BuildIdent<T>(BinNode<T> bt)
    {
        if (bt == null)
            return null;

        return new BinNode<T>(
            BuildIdent(bt.GetLeft()),
            bt.GetValue(),
            BuildIdent(bt.GetRight())
        );
    }

    public static BinNode<int> BuildTreeFromArrays(int[] preorder, int[] inorder)
    {
        int i = 0;
        BinNode<int> bt = new BinNode<int>(preorder[0]);
        while (preorder[0] != inorder[i])
            i++;
        if (i > 0)
        {
            int[] preorderL = new int[i];
            int[] inorderL = new int[i];
            for (int j=0; j<i; j++)
            {
                preorderL[j] = preorder[j+1];
                inorderL[j] = inorder[j];
            }
            bt.SetLeft(BuildTreeFromArrays(preorderL,inorderL));
        }
        if (i < inorder.Length-1)
        {
            int[] preorderR = new int [inorder.Length-1-i];
            int[] inorderR = new int[inorder.Length-1-i];
            for (int j=i+1; j<inorder.Length; j++)
            {
                preorderR[j-i-1] = preorder[j];
                inorderR[j-i-1] = inorder[j];
            }
            bt.SetRight(BuildTreeFromArrays(preorderR,inorderR));
        }
        return bt;
    }

    public static int CountTreeHeight<T>(BinNode<T> bt)
    {
        if (bt == null)
            return -1;

        return Math.Max(
            GoLevelDeeper(0,bt.GetLeft()),GoLevelDeeper(0,bt.GetRight())
        );

        int GoLevelDeeper(int level, BinNode<T> node)
        {
            if (node == null)
                return level;

            return Math.Max(
                GoLevelDeeper(level+1,node.GetLeft()),GoLevelDeeper(level+1,node.GetRight())
            );
        }
    }

}