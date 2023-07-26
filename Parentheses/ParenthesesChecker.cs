namespace Parentheses;

public class ParenthesesChecker
{
    public static bool IsValid(string? s)
    {
        if (s == null)
        {
            return false;
        }
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c == '[' || c == '{' || c == '(')
            {
                stack.Push(c);
                continue;
            }

            if (stack.Count == 0)
            {
                return false;
            }

            var matchingChar = stack.Pop();
            if (
                (c == ']' && matchingChar != '[') ||
                (c == ')' && matchingChar != '(') ||
                (c == '}' && matchingChar != '{')
            )
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}