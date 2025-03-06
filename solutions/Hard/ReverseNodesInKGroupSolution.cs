namespace LeetCodeSolutions.Solutions.ReverseNodesInKGroup;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class ReverseNodesInKGroupSolution
{
    public ListNode ReverseKGroup(ListNode head, int k) {

        // Step 1: figure out the length of the list
        ListNode current = head;
        int length = 0;

        while(current != null)
        {
            length++;
            current = current.next;
        }

        // Step 2: establish variables to track movement through the linked list
        ListNode groupStart = head; // track the beginning of each group
        ListNode newHead = head; // establish the new head of the list to return
        ListNode prevGroupEnd = null; // track the end of the previous group
        int iterations = length / k; // determine how many times will iterate through the list

        // Step 3: begin iterating
        for(int i = 0; i < iterations; i++)
        {
            current = groupStart;
            ListNode groupTail = groupStart;
            ListNode previous = null;

            for(int j = 0; j < k; j++)
            {
                ListNode temp = current.next; //store the next variable
                current.next = previous; // the next node is the one behind to reverse
                previous = current; // the one behind is the one we are at
                current = temp; // step to the new current to be reversed
            }

            if(i == 0)
            {
                newHead = previous;
            }
            else
            {
                prevGroupEnd.next = previous; // reconnect the list
            }

            groupStart = current; // set the beginning of the next group from the current node

            prevGroupEnd = groupTail; // originally set = groupStart but now it is the last since its reversed
        }
        if(prevGroupEnd != null)
        {
            prevGroupEnd.next = groupStart; // connect the list if there are leftover nodes
        }

        return newHead;
    }
}

public class Program {
    public static void Main(string[] args) {
        // Run multiple test cases.
        RunTest(new int[] { }, 2, new int[] { });
        RunTest(new int[] { 1 }, 2, new int[] { 1 });
        RunTest(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 2, 1, 4, 3, 5 });
        RunTest(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 3, 2, 1, 4, 5 });
        RunTest(new int[] { 1, 2, 3, 4, 5 }, 1, new int[] { 1, 2, 3, 4, 5 });
        RunTest(new int[] { 1, 2, 3, 4, 5 }, 6, new int[] { 1, 2, 3, 4, 5 });
        RunTest(new int[] { 1, 2, 3, 4, 5, 6 }, 3, new int[] { 3, 2, 1, 6, 5, 4 });
        RunTest(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 3, 2, 1, 6, 5, 4, 7 });
    }

    static void RunTest(int[] input, int k, int[] expected) {
        ListNode head = CreateList(input);
        ReverseNodesInKGroupSolution solution = new ReverseNodesInKGroupSolution();
        ListNode result = solution.ReverseKGroup(head, k);
        string resultStr = ListToString(result);
        string expectedStr = ListToString(CreateList(expected));

        if (resultStr == expectedStr) {
            Console.WriteLine($"Test passed for input [{string.Join(",", input)}] with k={k}: {resultStr}");
        } else {
            Console.WriteLine($"Test FAILED for input [{string.Join(",", input)}] with k={k}: expected {expectedStr}, got {resultStr}");
        }
    }

    static ListNode CreateList(int[] arr) {
        if (arr == null || arr.Length == 0) return null;
        ListNode head = new ListNode(arr[0]);
        ListNode current = head;
        for (int i = 1; i < arr.Length; i++) {
            current.next = new ListNode(arr[i]);
            current = current.next;
        }
        return head;
    }

    static string ListToString(ListNode head) {
        List<string> values = new List<string>();
        while (head != null) {
            values.Add(head.val.ToString());
            head = head.next;
        }
        return string.Join("->", values);
    }
}