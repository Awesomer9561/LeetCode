using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class AddTwoNumbers
    {
        int carry;
        ListNode currentL1Node, currentL2Node, addedNode;
        public ListNode Add(ListNode l1, ListNode l2)
        {
            currentL1Node = l1.next;
            currentL2Node = l2.next;
            carry = 0;
            
            while (currentL1Node != null)
            {
                currentL1Node = currentL1Node.next;
            }
            while (currentL2Node != null)
            {
                currentL2Node = currentL2Node.next;
            }

            if (addedNode != null)
            {
                addedNode.next = addedNode;
                addedNode.val = currentL1Node.val + currentL2Node.val;
            }
            else
            {

            }

            return currentL1Node;
        }
    }
}
