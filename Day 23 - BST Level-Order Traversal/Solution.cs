using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}

class Solution
{
    static void levelOrder(Node root)
    {
        //Write your code here
        Queue<Node> queue = new Queue<Node>();

        if (root != null)
        {
            // Enqueue current root
            queue.Enqueue(root);

            // While there are nodes to process
            while (queue.Count != 0)
            {
                // Dequeue next node
                Node currentNode = queue.Dequeue();

                Console.Write(currentNode.data + " ");

                // Enqueue child elements from next level in order
                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
        }
    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }

    static void Main(String[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        levelOrder(root);

    }
}