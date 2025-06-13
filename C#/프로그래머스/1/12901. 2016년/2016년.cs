public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        int[] days = new int[] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        string[] date = new string[] {"FRI","SAT","SUN","MON","TUE","WED","THU"};
        
        int totalDays = b;
        
        for(int i = 0; i < a - 1; i++)
        {
            totalDays += days[i];
        }
        
        
        return date[totalDays % 7 - 1 < 0 ? 6 : totalDays % 7 - 1];
    }
}