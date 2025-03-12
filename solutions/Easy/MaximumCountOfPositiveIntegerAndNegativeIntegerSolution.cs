namespace solutions.Easy;

public class MaximumCountOfPositiveIntegerAndNegativeIntegerSolution
{
    public int MaximumCount(int[] nums) {
        int pos = nums.Length - GetLowerBound(nums, 1);
        int neg = GetLowerBound(nums, 0);

        return pos > neg? pos : neg;
    }

    public static int GetLowerBound(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length;

        while(low < high)
        {
            int mid = (low + high) / 2;

            if(nums[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }
        return low;
    }
}