using System;
using System.Linq;

public class Solution 
{
    public int solution(int[,] sizes) 
    {
        int answer = 0;
        int[] minValues = new int[sizes.GetLength(0)];
        int[] maxValues = new int[sizes.GetLength(0)];
        for (int i = 0; i < sizes.GetLength(0); i ++)
        {
            minValues[i] = Math.Min(sizes[i, 0], sizes[i, 1]);
            maxValues[i] = Math.Max(sizes[i, 0], sizes[i, 1]);
        }
        
        answer = minValues.Max() * maxValues.Max();
        return answer;
    }
}