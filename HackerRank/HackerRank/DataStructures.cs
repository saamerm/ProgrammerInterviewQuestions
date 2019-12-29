using System;
using System.IO;
using System.Linq;

namespace HackerRank
{
    public class DataStructures
    {
        public DataStructures()
        {
        }

        #region Problem2
        // This question is titled "Insert a Node at the Tail of a Linked List" and is part
        // of a tutorial track by "MyCodeSchool" and is accompanied by a video lesson too
        public void Problem2()
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
        #endregion

        #region Problem3
        // This problem is titled "2D Array - DS" : https://www.hackerrank.com/challenges/2d-array/problem
        public void Problem3()
        {
            Console.WriteLine("Input values in the 6x6 array, for each line in this format: \n1 1 1 0 0 0 ->");
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                // Sample input "1 1 1 0 0 0"
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine("The maximum sum in the hourglass is" + result);
        }

        // Function to return the greatest sum in an hour glass formed in the array
        static int hourglassSum(int[][] arr)
        {
            var greatestHourglassSum = 0;
            var i = 6; // Array number of rows
            var j = 6; // Array number of columns
            var list = new System.Collections.Generic.List<int>();
            // Traverse horizontally 4 times
            for (int a = 0; a < i - 2; a++)
            {
                // Traverse vertically 4 times
                for (int b = 0; b < j - 2; b++)
                {
                    // Adding the values in seperate lines to make it clearer to read
                    var individualHourglassSum = arr[a][b] + arr[a][b + 1] + arr[a][b + 2];
                    individualHourglassSum += arr[a + 1][b + 1];
                    individualHourglassSum += arr[a + 2][b] + arr[a + 2][b + 1] + arr[a + 2][b + 2];
                    list.Add(individualHourglassSum);
                }
            }
            greatestHourglassSum = list.Max();
            return greatestHourglassSum;
        }
        #endregion
    }
}
