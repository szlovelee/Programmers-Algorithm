using System.Text;

public class Solution 
{
    public string solution(int n) 
    {
        string answer = "";
        StringBuilder temp = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            if(i % 2 == 0) temp.Append("수");
            else temp.Append("박");
        }
        
        answer = temp.ToString();
        return answer;
    }
}