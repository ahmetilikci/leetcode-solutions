using System;

// LeetCode #125 - Valid Palindrome
// Time: O(n) | Space: O(1)

public class Solution {
    public bool IsPalindrome(string s) {
        if(string.IsNullOrEmpty(s))
            return true;

        int length = s.Length;
        int b = length - 1;
        
        for(int a = 0; a < length; a++)
        {
            // Optimizasyon: Parmaklar ortada çarpıştıysa kontrol biter.
            if (a >= b) break; 

            if (char.IsLetterOrDigit(s[a]) && char.IsLetterOrDigit(s[b]))
            {
                if (char.ToUpperInvariant(s[a]) != char.ToUpperInvariant(s[b]))
                    return false;
                else 
                    b--; 
            }
            else if (!char.IsLetterOrDigit(s[a]))
            {
                continue; 
            }
            else if (!char.IsLetterOrDigit(s[b]))
            {
                b--; 
                a--; // a yerinde beklesin diye 1 geri çekiyoruz (for onu 1 ileri itecek)
                continue;
            }
        }
       
        return true;
    }
}
