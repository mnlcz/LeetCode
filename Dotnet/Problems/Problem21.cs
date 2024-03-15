namespace Problems;

public sealed class Problem21
{
    // https://leetcode.com/problems/merge-two-sorted-lists/description/
    public ListNode? MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 is null && list2 is null) return null;

        var vals = new List<int>();
        var it = list1;
        FillList(vals, it);
        it = list2;
        FillList(vals, it);
        vals.Sort();
        var newHead = new ListNode(vals[0]);
        it = newHead;

        for (var i = 1; i < vals.Count; i++)
        {
            var node = new ListNode(vals[i]);
            it.next = node;
            it = it.next;
        }

        return newHead;
    }

    private void FillList(List<int> vals, ListNode? iterator)
    {
        if (iterator is not null)
        {
            while (iterator is not null)
            {
                vals.Add(iterator.val);
                iterator = iterator.next;
            }
        }
    }
}
