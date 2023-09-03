using System;

public class Solution 
{
    public string solution(string s, int n) 
    {
        string answer = "";
        foreach (char c in s)
        {
            char newChar;
            
            if (c == ' ') newChar = ' ';
            else if (c > 90) newChar = (c + n < 123)? (char)(c + n) : (char)(c + n - 26);
            else newChar = (c + n < 91)? (char)(c + n) : (char)(c + n - 26);
            
            answer += newChar;
        }
        return answer;
    }
}