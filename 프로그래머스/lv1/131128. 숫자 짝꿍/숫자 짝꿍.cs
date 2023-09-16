using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        string greater = (X.Length < Y.Length)? Y : X;
        string smaller = (X.Length < Y.Length)? X : Y;
        
        List<int> common = new List<int>();
        
        HashSet<int> processedNumbers = new HashSet<int>();
        
        for (int i = 0; i < smaller.Length; i ++)
        {
            int num = (int)(smaller[i] - '0');
            if (processedNumbers.Contains(num))
                continue; 
            processedNumbers.Add(num);
            
            int countG = greater.Count(s => s == (char)(num + '0'));
            int countS = smaller.Count(s => s == (char)(num + '0'));
            
            int count = (countG < countS)? countG : countS;
            
            if (countG != 0) 
            {
                for(int j = 0; j < count; j++)
                {
                    common.Add(num);
                }
                greater = greater.Replace(num.ToString(), "");
            }
        }
        common.Sort();
        common.Reverse();
        
        answer = string.Join("", common);
        if (answer == "") answer = "-1";
        else if (answer[0] == '0')
        {
            answer = "0";
        }    
        
        return answer;
    }
}