public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> dic = new();

        for (int i = 0; i < s.Length; i++)
        {
            var cur = s[i];
            if (dic.ContainsKey(cur))
            {
                dic[cur]++;
            }
            else
            {
                dic.Add(cur, 1);
            }
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (!dic.ContainsKey(t[i]))
            {
                return false;
            }

            dic[t[i]]--;
        }

        foreach (var d in dic)
        {
            if (d.Value != 0)
            {
                return false;
            }
        }

        return true;
    }
}
