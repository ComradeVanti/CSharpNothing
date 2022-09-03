using Xunit;

namespace Dev.ComradeVanti;

public class NothingTests
{

    [Fact]
    public void Nothing_Is_Same_As_Nothing() =>
        Assert.Same(Nothing.atAll, Nothing.atAll);

    [Fact]
    public void Nothing_Is_Equal_To_Nothing() =>
        Assert.Equal(Nothing.atAll, Nothing.atAll);

}