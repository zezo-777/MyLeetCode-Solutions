public class Solution {
    public int[] GetConcatenation(int[] nums) {
         int[] x = new int[nums.Length * 2];
 for (int i = 0; i < nums.Length * 2; i++)
 {
     if (i < nums.Length)
     {
          x[i] = nums[i];
     }
     else
     {
         x[i] = nums[i-nums.Length];
     }

 }
 return x; 
    }
}