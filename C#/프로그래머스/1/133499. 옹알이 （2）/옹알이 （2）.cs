using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] bab = new string[] {"aya", "ye", "woo", "ma"};
        string[] bab_dou = new string[] {"ayaaya", "yeye", "woowoo", "mama"};
        
        for(int i = 0; i < babbling.Length; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if(babbling[i].Contains(bab_dou[j]))
                {
                    babbling[i] = babbling[i].Replace(bab_dou[j], "1");
                    continue;
                }
                
                if(babbling[i].Contains(bab[j]))
                {
                    babbling[i] = babbling[i].Replace(bab[j], " ");
                }
            }
            
            string s = babbling[i];
            
            if(s.Trim().Length == 0) answer++;
        }
        
        return answer;
    }
}