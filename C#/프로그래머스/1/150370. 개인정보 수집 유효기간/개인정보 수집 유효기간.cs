using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        var answer = new List<int>();
        
        string[] ymd = today.Split('.');
        int curY = int.Parse(ymd[0]) - 2000;
        int curM = int.Parse(ymd[1]);
        int curD = int.Parse(ymd[2]);
        long totalCurDates = curD + (curM - 1) * 28;
        if(curY > 0)
        {
            totalCurDates += (curY-1)*12*28;
        }
        
        Dictionary<string, int> termDict = new Dictionary<string, int>();
        foreach(string t in terms)
        {
            string[] s = t.Split(' ');
            termDict.Add(s[0], int.Parse(s[1]));
        }
        
        for(int i = 0; i < privacies.Length; i++)
        {
            string[] priv = privacies[i].Split(' ');
            int term = termDict[priv[1]];
            
            string[] dates = priv[0].Split('.');
            int year = int.Parse(dates[0]) - 2000;
            int month = int.Parse(dates[1]);
            int date = int.Parse(dates[2]);
            
            month += term;
            while(month > 12)
            {
                year++;
                month -= 12;
            }
            
            date--;
            if(date < 1)
            {
                date = 28;
                month--;
            }
            if(month < 1)
            {
                month = 12;
                year--;
            }
            
            //Console.WriteLine(year+", "+month+", "+date);
            
            long termMaxDates = date + ((month - 1) * 28);
            if(year > 0)
            {
                termMaxDates += (year-1) * 12 * 28;
            }   
            
            if(totalCurDates > termMaxDates)
            {
                answer.Add(i + 1);
            }
        }
        
        return answer.ToArray();
    }
}