namespace LeetCodeSolutions.Solutions.SwapNodesInPairs;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}
public class SwapNodesInPairsSolution
{
    public ListNode SwapPairs(ListNode head) {
        if(head == null) return null;
        if(head.next == null) return head;

        ListNode temp = head.next;
        head.next = temp.next;
        temp.next = head;

        ListNode dummy = temp;

        if((dummy.next).next == null) return dummy;

        //iterate through the rest of the nodes
        ListNode current = head.next;
        ListNode back = head;

        // while(current.next != null && current != null)
        // {
        //     temp = current.next;
        //     current.next = temp.next;
        //     temp.next = current;
        //     back.next = temp;

        //     //move forward
        //     current = temp;
        //     back = current;
            
            
        // }
        while (current != null && current.next != null) {
            temp = current.next;
            current.next = temp.next;
            temp.next = current;
            back.next = temp;

            //update back to the tail of the swapped pair, and current to the next unswapped node
            back = current;
            current = current.next;
        }


        return dummy;
    }
}