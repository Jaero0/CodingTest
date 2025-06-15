using System;
public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        for(int i = 2; i <= n; i++)
        {
            int sqrt = (int)(Math.Sqrt(i));
            bool isDiv = false;
            
            if(sqrt * sqrt == i) continue;
            
            for(int j = 2; j <= sqrt; j++)
            {
                if(i % j == 0)
                {
                    isDiv = true;
                    break;
                }
            }
            
            if(isDiv) continue;
            answer++;
        }
        
        return answer;
    }
}