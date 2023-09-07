using System.Collections.Generic;

public class Solution 
{
    public string solution(int a, int b) 
    {
        string[] days = new string[] { "THU", "FRI", "SAT", "SUN", "MON", "TUE", "WED"};
        
        int[] daysOfMonths = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        int totalDays = b;
        for (int i = 0; i < a - 1 ; i ++)
        {
            totalDays += daysOfMonths[i];
        }
        
        string answer = days[(totalDays) % 7];
        return answer;
    }
}