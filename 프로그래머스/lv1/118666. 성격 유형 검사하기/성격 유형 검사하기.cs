using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        Dictionary<char, int> type = new Dictionary<char, int>()
        {
            {'R', 0}, {'T', 0},
            {'C', 0}, {'F', 0},
            {'J', 0}, {'M', 0},
            {'A', 0}, {'N', 0},
        };
        
        for (int i = 0; i < survey.Length; i++)
        {
            if (choices[i] < 4)
            {
                type[survey[i][0]] += (4 - choices[i]);
            }
            else if (choices[i] > 4)
            {
                type[survey[i][1]] += (choices[i] - 4);
            }
        }
        
        answer += type['R'] >= type['T']? "R" : "T";
        answer += type['C'] >= type['F']? "C" : "F";
        answer += type['J'] >= type['M']? "J" : "M";
        answer += type['A'] >= type['N']? "A" : "N";
        
        return answer;
    }
}