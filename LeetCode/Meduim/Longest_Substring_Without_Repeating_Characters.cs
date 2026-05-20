namespace LeetCode.Meduim;

public class Longest_Substring_Without_Repeating_Characters
{
    public int LengthOfLongestSubstring(string s) // pwwkew
    {
        var charMap = new Dictionary<char, int>(); //pw, wke

        int maxl = 0;
        int start_point = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char current = s[i];
            if (charMap.ContainsKey(current) && charMap[current] >= start_point)
                start_point = charMap[current] + 1; // if we meet a new char reset start to point to be the next char 

            charMap[current] = i;

            maxl = Math.Max(maxl, i - start_point + 1);
        }

        return maxl;
    }
}