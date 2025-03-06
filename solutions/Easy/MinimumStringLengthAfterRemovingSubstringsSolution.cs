namespace solutions.Easy;

public class MinimumStringLengthAfterRemovingSubstringsSolution
{
    public int MinLength(string s) {
        if(!s.Contains("AB") && !s.Contains("CD")) return s.Length;

        bool changed = true;
        int currentLength = s.Length;

        while(changed)
        {
            s = s.Replace("AB", "");
            s = s.Replace("CD", "");

            if(s.Length < currentLength)
            {
                currentLength = s.Length;
            }
            else
            {
                changed = false;
            }
        }
        return s.Length;
    }
}