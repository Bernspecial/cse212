public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        // If the new value equals the current node's data, skip it (no duplicates)
        if (value == Data)
        {
            return; // Stop here, don’t add the duplicate
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // Base case: If the current node's data matches the value, return true
        if (value == Data)
        {
            return true;
        }
        // If the value is smaller, search the left subtree
        else if (value < Data)
        {
            // If there's no left child, the value isn't here
            if (Left == null)
            {
                return false;
            }
            // Recursively search the left subtree
            return Left.Contains(value);
        }
        // If the value is bigger, search the right subtree
        else
        {
            // If there's no right child, the value isn't here
            if (Right == null)
            {
                return false;
            }
            // Recursively search the right subtree
            return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // Base case: If the node is null, height is 0
        // (This is handled by the BinarySearchTree.GetHeight for the root)
        // Calculate the height of left and right subtrees
        int leftHeight = Left?.GetHeight() ?? 0; // 0 if Left is null
        int rightHeight = Right?.GetHeight() ?? 0; // 0 if Right is null

        // Height is 1 (for this node) plus the maximum of left or right subtree height
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}