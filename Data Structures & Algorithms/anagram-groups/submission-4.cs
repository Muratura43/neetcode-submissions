public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            int[] c = new int[26];

            for (int j = 0; j < strs[i].Length; j++) {
                c[strs[i][j] - 'a']++;
            } 

            string key = string.Join(",", c);

            if (dic.ContainsKey(key)) {
                dic[key].Add(strs[i]);
            } else {
                dic.Add(key, new List<string> { strs[i] });
            }
        }

        List<List<string>> result = new List<List<string>>();

        foreach (var d in dic) {
            result.Add(d.Value);
        }

        return result;
    }
}
