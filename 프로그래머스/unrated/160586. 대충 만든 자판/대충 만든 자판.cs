using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string[] keymap, string[] targets) 
    {
        int[] answer = new int[targets.Length];
        
        for (int i = 0; i < targets.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < targets[i].Length; j++)
            {
                List<int> values = new List<int>();
                for (int k = 0; k < keymap.Length; k++)
                {
                    int num = keymap[k].IndexOf(targets[i][j]);
                    if (num != -1) values.Add(num);
                }
                values.Sort();
                if (values.Count == 0)
                {
                    answer[i] = -1;
                    break;
                }
                else 
                {
                    count += values[0] + 1;
                }
            }
            
            answer[i] = ((answer[i]) == -1)? -1 : count;
        }
        return answer;
    }
}