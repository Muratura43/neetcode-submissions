public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> h = new HashSet<int>();
        int result = 0;

        foreach (var i in nums) {
            if (!h.Contains(i)) {
                h.Add(i);
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            if (!h.Contains(nums[i] - 1)) {
                int j = 1;

                while (h.Contains(nums[i] + j)) {
                    j++;
                }

                if (j > result) {
                    result = j;
                }
            }
        }

        return result;
    }
}
