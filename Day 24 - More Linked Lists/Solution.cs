using System;
using System.Collections.Generic;
class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }
}
class Solution
{
    public static Node removeDuplicates(Node head)
    {
        //Write your code here
        Node newNode = head;

        if (head == null)
        {
            return head;
        }

        while (newNode.next != null)
        {
            if (newNode.data == newNode.next.data)
            {
                newNode.next = newNode.next.next;
            }
            else
            {
                newNode = newNode.next;
            }
        }

        return head;
    }

    public static Node insert(Node head, int data)
    {
        Node p = new Node(data);

        if (head == null)
            head = p;
        else if (head.next == null)
            head.next = p;
        else
        {
            Node start = head;
            while (start.next != null)
                start = start.next;
            start.next = p;

        }

        return head;
    }

    public static void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }

    static void Main(String[] args)
    {
        Node head = null;
        int T = Int32.Parse(Console.ReadLine());

        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);
        }

        head = removeDuplicates(head);
        display(head);
    }
}