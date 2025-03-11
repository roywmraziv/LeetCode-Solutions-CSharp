namespace solutions.Medium;

public class AlternatingGroupsIISolution
{
    public int NumberOfAlternatingGroups(int[] colors, int k) {
        int count = 0;
        int result = 0;
        int prev = colors[colors.Length - 1];
        
        int current;

        for(int i = 0; i < colors.Length + k - 1; i++)
        {
            current = colors[i % colors.Length];

            if(current == prev)
            {
                count = 1;
                prev = current;
                continue;
            }
            count++;
            prev = current;
            if(count >= k) result++;            
        }
        return result;
    }
}