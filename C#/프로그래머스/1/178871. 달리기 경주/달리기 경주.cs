using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        var rank = new Dictionary<string, int>();
        var rankup = new Dictionary<int, string>();
        
        for(int i = 0; i < players.Length; i++)
        {
            rank.Add(players[i], i + 1);
            rankup.Add(i + 1, players[i]);
        }
        
        for(int i = 0; i < callings.Length; i++)
        {
            string cur = callings[i];
            
            int curRank = rank[cur];
            string prev = rankup[curRank - 1];
            
            
            rank[cur]--;
            rankup[curRank] = prev;
            
            rank[prev]++;
            rankup[curRank-1] = cur;
        }
        
        string[] answer = new string[players.Length];
        
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = rankup[i + 1];
        }
        
        return answer;
    }
}