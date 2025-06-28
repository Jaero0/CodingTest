using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int w, int num) {
        int answer = 0;
        
        var boxes = new List<List<int>>();
        
        int loop = n % w == 0 ? n / w : n / w + 1;
        
        for(int i = 0; i < loop; i++)
        {
            var l = new List<int>();
            
            for(int j = 1; j <= w; j++)
            {
                int add = i * w + j;
                if(add > n)
                {l.Add(-1); continue;}
                l.Add(add);
            }
            
            if(i % 2 == 1) l.Reverse();
            
            boxes.Add(l);
        }
        
        /*foreach(var l in boxes)
        {
            foreach(int i in l)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }*/
        
        for(int i = 0; i < boxes.Count; i++)
        {
            bool isBroken = false;
            for(int j = 0; j < boxes[0].Count; j++)
            {
                int cur = boxes[i][j];
                
                if(cur == num)
                {
                    int maxI = boxes.Count;
                    int maxJ = boxes[maxI-1].Count;
                    
                    Console.WriteLine("cur: " + cur + ", " + "i: " + i + ", " + "j: " + j);
                    Console.WriteLine("cur: " + cur + ", " + "maxI: " + maxI + ", " + "maxJ: " + maxJ);
                    
                    if(maxI - i > 0)
                    {
                        int maxVal = boxes[maxI-1][j];
                        
                        if(maxVal < 0) maxI--;
                        
                        answer = maxI - i;
                        
                        isBroken = true;
                        break;
                    }
                }
            }
            
            if(isBroken == true) break;
        }
        
        return answer;
    }
}