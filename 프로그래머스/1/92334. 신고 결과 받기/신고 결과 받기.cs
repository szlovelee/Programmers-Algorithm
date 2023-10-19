using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        HashSet<string> reports = new HashSet<string>(report);
        Dictionary<string, List<string>> reportCount = new Dictionary<string, List<string>>();
            
        foreach (string id in id_list)
        {
            reportCount.Add(id, new List<string>());
        }
        
        foreach (string reported in reports)
        {
            string[] reportSet = reported.Split(" ");
            reportCount[reportSet[1]].Add(reportSet[0]);
        }
        
        for (int i = 0; i < id_list.Length; i++)
        {
            if (reportCount[id_list[i]].Count >= k)
            {
                foreach (string reporter in reportCount[id_list[i]])
                {
                    int idx = Array.IndexOf(id_list, reporter);
                    answer[idx] ++;
                }
            }
        }
        
        return answer;
    }
}