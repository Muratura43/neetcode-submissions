public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] result = new int[2];

        int i = 0;
        int j = numbers.Length - 1;

        while (i < j) {
            if (numbers[i] + numbers[j] > target) {
                j--;
            } else if (numbers[i] + numbers[j] < target) {
                i++;
            } else {
                result[0] = i + 1;
                result[1] = j + 1;
                return result;
            }
        }

        return result;
    }
}
