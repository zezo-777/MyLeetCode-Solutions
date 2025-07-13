public class Solution {
    public int[] RunningSum(int[] nums)
    {
        int x = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] += x;
            x= nums[i];
        }
        return nums;
    }
}