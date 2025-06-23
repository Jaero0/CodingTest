using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[] {};
        
        int minX = wallpaper[0].Length;
        int minY = wallpaper.Length;
        int maxX = 0;
        int maxY = 0;
        
        for(int y = 0; y < wallpaper.Length; y++)
        {
            int fx = wallpaper[y].IndexOf("#");
            int lx = wallpaper[y].LastIndexOf("#");
            
            if(fx < 0) continue;
            
            if(minX > fx) minX = fx;
            if(maxX < lx) maxX = lx;
            if(minY > y) minY = y;
            if(maxY < y) maxY = y;
            
        }
        
        return new int[] {minY, minX, maxY + 1, maxX + 1};
    }
}