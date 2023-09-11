using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer;
        
        List<int> tempAnswer = new List<int>();
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        
        string answer1 = "12345";
        string answer2 = "21232425";
        string answer3 = "3311224455";
        
        
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == (answer1[i % 5] - '0')) count1++;
            if (answers[i] == (answer2[i % 8] - '0')) count2++;
            if (answers[i] == ( answer3[i % 10] - '0')) count3++;
        }
        
        if (count1 >= count2 && count1 >= count3) tempAnswer.Add(1);
        if (count2 >= count1 && count2 >= count3) tempAnswer.Add(2);
        if (count3 >= count1 && count3 >= count2) tempAnswer.Add(3);
        
        
        answer = tempAnswer.ToArray();
        return answer;
    }
}