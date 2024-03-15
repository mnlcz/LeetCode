Param
(
    [Parameter(Mandatory = $true, Position = 0)]
    [String]$Number
)

$TestTemplate = @"
using Problems;

namespace Tests;

public class UnitTest$Number
{
    private readonly Problem$Number _ins = new();

    [Theory]
    [InlineData()]
    public void Examples()
    {
    }
}
"@

$ProblemTemplate = @"
namespace Problems;

public sealed class Problem$Number
{
    //
}
"@

Add-Content -Path "./Tests/UnitTest$Number.cs" -Value $TestTemplate -Encoding utf8
Add-Content -Path "./Problems/Problem$Number.cs" -Value $ProblemTemplate -Encoding utf8
