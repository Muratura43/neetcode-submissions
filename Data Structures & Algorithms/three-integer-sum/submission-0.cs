public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new();

        Array.Sort(nums);

        int j;
        int k;

        for (int i = 0; i < nums.Length - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            j = i + 1;
            k = nums.Length - 1;

            while (j < k) {
                int sum = nums[j] + nums[k] + nums[i];
                if (sum < 0) {
                    j++;
                } else if (sum > 0) {
                    k--;
                } else {
                    result.Add(new List<int> { nums[i], nums[j], nums[k] });
                    j++;
                    k--;
                    while (j < k && nums[j] == nums[j - 1]) {
                        j++;
                    }
                    while (j < k && nums[k] == nums[k + 1]) {
                        k--;
                    }
                }
            }
        }

        return result;
    }
}
