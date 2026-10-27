public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;

        int[] result = new int[n];
        int[] pre = new int[n];
        int[] post = new int[n];

        for (int i = 0; i < n; i++) {
            pre[i] = (i <= 0 ? 1 : pre[i - 1]) * nums[i];
        }

        for (int i = n - 1; i >= 0; i--) {
            post[i] = (i >= n - 1 ? 1 : post[i + 1]) * nums[i];
        }

        for (int i = 0; i < n; i++) {
            result[i] = (i <= 0 ? 1 : pre[i - 1]) * (i >= n - 1 ? 1 : post[i + 1]);
        }

        return result;
    }
}
