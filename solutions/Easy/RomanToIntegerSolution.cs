namespace LeetCodeSolutions.Solutions.RomanToInteger;

public class RomanToIntegerSolution
{
    public int RomanToInt(string s) {
        var map = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        int sum = 0;
        int prev = -1;

        for(int i = s.Length - 1; i >= 0; i--)
        {
            int current = map[s[i]];

            if(current < prev)
            {
                sum -= prev;
                sum += (prev - current);
            }
            else
            {
                sum += map[s[i]];
            }

            prev = current;
        }

        return sum;
    }
}