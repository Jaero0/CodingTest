using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        List<int> scoreList = new List<int>(score);
        scoreList.Sort((a,b) => b.CompareTo(a));
        
        for(int i = 0; i < m - (scoreList.Count % m); i++)
        {
            scoreList.Add(0);
        }
        
        for(int i = m - 1; i < scoreList.Count; i += m)
        {
            answer += scoreList[i] * m;
        }
        
        
        return answer;
    }
}