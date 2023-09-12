using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int filled = 0;
        for (int i = 0; i < section.Length; i++)
        {
            if (section[i] > filled)
            {
                filled = section[i] + m - 1;
                answer ++;
            }
        }
        return answer;
    }
}