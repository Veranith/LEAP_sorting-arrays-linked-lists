using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining.ReverseLinkedList
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;

            var node = head;
            while (node.next != null)
            {
                var temp = node.next;
                node.next = node.next.next;
                temp.next = head;
                head = temp;
            }
            return head;
        }
    }
}
