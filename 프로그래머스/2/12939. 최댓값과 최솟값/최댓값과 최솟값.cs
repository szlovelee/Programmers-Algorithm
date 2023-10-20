public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] splited = s.Split(" ");
        for (int i = 0; i < splited.Length - 1; i++)
        {
            int min = int.Parse(splited[i]);
            int idx = i;
            
            for (int j = i + 1; j < splited.Length; j++)
            {
                if (int.Parse(splited[j]) < min)
                {
                    min = int.Parse(splited[j]);
                    idx = j;
                }
            }
            string temp = splited[i];
            splited[i] = splited[idx];
            splited[idx] = temp;
        }
        
        answer = $"{splited[0]} {splited[splited.Length - 1]}";
        
        return answer;
        
    }
}