public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        int alpha = 26;
        
        foreach(char c in s)
        {
            if (c == ' ')
            {
                answer += " ";
                continue;
            }
            
            char t = ' ';
            if('A' <= c && c <= 'Z')
            {
                if (c + n >= 91)
                {
                    t = (char)(c - 26 + n);
                }
                else
                {
                    t = (char)(c + n);
                }
            }
            else
            {
                if (c + n >= 123)
                {
                    t = (char)(c - 26 + n);
                }
                else
                {
                    t = (char)(c + n);
                }
            }
            
            answer += t;
        }
        
        return answer;
    }
}