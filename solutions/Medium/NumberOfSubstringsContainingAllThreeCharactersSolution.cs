namespace solutions.Medium;

public class NumberOfSubstringsContainingAllThreeCharactersSolution
{
    public int NumberOfSubstrings(string s) {
        int total = 0;
        int left = 0;
        int right = 0;
        var freq = new int[3];
        int len = s.Length;

        while(right < len)
        {
            freq[s[right] - 'a']++;

            while(freq[0] >= 1 && freq[1] >= 1 && freq[2] >= 1)
            {
                total += len - right;
                freq[s[left] - 'a']--;
                left++;
            }
            right++;
        
        }
        return total;
    }
}