#include <string>
#include <vector>
#include <iostream>
#include <unordered_map>
#include <algorithm>

using namespace std;

int solution(int k, vector<int> tangerine) {
    int answer = 0;
    
    unordered_map<int, int> m;
    for(int i : tangerine)
    {
        m[i]++;
    }
    
    vector<pair<int,int>> vec(m.begin(), m.end());
    
    sort(vec.begin(), vec.end(), 
         [](pair<int,int> a, pair<int,int> b)
         {
             return a.second > b.second;
         });
    
    int count = 0;
    int sum = 0;
    
    for(pair<int, int> p : vec)
    {
        count++;
        sum += p.second;
        
        if(sum >= k) return count;
    }
    
    return answer;
}