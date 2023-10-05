using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        int[] answer;
        
        DateTime todayInDateTime;
        DateTime.TryParseExact(today, "yyyy.MM.dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out todayInDateTime);
        
        string[] todayData = today.Split('.');
        Dictionary<string, int> termSet = new Dictionary<string, int>();
        foreach (string t in terms)
        {
            string[] pieces  = t.Split(" ");
            termSet.Add(pieces[0], int.Parse(pieces[1]));
        }
        List<int> tempAnswer = new List<int>();
        
        for (int i = 0; i < privacies.Length; i++)
        {
            DateTime collectedDate;
            string[] info = privacies[i].Split(" ");
            DateTime.TryParseExact(info[0], "yyyy.MM.dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out collectedDate);
            DateTime expectedDate = collectedDate.AddMonths(termSet[info[1]]);
            if (todayInDateTime >= expectedDate)
            {
                tempAnswer.Add(i + 1);
            }
        }
        answer = tempAnswer.ToArray();
        return answer;
    }
}