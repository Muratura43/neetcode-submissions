public class Solution {
    public int MaxArea(int[] heights) {
        int result = 0;
        int i = 0;
        int j = heights.Length - 1;

        while (i < j) {
            int width = j - i;
            int height = Math.Min(heights[i], heights[j]);
            int volume = width * height;

            if (volume > result) {
                result = volume;
            }

            if (heights[i] < heights[j]) {
                i++;
            } else {
                j--;
            }
        }

        return result;
    }
}
