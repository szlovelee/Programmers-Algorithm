using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    int count = 0;
                    for (int l = 2; l < sum; l++)
                    {
                        if (sum % l == 0) count++;
                    }
                    if (count == 0) answer ++;
                }
            }
        }

        return answer;
    }
}