using System;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        
        int totalLen = getTotalSecond(video_len);
        int curPos = getTotalSecond(pos);
        int opStartLen = getTotalSecond(op_start);
        int opEndLen = getTotalSecond(op_end);
        
        foreach(string c in commands)
        {
            if(opStartLen <= curPos && curPos < opEndLen) curPos = opEndLen;
            switch (c)
            {
                case "next": 
                    curPos += 10;
                    break;
                case "prev": 
                    curPos -= 10;
                    break;
            }
            
            if(curPos < 0) curPos = 0;
            if(curPos > totalLen) curPos = totalLen;
        }
        
        if(opStartLen <= curPos && curPos < opEndLen) curPos = opEndLen;
        
        string min = (curPos / 60).ToString();
        string sec = (curPos % 60).ToString();
        
        if(min.Length == 1)
        {
            min = "0" + min;
        }
        if(sec.Length == 1)
        {
            sec = "0" + sec;
        }
        
        return min + ":" + sec;
    }
    
    public int getTotalSecond(string time)
    {
        string[] totalLen = time.Split(':');
        return int.Parse(totalLen[0]) * 60 + int.Parse(totalLen[1]);
    }
}