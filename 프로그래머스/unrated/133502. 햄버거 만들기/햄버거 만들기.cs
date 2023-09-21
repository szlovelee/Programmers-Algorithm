using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient)
    {
        int answer = 0;
        int cnt;
        List<int> list = new List<int>();
        for(int i = 0; i < ingredient.Length; i++)
        {
            list.Add(ingredient[i]);
            cnt = list.Count;
            if(cnt > 3)
            {
                if(list[cnt - 4] == 1 && list[cnt - 3] == 2 && list[cnt - 2] == 3 && list[cnt - 1] == 1)
                {
                    answer++;
                    list.RemoveRange(cnt - 4, 4);
                }
            }
        }
        return answer;
    }
}