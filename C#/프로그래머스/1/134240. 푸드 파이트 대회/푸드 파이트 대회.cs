using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        for(int i = 1; i < food.Length; i++)
        {
            while(food[i] > 1)
            {
                answer += i.ToString();
                food[i] -= 2;
            }
        }
        
        answer += "0";
        var arr = answer.ToCharArray();
        for(int i = arr.Length - 2; i > -1; i--)
        {
            answer += arr[i];
        }
        
        return answer;
    }
}