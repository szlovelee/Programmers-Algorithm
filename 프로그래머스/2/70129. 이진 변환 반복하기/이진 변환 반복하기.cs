using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        string result = s;
        int repeat = 0;
        int removed = 0;
        while (result != "1")
        {
            int originalLength = result.Length;
            
            result = result.Replace("0", "");
            
            int currentLength = result.Length;
            int count = originalLength - currentLength;
            removed += count;
            
            List<char> convert = new List<char>();
            while (currentLength > 0)
            {
                char remain = (char)('0' + (currentLength % 2));
                convert.Add(remain);
                currentLength /= 2;
            }
            result = new string(convert.ToArray());
            
            repeat ++;
        }
        answer[0] = repeat;
        answer[1] = removed;
        return answer;
    }
}