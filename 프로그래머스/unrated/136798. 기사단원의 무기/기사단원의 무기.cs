using System;

public class Solution 
{
    public int solution(int number, int limit, int power) 
    {
        int answer = 0;
        for (int n = 1; n < number + 1; n ++)
        {
            int divisor = 1;
            int half = (n % 2 ==0)? n / 2 : (n - 1) / 2;
            for (int i = 1; i < half + 1; i++)
            {
                if (n % i == 0)
                {
                    ++ divisor;
                }
            }

            if (divisor > limit) answer += power;
            else answer += divisor;
        }
        return answer;
    }
}