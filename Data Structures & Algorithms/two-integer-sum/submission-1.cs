public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            int s = target - nums[i];

            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[j] == s) {
                    return [i, j];
                }
            }
        }

        return [];
    }
}
