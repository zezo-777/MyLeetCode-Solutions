public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                int index = Array.FindIndex(nums, j => j == complement );

                if (index != -1 && index != i)
                {
                    return new int[] { index ,i };
                }

            }
        return new int[] { -1, -1 };
 
    }
}