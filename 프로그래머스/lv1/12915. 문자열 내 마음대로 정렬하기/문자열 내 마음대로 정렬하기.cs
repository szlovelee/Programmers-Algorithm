using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public string[] solution(string[] strings, int n) 
    {
        string[] answer;
        
        List<string> sorting = strings.ToList();
        answer = sorting.OrderBy(i => i[n]).ThenBy(i => i).ToArray();
        return answer;
    }
}