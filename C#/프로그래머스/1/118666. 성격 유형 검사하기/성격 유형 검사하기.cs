using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        Dictionary<char, int> dict = new Dictionary<char, int>
        {
            {'R', 0}, {'T', 0},  {'C', 0},  {'F', 0},  {'J', 0},  {'M', 0},  {'A', 0},  {'N', 0}, 
        };
        string[] total = new string[]{"RT", "CF", "JM", "AN"};
        
        for(int i = 0; i < survey.Length; i++)
        {
            string s = survey[i];
            int c = choices[i];
                switch(c)
                {
                    case 1:
                        dict[s[0]] += 3;
                        break;
                    case 2:
                        dict[s[0]] += 2;
                        break;
                    case 3:
                        dict[s[0]] += 1;
                        break;
                    case 4:
                        break;
                    case 5:
                        dict[s[1]] += 1;
                        break;
                    case 6:
                        dict[s[1]] += 2;
                        break;
                    case 7:
                        dict[s[1]] += 3;
                        break;
                }
            
        }
        
        foreach(string t in total)
        {
            char f = t[0];
            char s = t[1];
            
            int fVal = dict[f];
            int sVal = dict[s];
            
            if(fVal == sVal)
            {
                answer += f - s > 0 ? s.ToString() : f.ToString();
                continue;
            }
            
            int max = Math.Max(fVal, sVal);
            
            if(max == fVal)
            {
                answer += f.ToString();
            }
            else 
            {
                answer += s.ToString();
            }
        }
        
        return answer;
    }
}