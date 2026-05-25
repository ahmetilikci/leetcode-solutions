using System;
using System.Collections.Generic;

// LeetCode #383 - Ransom Note
// Time: O(m) space optimization with Early Termination
// Space: O(m) where m is length of ransomNote

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }

        Dictionary<char, int> noteLetters = new Dictionary<char, int>();
        foreach (var a in ransomNote)
        {
            if (noteLetters.ContainsKey(a))
            {
                noteLetters[a]++;
            }
            else
            {
                noteLetters.Add(a, 1);
            }
        }

        int countOfLetters = ransomNote.Length;
        for (int b = 0; b < magazine.Length; b++)
        {
            if (noteLetters.ContainsKey(magazine[b]) && noteLetters[magazine[b]] > 0)
            {
                noteLetters[magazine[b]]--;
                countOfLetters--;
            }

            if(countOfLetters == 0)
            {
                return true;
            }
        }

        return false;
    }
}
