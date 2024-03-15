using Problems;

namespace Tests;

public class UnitTest206
{
    private readonly Problem206 _ins = new();

    [Fact]
    public void Example1()
    {
        var head = new ListNode(1, new ListNode(2));
        var expected = new ListNode(2, new ListNode(1));
        var actual = _ins.ReverseList(head);

        Assert.Equal(actual!.val, expected.val);
        Assert.Equal(actual!.next!.val, expected!.next!.val);
    }
}
