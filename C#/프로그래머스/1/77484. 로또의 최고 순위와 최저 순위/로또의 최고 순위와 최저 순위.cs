using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        
        Array.Sort(lottos, (a,b) => b.CompareTo(a));
        Array.Sort(win_nums, (a,b) => b.CompareTo(a));
        
        int zero = 0;
        int corr = 0;
        
        for(int i = 0; i < 6; i++)
        {
            if(lottos[i] == 0){
                zero++;
                continue;
            }
            
            if(Array.IndexOf(win_nums, lottos[i]) > -1)
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