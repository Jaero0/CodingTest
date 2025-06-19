using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        Stack<int> stack = new Stack<int>();
        
        foreach(int i in ingredient)
        {
            stack.Push(i);
            
            if(stack.Count >= 4)
            {
                int l = stack.Pop();
                int t = stack.Pop();
                int s = stack.Pop();
                int f = stack.Pop();
                
                if(f == 1 && s == 2 && t == 3 && l == 1)
                {
                    answer++;
                    continue;
                }
                
                stack.Push(f);
                stack.Push(s);
                stack.Push(t);
                stack.Push(l);
            }
        }
        
        return answer;
    }
}