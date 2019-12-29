using System;
using System.IO;

namespace HackerRank
{
    public class DataStructures
    {
        public DataStructures()
        {
        }

        public void Question2()
        {
            SinglyLinkedList llist = new SinglyLinkedList();
            Console.WriteLine("Enter the number of nodes in the linked list:");
            int llistCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the items:");
            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
                llist.head = llist_head;
            }
            PrintLinkedList(llist.head);
        }

        // Solution requires this function, so kept the definition the same
        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            if (head == null)
                head = new SinglyLinkedListNode(data);
            else
                head.next = insertNodeAtTail(head.next, data);
            return head;
        }

        // Default given definition
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        // Default given definition
        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;

            public SinglyLinkedList()
            {
                this.head = null;
            }

        }

        // Added this just to see what the LinkedList looks like
        // Displays 3->1->2 for the input 3,1 & 2
        private void PrintLinkedList(SinglyLinkedListNode node)
        {
            if (node != null)
                Console.Write(node.data);
            else
                return;
            if (node.next != null)
            {
                Console.Write("->");
                PrintLinkedList(node.next);
            }
        }
    }
}
