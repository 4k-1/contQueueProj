using System;
using System.Collections.Generic;

public class LinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

```
private Node head;
    private int currentNumber;
    private int count;

    public LinkedList(int startNumber)
    {
        currentNumber = startNumber;
        head = null;
    }

    public int Enqueue()
    {
        Node newNode = new Node(currentNumber++);
        if (head == null)
            head = newNode;
        else
        {
            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newNode;
        }
        count++;
        return newNode.Data;
    }

    public int? Dequeue()
    {
        if (head == null)
            return null;

        int data = head.Data;
        head = head.Next;
        count--;
        return data;
    }

    public int? Peek()
    {
        return head?.Data;
    }

    public int PeekLast()
    {
        if (head == null) return -1;
        Node temp = head;
        while (temp.Next != null)
            temp = temp.Next;
        return temp.Data;
    }

    public int Count
    {
        get { return count; }
    }

    public bool IsEmpty()
    {
        return head == null;
    }


}

