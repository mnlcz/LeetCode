using Problems;

namespace Tests;

public class UnitTest21
{
    private readonly Problem21 _ins = new();

    [Fact]
    public void Examples()
    {
        var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));
        var res = _ins.MergeTwoLists(l1, l2);

        Assert.Equal(res!.val, expected.val);
        Assert.Equal(res!.next!.val, expected!.next!.val);
        Assert.Equal(res!.next!.next!.val, expected!.next!.next!.val);
        Assert.Equal(res!.next!.next!.next!.val, expected!.next!.next!.next!.val);
        Assert.Equal(res!.next!.next!.next!.next!.val, expected!.next!.next!.next!.next!.val);
        Assert.Equal(res!.next!.next!.next!.next!.next!.val, expected!.next!.next!.next!.next!.next!.val);
    }
}
