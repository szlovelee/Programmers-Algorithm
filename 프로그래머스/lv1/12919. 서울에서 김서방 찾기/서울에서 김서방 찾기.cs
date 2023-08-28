using System;

public class Solution {
    public string solution(string[] seoul) 
    {
        int index = Array.IndexOf(seoul, "Kim");
        string answer = string.Format($"김서방은 {index}에 있다");
        return answer;
    }
}