using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr) 
    {
        int[] answer;
        List<int> nums = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (i == j) continue;
                if (arr[i] > arr[j]) ++count;
            }
            if (count != 0) nums.Add(arr[i]);
        }
        
        if(arr.Length == 1) answer = new int[] {-1};
        else answer = nums.ToArray();
        return answer;
    }
}