using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[] {};
        
        var id_reportCount = new Dictionary<string, int>();
        var id_reportingList = new Dictionary<string, List<string>>();
        
        var id_reportSuccessCount = new Dictionary<string, int>();
        
        foreach(string s in id_list)
        {
            id_reportCount.Add(s, 0);
            id_reportingList.Add(s, new List<string>());
            
            id_reportSuccessCount.Add(s, 0);
        }
        
        foreach(string r in report)
        {
            string[] sa = r.Split(' ');
            string reporting = sa[0];
            string reported = sa[1];
            
            List<string> reportedListById = id_reportingList[reporting];
            
            if(reportedListById.IndexOf(reported) > -1)
            {
                continue;
            }
            
            id_reportCount[reported]++;
            reportedListById.Add(reported);
        }
        
        var vanId = new List<string>();
        foreach(var kvp in id_reportCount)
        {
            if(kvp.Value >= k) vanId.Add(kvp.Key);
        }
        
        foreach(var kvp in id_reportingList)
        {
            string id = kvp.Key;
            List<string> reportList = kvp.Value;
            
            foreach(string r in reportList)
            {
                if(vanId.IndexOf(r) > -1)
                {
                    id_reportSuccessCount[id]++;
                }
            }
        }
        
        return id_reportSuccessCount.Values.ToArray();
    }
}