using System.Collections.Generic;
using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        
        Dictionary<char, int> dict = new Dictionary<char, int>();
        
        //keymap에 존재하는 char를 dict에 char와 인덱스 페어로 저장
        foreach(string key in keymap)
        {
            for(int i = 1; i <= key.Length; i++)
            {
                char k = key[i - 1];
                int idx;
                //인덱스는 항상 최저값으로 유지하기
                if(dict.TryGetValue(k, out idx))
                {
                    if(idx > i) dict[k] = i;
                    continue;
                }
                dict.Add(k, i);
            }
        }
        
        for(int i = 0; i < targets.Length; i++)
        {
            string target = targets[i];
            foreach(char t in target)
            {
                int idx;
                if(dict.TryGetValue(t, out idx) == false) 
                {
                    answer[i] = -1;
                    break;
                }
                answer[i] += idx;
            }
        }
        
        return answer;
    }
}