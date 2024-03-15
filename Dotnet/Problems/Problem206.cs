namespace Problems;

public sealed class Problem206
{
    // https://leetcode.com/problems/reverse-linked-list/description/
    public ListNode? ReverseList(ListNode head)
    {
        ListNode? prev = null;
        var act = head;

        while (act is not null)
        {
            var temp = act.next;
            act.next = prev;
            prev = act;
            act = temp;
        }

        return prev;
    }
}

// IGNORE: defined by LeetCode
public class ListNode(int vval = 0, ListNode? nnext = null)
{
    public int val = vval;
    public ListNode? next = nnext;
}
