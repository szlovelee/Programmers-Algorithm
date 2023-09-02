public class Solution 
{
    public string solution(string s) 
    {
        string answer = "";
        long count = 0;
        foreach (char c in s)
        {
            if (c == ' ')
            {
                count = 0;
                answer += " ";
            }
            else 
            {
                answer += (count % 2 == 0)? c.ToString().ToUpper() : c.ToString().ToLower();
                count ++;
            }
        }
        
        return answer;
    }
}