public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int len = arr1.GetLength(0);
        int len2 = arr1.GetLength(1);
        int[,] answer = new int[len, len2];
        
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len2; j++)
            {
                answer[i, j] = arr1[i,j] + arr2[i,j];
            }
        }
        return answer;
    }
}