using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            int sameLetterIndex = -1;
            for (int j = 0; j < i; j++)
            {
                if (s[j] == s[i]) sameLetterIndex = j;
            }
            if (sameLetterIndex != -1) answer[i] = i - sameLetterIndex;
            else answer[i] = sameLetterIndex;
        }
        return answer;
    }
}