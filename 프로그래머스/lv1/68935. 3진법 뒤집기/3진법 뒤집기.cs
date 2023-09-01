using System;
using static System.Math;

public class Solution {
    public int solution(int n) 
    {        
        int x = 0;

        while (true)
        {
            if ((int)Pow(3, x) > n) break;
            ++x;
        }

        int [] result = new int[x];

        for (int i = 0; i < x; i++)
        {

            int value = n / (int)Pow(3, x - i - 1);
            n -= value * (int)Pow(3, x - i - 1);

            result[x - i - 1] = value;

        }


        int answer = 0;

        for (int j = 0; j < x; j++)
        {
            answer += (int)Pow(3, x - j - 1) * result[j];
        }

        return answer;
    }
}