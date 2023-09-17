using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int n, int[] lost, int[] reserve) 
    {
        int answer = n - lost.Length;
        List<int> lostList = lost.ToList();
        List<int> reserveList = reserve.ToList();
        lostList.Sort();
        reserveList.Sort();
        
        for (int i = 0; i < lost.Length; i++)
        {
            int idx = reserveList.IndexOf(lost[i]);
            if (idx != -1)
            {
                reserveList.Remove(lost[i]);
                lostList.Remove(lost[i]);
                answer ++;
            }
        }
        
        foreach (int l in lostList)
        {            
            if (reserveList.Contains(l - 1))
            {
                answer ++;
                reserveList.Remove(l - 1);
            }
            else if (reserveList.Contains(l + 1))
            {
                answer ++;
                reserveList.Remove(l + 1);
            }
        }
        
        return answer;
    }
}