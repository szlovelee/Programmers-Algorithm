using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "";
        List<int> cards1Index = new List<int>();
        List<int> cards2Index = new List<int>();
        
        int count = 0;
        for (int i = 0; i < cards1.Length; i++)
        {
            if (Array.IndexOf(goal, cards1[i]) != -1)
            {
                if (count < 1) cards1Index.Add(Array.IndexOf(goal, cards1[i]));
                else return "No";
            }
            else count ++;
        }
        
        count = 0;
        for (int j = 0; j < cards2.Length; j++)
        {          
            if (Array.IndexOf(goal, cards2[j]) != -1)
            {
                if (count < 1) cards2Index.Add(Array.IndexOf(goal, cards2[j]));
                else return "No";
            }
            else count ++;
        }
        
        List<int> copyIndex1 = cards1Index.ToList();
        List<int> copyIndex2 = cards2Index.ToList();
        
        copyIndex1.Sort();
        copyIndex2.Sort();
        
        answer = (Enumerable.SequenceEqual(cards1Index, copyIndex1) && Enumerable.SequenceEqual(cards2Index, copyIndex2))? "Yes" : "No";
        return answer;
    }
}