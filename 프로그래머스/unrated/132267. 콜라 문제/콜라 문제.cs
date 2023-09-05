using System;

public class Solution 
{
    public int solution(int a, int b, int n) 
    {
        int answer = 0;
        while (n >= a)
        {
            int left = n % a;
            n -= left;
            int added = (n / a) * b;
            answer += added;
            n = left + added;
        }
        return answer;
    }
}