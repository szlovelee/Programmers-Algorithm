public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int bigger = (n < m)? m : n;
        int smaller = (n < m)? n : m;
        
        for (int i = smaller; i > 0; i--)
        {
            if (n % i == 0 && m % i == 0)
            {
                answer[0] = i;
                break;
            }
        }
        
        for (int j = bigger; j <= m * n; j++)
        {
            if (j % n == 0 && j % m == 0)
            {
                answer[1] = j;
                break;
            }
        }
        
        return answer;
    }
}