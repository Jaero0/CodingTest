using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 1;
        
        for(int i = 2; i <= number; i++)
        {
            int sqrt = (int)(Math.Sqrt(i));
            int count = 0;
            for(int j = 1; j <= sqrt; j++)
            {
                if(i % j == 0)
                {
                    count++;
                }
            }
            count = sqrt * sqrt == i ? count * 2 - 1 : count * 2;
            
            answer += count > limit ? power : count;
            
        }
        
        return answer ;
    }
}