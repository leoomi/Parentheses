namespace Parentheses.Test;

public class ParenthesesCheckerTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("[")]
    [InlineData("]")]
    [InlineData("(")]
    [InlineData(")")]
    [InlineData("{")]
    [InlineData("}")]
    [InlineData("[}")]
    [InlineData("[{]}()")]
    [InlineData("((())")]
    [InlineData("([{})")]
    [InlineData("({})[")]
    [InlineData("[[[[[[[[[[[[[[[")]
    [InlineData("]]]]]]]]]]]]]]]")]
    public void ParenthesesChecker_IsValid_ReturnFalse(string? s)
    {
        var result = ParenthesesChecker.IsValid(s);
        Assert.False(result);
    }

    [Theory]
    [InlineData("")]
    [InlineData("()")]
    [InlineData("{}")]
    [InlineData("[]")]
    [InlineData("([{}])")]
    [InlineData("(){}[]")]
    [InlineData("{[((){}[])]}")]
    [InlineData("{[((){}()[{}])()][]{}}")]
    [InlineData("((){{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}[])")]
    public void ParenthesesChecker_IsValid_ReturnTrue(string? s)
    {
        var result = ParenthesesChecker.IsValid(s);
        Assert.True(result);
    }
}