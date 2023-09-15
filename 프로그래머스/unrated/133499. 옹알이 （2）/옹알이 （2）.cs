using System;

public class Solution 
{
    public int solution(string[] babbling) 
    {
        string[] word = new string[] {"aya", "ye", "woo", "ma"};
        int answer = 0;
        foreach (string bab in babbling)
        {
            string temp = bab;
            foreach(string w in word)
            {
                while (temp.Contains(w + w))
                {
                    if (temp.Contains(w + w)) temp = temp.Replace(w + w, "0");                    
                }
                
                while (temp.Contains(w))
                {
                     if (temp.Contains(w)) temp = temp.Replace(w, "1");                   
                }
            }
            temp = temp.Replace("1", "");
            if (temp.Length == 0) answer ++;
        }
        return answer;
    }
}