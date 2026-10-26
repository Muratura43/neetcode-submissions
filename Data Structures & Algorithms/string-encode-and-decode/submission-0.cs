public class Solution {
    public string Encode(IList<string> strs) {
        if (strs.Count == 0) {
            return "";
        }

        string result = strs.Count.ToString() + '#';

        foreach (var s in strs) {
            result += s.Length.ToString() + '#';
        }

        foreach (var s in strs) {
            result += s;
        }

        return result;
    }

    public List<string> Decode(string s) {
        if (s.Length == 0) {
            return new List<string>();
        }

        List<string> result = new List<string>();
        int count = 0;
        int i = 0;

        while (s[i] != '#') {
            count = count * 10 + (s[i] - '0');
            i++;
        }

        i++;

        int[] numbers = new int[count];
        int j = 0;
        int n = 0;

        while (j < count) {
            if (s[i] == '#') {
                numbers[j] = n;
                n = 0;
                j++;
            } else {
                n = n * 10 + (s[i] - '0');
            }

            i++;
        }

        for (j = 0; j < count; j++) {
            string word = s.Substring(i, numbers[j]);
            result.Add(word);
            i += numbers[j];
        }

        return result;
    }
}
