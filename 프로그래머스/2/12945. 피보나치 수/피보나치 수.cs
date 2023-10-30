public class Solution {
    public int solution(int n) {
        int answer = 0;
        int prev_1 = 0;
        int prev_2 = 1;
        int current = 0;
        for (int i = 1; i < n + 1; i++)
        {
            prev_1 = prev_2 % 1234567;
            prev_2 = current % 1234567 ;
            current = (prev_1 + prev_2) % 1234567;
        }
        answer = current;
        return answer;
    }
}