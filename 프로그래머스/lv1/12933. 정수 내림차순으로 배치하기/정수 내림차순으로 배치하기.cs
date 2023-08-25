using System;
using System.Text;

public class Solution 
{
    public long solution(long n) 
    {
        long answer;
        
        string num = n.ToString();
        char[] nums = num.ToCharArray();
        
        Array.Sort(nums);
        Array.Reverse(nums);
        
        StringBuilder newNums = new StringBuilder();
        newNums.Append(nums);
        
        return answer = long.Parse(newNums.ToString());
    }
}