using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int x = 0;
        int y = 0;
        
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i,0] > sizes[i,1]) 
            {
                int t = sizes[i,0];
                sizes[i,0] = sizes[i,1];
                sizes[i,1] = t;
            }
            
            x = Math.Max(sizes[i,0], x);
            y = Math.Max(sizes[i,1], y);
        }
        
        return x * y;
    }
}