using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            int count = -1;
            for(int j = i-1; j >= 0; j--)
            {
                if (s[j] == c)
                {
                    count = i - j;
                    break;
                }
            }
            
            answer[i] = count;
        }
        
        return answer;
    }
}