using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr, int divisor) 
    {
        List<int> nums = new List<int>();
        
        foreach (int i in arr)
        {
            if (i % divisor == 0) nums.Add(i);
        }
        
        nums.Sort();
        
        int[] answer = new int[nums.Count];
        
        for (int i = 0; i < nums.Count; i++)
        {
            answer[i] = nums[i];
        }
        return (answer.Length == 0)? answer = new int[] {-1} : answer;
    }
}