using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        
        int zero = 0;
        int corr = 0;
        
        foreach(int l in lottos)
        {
            if(l == 0){
                zero++;
                continue;
            }
            
            if(Array.IndexOf(win_nums, l) > -1)
            {
                corr++;
            }
        }
        
        int maxCor = corr + zero;
        
        answer[0] = 6 - maxCor == 6 ? 6 : 6 - maxCor + 1;
        answer[1] = 6 - corr == 6 ? 6 : 6 - corr + 1;
        
        return answer;
    }
}