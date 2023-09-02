using System;

public class Solution 
{
    public int solution(string t, string p) 
    {
        int answer = 0;
        for (int i = 0; i < t.Length - p.Length + 1; i ++)
        {
            string numOfPLen = "";
            for (int j = 0; j < p.Length; j++)
            {
                numOfPLen += t[i + j].ToString();
            }
            if (long.Parse(numOfPLen) <= long.Parse(p)) answer ++;    
        }
        return answer;
    }
}