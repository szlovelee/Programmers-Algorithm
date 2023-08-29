public class Solution 
{
    public string solution(string s) 
    {
        string answer = "";
        if(s.Length % 2 == 0)
        {
            answer = string.Format($"{s[s.Length / 2 - 1]}{s[s.Length / 2]}");
        }
        else 
        {
            answer = s[(s.Length - 1) / 2].ToString();
        }
        
        return answer;
    }
}