public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        if (a < b) 
        {
            for (long i = a ; i < b + 1; i++) answer += i;
        }
        else 
        {
            for (long i = b ; i < a + 1; i++) answer += i;
        }
        
        return answer;
    }
}