using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public string[] solution(string[] players, string[] callings) 
    {
        Dictionary<string, int> playerOrder = new Dictionary<string, int>();
        for (int i = 0; i < players.Length; i++)
        {
            playerOrder[players[i]] = i;
        }
        foreach(string name in callings)
        {
            ChangeList(name, players, playerOrder);
        }
        return players;
    }
    
    void ChangeList(string name, string[] list, Dictionary<string, int> playerOrder)
    {
        int idx = playerOrder[name];
        if (idx > 0)
        {
            string tempName = list[idx - 1];
            list[idx - 1] = list[idx];
            list[idx] = tempName;
            
            playerOrder[name] = idx - 1;
            playerOrder[tempName] = idx;
        }
    }
}