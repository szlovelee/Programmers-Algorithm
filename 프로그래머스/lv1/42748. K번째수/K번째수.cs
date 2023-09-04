using System;

public class Solution 
{
    public int[] solution(int[] array, int[,] commands) 
    {
        int[] answer = new int[commands.GetLength(0)];
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int[] tempArr = new int[commands[i, 1] - commands[i, 0] + 1];
            int count = 0;
            for (int j = commands[i, 0] - 1; j < commands[i, 1]; j ++)
            {
                tempArr[count] = array[j];
                count ++;
            }
            Array.Sort(tempArr);
            answer[i] = tempArr[commands[i, 2] - 1];
        }
        return answer;
    }
}