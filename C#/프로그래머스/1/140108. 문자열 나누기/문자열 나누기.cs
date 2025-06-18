using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int same = 0;
        char f = s[0];
        
        for(int i = 0; i < s.Length - 1; i++)
        {
            char c = s[i];
            if(c == f) 
            {
                same++;
                continue;
            }
        
            same--;
            if(same == 0) 
            {
                answer++;
                f = s[i+1];
            }
            
        }
        
        return answer + 1;
    }
}