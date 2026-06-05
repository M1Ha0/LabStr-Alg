using LabTree;

TreeNode P1 = new TreeNode(1);

TreeNode n2 = new TreeNode(2);
TreeNode n3 = new TreeNode(3);
TreeNode n4 = new TreeNode(4);

P1.Children.Add(n2);
P1.Children.Add(n3);
P1.Children.Add(n4);

TreeNode n5 = new TreeNode(5);
TreeNode n6 = new TreeNode(6);
TreeNode n7 = new TreeNode(7);

n2.Children.Add(n5);
n2.Children.Add(n6);
n4.Children.Add(n7);

TreeNode n8 = new TreeNode(8);
TreeNode n9 = new TreeNode(9);

n5.Children.Add(n8);
n5.Children.Add(n9);

Console.WriteLine("Количество вершин на каждом уровне:");

PrintVerticesByLevels(P1);

static void PrintVerticesByLevels(TreeNode root)
{
    Queue<TreeNode> queue = new Queue<TreeNode>();

    queue.Enqueue(root);

    int level = 0;

    while (queue.Count > 0)
    {
        int countOnLevel = queue.Count;

        Console.WriteLine(
            $"Уровень {level}: {countOnLevel} вершин");

        for (int i = 0; i < countOnLevel; i++)
        {
            TreeNode current = queue.Dequeue();

            foreach (TreeNode child in current.Children)
            {
                queue.Enqueue(child);
            }
        }

        level++;
    }
}