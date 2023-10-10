using System;
using System.Linq;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[] {};
        int[] curPoint = new int[] {};
        int maxHeight = park.Length - 1;
        int maxWidth = park[0].Length - 1;
        
        for (int i = 0; i < park.Length; i++)
        {
            if (park[i].Contains("S"))
            {
                curPoint = new int[] {i, park[i].IndexOf("S")};
                break;
            }
        }
        foreach (string move in routes)
        {
            string[] moveDirection = move.Split(" ");
            switch (moveDirection[0])
            {
                case "E":
                    if (curPoint[1] + int.Parse(moveDirection[1]) <= maxWidth)
                    {
                        int tempPoint = curPoint[1];
                        for (int j = 1; j <= int.Parse(moveDirection[1]); j++)
                        {
                            if (park[curPoint[0]][curPoint[1] + j] == 'X')
                            {
                                tempPoint = curPoint[1];
                                break;
                            }    
                            else tempPoint++;
                        }
                        curPoint[1] = tempPoint;
                    }
                    break;
                case "W":
                    if (curPoint[1] - int.Parse(moveDirection[1]) >= 0)
                    {
                        int tempPoint = curPoint[1];
                        for (int j = 1; j <= int.Parse(moveDirection[1]); j++)
                        {
                            if (park[curPoint[0]][curPoint[1] - j] == 'X')
                            {
                                tempPoint = curPoint[1];
                                break;
                            }
                            else tempPoint--;
                        }
                        curPoint[1] = tempPoint;
                    }
                    break;
                case "N":
                    if (curPoint[0] - int.Parse(moveDirection[1]) >= 0)
                    {
                        int tempPoint = curPoint[0];
                        for (int j = 1; j <= int.Parse(moveDirection[1]); j++)
                        {
                            if (park[curPoint[0] - j][curPoint[1]] == 'X')
                            {
                                tempPoint = curPoint[0];
                                break;
                            }
                            else tempPoint--;
                        }
                        curPoint[0] = tempPoint;
                    }
                    break;
                case "S":
                    if (curPoint[0] + int.Parse(moveDirection[1]) <= maxHeight)
                    {
                        int tempPoint = curPoint[0];
                        for (int j = 1; j <= int.Parse(moveDirection[1]); j++)
                        {
                            if (park[curPoint[0] + j][curPoint[1]] == 'X')
                            {
                                tempPoint = curPoint[0];
                                break;
                            }
                            else tempPoint++;
                        }
                        curPoint[0] = tempPoint;
                    }
                    break;
            }
        }
        return curPoint;
    }
}