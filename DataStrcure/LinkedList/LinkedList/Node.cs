public class Node
{
    public int Element { get; }
    public Node? Next { get; set; }

    public Node(int element, Node? next = null)
    {
        this.Element = element;
        this.Next = next;
    }
}