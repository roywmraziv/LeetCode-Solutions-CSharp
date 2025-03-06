namespace LeetCodeSolutions.Solutions.MergeSortedArray;
public class MergeSortedArraySolution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(n == 0) return;
        
        int x = nums1.Length - 1;

        int pos1 = m - 1;
        int pos2 = n - 1;

        while(x >= 0)
        {
            int num1 = pos1 >= 0 ? nums1[pos1]:Int32.MinValue;
            int num2 = pos2 >= 0 ? nums2[pos2]:Int32.MinValue;
    
            if(num1 > num2)
            {
                nums1[x] = num1;
                pos1--;
            }
            else
            {
                nums1[x] = num2;
                pos2--;
            }

            x--;
        }
    }
}