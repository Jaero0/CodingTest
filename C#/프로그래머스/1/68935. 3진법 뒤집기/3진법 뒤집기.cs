using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        //15... 0
        //5... 0
        //1... 2
        //0... 1
        
        string s = "";
        while (n != 0)
        {
            int t = n % 3;
            n /= 3;
            
            s += t.ToString();
        }
        
        for (int i = 0; i < s.Length; i++)
        {
            answer += (int)Math.Pow(3, s.Length - i - 1) * (s[i] - '0');
        }
        
        return answer;
    }
}