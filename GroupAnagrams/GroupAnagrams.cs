using System;
using System.Collections.Generic;
using System.Linq;

// LeetCode #49 - Group Anagrams
// Time: O(n * k log k) where n is number of words and k is max length of a word (due to sorting)
// Space: O(n * k) for the dictionary

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
     
        Dictionary<string, IList<string>> anagramGroups = new Dictionary<string, IList<string>>();

        foreach(string k in strs)
        {
            char[] lettersArray = k.ToCharArray();
            Array.Sort(lettersArray);
            string sortedWord = new string(lettersArray);

            if(!anagramGroups.ContainsKey(sortedWord))
            {
                anagramGroups.Add(sortedWord, new List<string>());
            }
            
            anagramGroups[sortedWord].Add(k);
        } 
     
        return new List<IList<string>>(anagramGroups.Values);
    }
}
