namespace LeetCodeSolutions.Solutions.LengthOfLastWord;

public class LengthOfLastWordSolution
{
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        string[] list = s.Split(" ");
        return list[list.Length - 1].Length;
    }
}