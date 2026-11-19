public class Solution {
    public int Trap(int[] height) {
        int result = 0;

        int l = 0;
        int r = height.Length - 1;

        int maxL = height[l];
        int maxR = height[r];

        while (l < r) {
            int value = 0;

            if (maxL <= maxR) {
                l++;
                maxL = Math.Max(maxL, height[l]);
                value = maxL - height[l];
            } else {
                r--;
                maxR = Math.Max(maxR, height[r]);
                value = maxR - height[r];
            }

            result += value < 0 ? 0 : value;
        }

        return result;
    }
}
