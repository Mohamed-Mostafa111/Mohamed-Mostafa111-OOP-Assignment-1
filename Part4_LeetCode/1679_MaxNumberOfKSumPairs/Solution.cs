public class Solution {
    public int MaxOperations(int[] nums, int k) {
       Array.Sort(nums);
        int Left = 0;
        int Right = nums.Length - 1;
        int OperationsCounter = 0;

        while (Left < Right)
        {
            int sum = nums[Left] + nums[Right];

            if (sum == k)
            {
                OperationsCounter++;
                Left++;
                Right--;
            }
            else if (sum < k)
            {
                Left++;
            }
            else
            {
                Right--;
            }
        }

        return OperationsCounter;  
        
    }
}