using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        Dictionary<int, int> numCount = new Dictionary<int,int>
        {
            {0,0}, {1,0}, {2,0}, {3,0}, {4,0}, {5,0}, {6,0}, {7,0}, {8,0}, {9,0} 
        };
        StringBuilder sb = new StringBuilder();
        char[] YC = Y.ToCharArray();
        Array.Sort(YC, (a,b) => b.CompareTo(a));
        
        foreach(char x in X)
        {
            numCount[x - '0']++;
        }
        
        foreach(char y in YC)
        {
            int val;
            int key = y - '0';
            if(numCount.TryGetValue(key, out val))
            {
                if(val > 0)
                {
                    sb.Append(y);
                    numCount[key]--;
                }
            }
        }
        
        if(sb.Length == 0) return "-1";
        
        answer = sb.ToString();
        if(answer[0] == '0') return "0";
        
        return answer;
    }
}