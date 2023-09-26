using System;
using System.Linq;

public class Solution {
    public int[] solution(string[] wallpaper) 
    {
        int maxWidth = wallpaper[0].Length;
        int maxHeight = wallpaper.Length;
        int[] answer;
        int lux = maxHeight;
        int luy = maxWidth;
        int rdx = 0;
        int rdy = 0;        
        
        for (int i = 0; i < maxHeight; i++)
        {
            if (wallpaper[i].Contains('#'))
            {
                if (i < lux)
                    lux = i;
                if (wallpaper[i].IndexOf('#') < luy)
                    luy = wallpaper[i].IndexOf('#');
                if (i + 1> rdx)
                    rdx = i + 1;
                if (wallpaper[i].LastIndexOf('#') + 1> rdy)
                    rdy = wallpaper[i].LastIndexOf('#') + 1;
            }

        }
        answer = new int[] {lux, luy, rdx, rdy};
        return answer;
    }
}

// 입력값 〉 [".....", "....#"]
// 기댓값 〉 [1, 4, 2, 5]