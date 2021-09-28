using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode head { get; set; }

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
        }

        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            var node = head;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
                if (node == null)
                {
                    return -1;
                }
            }
            if (node == null)
            {
                return -1;
            }
                return node.val;
        }

        /** Add a node of val val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            var node = new ListNode(val, head);
            head = node;
        }

        /** Append a node of val val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if(head != null)
            {
                var node = head;
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = new ListNode(val);
            }
            else
            {
                head = new ListNode(val);
            }
        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            var node = head;
            if (node == null && index == 0)
            {
                head = new ListNode(val, null);
            }
            else
            {
                if (index == 0)
                {
                    head = new ListNode(val, node);
                }
                else
                {
                    while (index > 1)
                    {
                        node = node.next;
                        index--;
                    }
                
                    node.next = new ListNode(val, node.next);
                }
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            var node = head;

            if (node.next != null)
            {
                if (index == 0)
                {
                    head = node.next;
                }
                while(index > 1)
                {
                    node = node.next;
                    if (node == null) return;
                    index--;
                }
                if (node.next != null)
                {
                    node.next = node.next.next;
                }
            }
            else if (index == 0)
            {
                head = null;
            }
        }
    }
}
