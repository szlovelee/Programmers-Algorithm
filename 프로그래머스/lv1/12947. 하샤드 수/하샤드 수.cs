public class Solution {
    public bool solution(int x) {
        
        int len = x.ToString().Length;
        int[] nums = new int[len];
        
        int original = x;
        int sum = 0;
        for (int i = 1; i < len +1; i++ )
        {
            sum += x % 10;
            x /= 10;   
        }
        bool answer = (original / sum) == ((float)original / sum) ? true : false;
        return answer;
    }
}