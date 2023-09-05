using System;
using System.Linq;


public class Solution 
{
    public string solution(int[] food) 
    {
        string answer = "";
        
        for (int i = 1; i < food.Length; i++)
        {
            int count = 0;
            if (food[i] % 2 == 1) count = (food[i] - 1) / 2;
            else count = food[i] / 2;
            answer += new string(' ', count).Replace(" ", i.ToString());
        }
        string copy = new string(answer.Reverse().ToArray());
        answer = answer + "0" + copy;
        
        return answer;
    }
}