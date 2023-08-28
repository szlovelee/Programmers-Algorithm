using System.Text;

public class Solution {
    public string solution(string phone_number) 
    {    
        StringBuilder hidden = new StringBuilder();
        int count = 1;
        foreach (char n in phone_number)
        {
            if (count < phone_number.Length - 3) hidden.Append("*");
            else hidden.Append(n);
            ++count;
        }
        return hidden.ToString();
    }
}