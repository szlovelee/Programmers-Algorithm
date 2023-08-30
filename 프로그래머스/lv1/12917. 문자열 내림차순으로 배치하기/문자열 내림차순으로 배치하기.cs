using System;
using System.Linq;

public class Solution 
{
    public string solution(string s) 
    {
        char[] letters = s.ToCharArray();
        letters = letters.OrderBy(i => Char.IsUpper(i)).ThenByDescending(i => i).ToArray();
        
        string answer = "";        
        foreach (char c in letters)
        {
            answer += c;
        }
        return answer;
    }
}