public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> h = new HashSet<int>();

        for (int i=0; i < nums.Length; i++)
        {
            if (h.Contains(nums[i]))
            {
                return true;
            }

            h.Add(nums[i]);
        }

        return false;
    }
}