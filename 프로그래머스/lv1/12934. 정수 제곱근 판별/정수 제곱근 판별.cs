using static System.Math;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        double sqrt = Sqrt(n);
        if (sqrt == (long)sqrt)  answer = ((long)sqrt + 1) * ((long)sqrt + 1);
        else answer = -1;
        return answer;
    }
}