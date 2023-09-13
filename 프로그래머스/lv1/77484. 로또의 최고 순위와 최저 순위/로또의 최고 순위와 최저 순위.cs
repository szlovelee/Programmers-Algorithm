using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        
        int winCount = 0;
        int zeroCount = 0;
        
        foreach (int num in lottos)
        {
            if (win_nums.Count(n => n == num) != 0)
            {
                winCount ++;
            }
            
            if (num == 0)
            {
                zeroCount ++;
            }
        }
        answer[0] = (7 - (winCount + zeroCount) <= 6)? 7 - (winCount + zeroCount) : 6;
        answer[1] = (7 - winCount <= 6)? 7 - winCount : 6;
        
        return answer;
    }
}