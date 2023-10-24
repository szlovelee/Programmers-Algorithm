public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] words = s.Split(" ");
        foreach (string word in words)
        {
            int num;
            string str = "";
            for(int i = 0; i < word.Length; i++)
            {
                if (!int.TryParse(word[i].ToString(), out num))
                {
                    str = (i == 0)? char.ToUpper(word[i]).ToString() : $"{str}{char.ToLower(word[i])}";
                }
                else 
                {
                    str = $"{str}{num}";
                }
            }
            answer = (answer == "")? str : $"{answer} {str}";
        }
        return answer;
    }
}