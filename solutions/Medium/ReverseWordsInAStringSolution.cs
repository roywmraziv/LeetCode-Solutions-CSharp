namespace solutions.Medium;

public class ReverseWordsInAStringSolution
{
    public string ReverseWords(string s) {
        s = s.Trim();

        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        return string.Join(" ", words);
    }
}