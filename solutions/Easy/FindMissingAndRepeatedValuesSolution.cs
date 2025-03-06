namespace solutions.Easy;

public class FindMissingAndRepeatedValuesSolution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        var result = new int[2];

        var freq = new int[grid.Length * grid.Length + 1];

        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid.Length; j++)
            {
                freq[grid[i][j]]++;
            }

        }
        
        for(int i = 1; i < freq.Length; i++)
        {
            if(freq[i] > 1) result[0] = i;
            else if(freq[i] == 0) result[1] = i;
        }

        return result;
    }
}