using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        
        Dictionary<int, int> studentCloth = new Dictionary<int, int>();
        
        //여벌 옷 게이 추가
        foreach(int r in reserve)
        {
            studentCloth.Add(r, 2);
        }
        //스틸 게이 추가
        foreach(int r in lost)
        {
            if(studentCloth.TryGetValue(r, out int a))
            {
                studentCloth[r] = 1;
                continue;
            }
            studentCloth.Add(r, 0);
        }
        //일반 게이 추가
        for(int i = 1; i <= n; i++)
        {
            if(studentCloth.TryGetValue(i, out int a) == false)
            {
                studentCloth.Add(i, 1);
            }
        }
        
        //딕셔너리 돌면서 스틸당한 게이들에게 옷 물려주기 시작
        for(int i = 1; i <= n; i++)
        {
            int zeroVal = studentCloth[i];
            
            //스틸당한 게이는
            if(zeroVal == 0)
            {
                int extraVal;
                
                //앞번호 게이한테 먼저 찾고,
                if(studentCloth.TryGetValue(i - 1, out extraVal) == true)
                {
                    //앞 번호 게이가 여벌옷 있으면 하나 물려줌
                    if(extraVal > 1)
                    {
                        studentCloth[i]++;
                        studentCloth[i - 1]--;
                        continue;
                    }
                }
                //앞번호 게이 없으면, 뒷번호 게이한테 찾고,
                if(studentCloth.TryGetValue(i + 1, out extraVal) == true)
                {
                    //뒷번호 게이 여벌옷 있으면 하나 물려줌
                    if(extraVal > 1)
                    {
                        studentCloth[i]++;
                        studentCloth[i + 1]--;
                        continue;
                    }
                }
            }
        }
        
        foreach(KeyValuePair<int, int> d in studentCloth)
        {
            if(d.Value > 0) answer++;
        }
        
        return answer;
    }
}