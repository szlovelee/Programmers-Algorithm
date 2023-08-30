using System;

class Solution
{
    public long solution(long price, long money, int count)
    {
        long totalPrice = 0;
        for (int i = 1; i < count + 1; i ++)
        {
            totalPrice += price * i;
        }
        
        return (totalPrice - money > 0)? totalPrice - money : 0;
    }
}