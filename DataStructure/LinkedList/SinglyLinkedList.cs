namespace DataStructure.LinkedList;

internal class ListNode
{
    public int Val { get; set; }
    public ListNode? Next { get; set; }

    public ListNode(int val)
    {
        Val = val;
        Next = null;
    }
}

internal class SinglyLinkedList
{
    int size = 0;
    ListNode head;

    public SinglyLinkedList()
    {
        size = 0;
        head = new ListNode(-10); 
    }

    public int Size => size;
    public ListNode Node => head;

    public int Get(int index)
    {
        ListNode? node = GetNodeAtIndex(index);

        return node != null ? node.Val : -1;
    }

    private ListNode? GetNodeAtIndex(int index)
    {
        ListNode? curr = head.Next;

        for (int i = 0; i < index; i++)
        {
            if (curr == null) return null;

            curr = curr.Next;
        }

        return curr;
    }

    public void AddAtHead(int val)
    {
        size++;
        ListNode newNode = new(val) { Next = head.Next };
        head.Next = newNode;
    }

    public void AddAtTail(int val)
    {
        size++;
        ListNode newNode = new(val);
        var pred = head.Next;

        if (pred == null)
        {
            pred = newNode;

            return;
        }

        while (pred.Next != null)
        {
            pred = pred.Next;
        }

        pred.Next = newNode;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index < 0) return;

        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        ListNode? prevNode = GetNodeAtIndex(index - 1);
        if (prevNode == null) return;

        size++;
        ListNode newNode = new(val) { Next = prevNode.Next };
        prevNode.Next = newNode;
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0) return;

        if (index == 0)
        {
            if (head.Next != null)
            {
                size--;
                head.Next = head.Next.Next;
            }

            return;
        }

        ListNode? prevNode = GetNodeAtIndex(index - 1);
        if (prevNode == null || prevNode.Next == null) return;
        size--;
        prevNode.Next = prevNode.Next.Next;
    }
}