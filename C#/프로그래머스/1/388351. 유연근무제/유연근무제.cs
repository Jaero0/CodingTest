using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        
        for(int i = 0; i < schedules.Length; i++)
        {
            int person = schedules[i];
            bool onTime = true;
            
            for(int j = 0; j < 7; j++)
            {
                int log = timelogs[i, j];
                
                int curDay = startday + j;
                if(curDay % 7 == 6 || curDay % 7 == 0)
                {
                    continue;
                }
                
                int maxTime = person + 10;
                string sub = maxTime.ToString().Length == 4 ? 
                    maxTime.ToString().Substring(0,2) :
                    maxTime.ToString().Substring(0,1);
                
                if(maxTime - (int.Parse(sub) * 100) > 59)
                {
                    maxTime = maxTime + 40;
                }
                
                if(log > maxTime)
                {
                    onTime = false;
                }
            }
            
            if(onTime == true)
            {
                answer++;
            }
        }
        
        return answer;
    }
}