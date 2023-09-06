using System;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        int[] honored = new int[k];
        for (int i = 0; i < score.Length; i++)
        {
            int index = 0;
            for (int j = 0; j < k; j++)
            {
                if (score[i] >= honored[j])
                {
                    honored[j] = score[i];
                    break;
                }
            }
            Array.Sort(honored);
            if (i < k) answer[i] = honored[k - i - 1];
            else answer[i] = honored[0];
        }
        
        return answer;
    }
}