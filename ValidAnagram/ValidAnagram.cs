using System;
using System.Collections.Generic;

// LeetCode #242 - Valid Anagram
// Time: O(n) | Space: O(n)

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> letters = new Dictionary<char, int>();

        foreach (var a in s)
        {
            if (letters.ContainsKey(a))
            {
                letters[a]++;
            }
            else
            {
                letters.Add(a, 1);
            }
        }

        for (int b = 0; b < t.Length; b++)
        {
            if (letters.ContainsKey(t[b]) && letters[t[b]] > 0)
            {
                letters[t[b]]--;
            }
            else
            {
                return false;
            }
        }
        
        return true; 
    }
}
