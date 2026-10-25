public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int>[] freq = new List<int>[nums.Length + 1];
        for (int f = 0; f < freq.Length; f++) {
            freq[f] = new List<int>();
        }

        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (dic.ContainsKey(nums[i])) {
                dic[nums[i]]++;
            } else {
                dic.Add(nums[i], 1);
            }
        }

        foreach (var d in dic) {
            freq[d.Value].Add(d.Key);
        }

        int[] result = new int[k];

        for (int i = freq.Length - 1; i > 0; i--) {
            if (freq[i].Count <= 0)
            {
                continue;
            }

            int f = 0;
            while (k > 0 && f < freq[i].Count)
            {
                result[k-1] = freq[i][f];
                f++;
                k--;
            }
        }

        return result;
    }
}
