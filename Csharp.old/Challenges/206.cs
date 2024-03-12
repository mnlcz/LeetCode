using Csharp.PredefinedClasses;

namespace Csharp.Challenges;

public static partial class Solution
{
    public static ListNode? ReverseList(ListNode? head)
    {
        if (head is null) return null;
        var list = new List<int>();
        var it = head;
        while (it is not null)
        {
            list.Add(it.val);
            it = it.next;
        }

        var newHead = new ListNode(list[^1]);
        it = newHead;
        for (var i = list.Count - 2; i >= 0; i--)
        {
            var node = new ListNode(list[i]);
            it.next = node;
            it = it.next;
        }

        return newHead;
    }

    public static ListNode? ReverseListOptimized(ListNode? head)
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
