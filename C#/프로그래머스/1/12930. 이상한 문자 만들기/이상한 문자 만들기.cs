using System.Text;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        string[] spl = s.Split(' ');
        
        for(int j = 0; j < s.Length; j++)
        {
            string s1 = spl[j];
            
            for(int i = 0; i < s1.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    if (97 <= s1[i] && s1[i] <= 122)
                    {
                        answer += ((char)(s1[i]-32)).ToString();
                    }
                    else
                    {
                        answer += s1[i];
                    }
                }
                else
                {
                    if (97 <= s1[i] && s1[i] <= 122)
                    {
                        answer += s1[i];
                    }
                    else
                    {
                        answer += ((char)(s1[i] + 32)).ToString();
                    }
                }
            }
            
            if (j == spl.Length - 1)
                break;
            
            answer += " ";
        }
        
        return answer;
    
    }
}