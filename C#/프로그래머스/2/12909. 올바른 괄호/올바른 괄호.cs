using System;

public class Solution {
    public bool solution(string s) {
        
        int openCount = 0;
        int closeCount = 0;
        
        if (s[0] == ')') return false;
        
        foreach(char c in s)
        {
            if(c == '(')
            {
                openCount++;
                continue;
            }
            closeCount++;
            
            if (closeCount > openCount) return false;
            
        }
        
        return openCount == closeCount ? true : false;
    }
}