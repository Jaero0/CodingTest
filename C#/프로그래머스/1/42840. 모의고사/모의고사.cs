using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> list = new List<int>();
        int[] first = new int[5] {1,2,3,4,5}; 
        int[] second = new int[8] {2,1,2,3,2,4,2,5}; 
        int[] third = new int[10] {3,3,1,1,2,2,4,4,5,5};
        
        int fCount = 0;
        int sCount = 0;
        int tCount = 0;
        for(int i = 0; i < answers.Length; i++)
        {
            if(first[i % 5] == answers[i]) fCount++;
            if(second[i % 8] == answers[i]) sCount++;
            if(third[i % 10] == answers[i]) tCount++;
        }
        
        list.Add(fCount);
        list.Add(sCount);
        list.Add(tCount);
        
        int maxVal = list.ToArray().Max();
    
        
        List<int> ans = new List<int>();
        
        for(int i = 0; i < list.Count; i++)
        {
            if(list[i] == maxVal) ans.Add(i+1);
        }
        
        return ans.ToArray();
    }
}