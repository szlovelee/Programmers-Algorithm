using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(string s) 
    {
        int answer = 0;
        
        List<char> letters = s.ToCharArray().ToList();        
        
        bool isDone = false;
        
        while (letters.Count > 0)
        {
            int xCount = 0;
            int nonXCount = 0;
            
            char x = letters[0];
            
            for (int i = 0; i < letters.Count; i ++)
            {
                if (letters[i] == x)
                {
                    xCount ++;
                }
                else 
                {
                    nonXCount ++;
                }
                
                if (xCount == nonXCount) 
                {
                    answer ++;
                    letters.RemoveRange(0, i + 1);
                    break;
                }
                
                if (i == letters.Count - 1)
                {
                    answer ++;
                    letters.RemoveRange(0, i + 1);
                    break;
                }
            }
        }
        
        return answer;
    }
}