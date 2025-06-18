using System;
using System.Text;

public class Solution {
    public string solution(string s, string skip, int index) {
        
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            for(int j = 0; j < index; j++)
            {
                c++;
                if('z' < c) c = 'a';
                
                for(int k = 0; k < skip.Length; k++)
                {
                    if(skip.Contains(c)) c++;
                    if('z' < c) c = 'a';
                }
            }
            
            sb.Append(c);
        }
        
        return sb.ToString();
    }
}