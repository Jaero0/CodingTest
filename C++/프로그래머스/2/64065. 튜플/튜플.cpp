#include <string>
#include <vector>
#include <unordered_set>
#include <algorithm>
#include <iostream>

using namespace std;

vector<int> parse(string s)
{
    s += ",";
    string delimiter = ",";

    int cur_pos = 0;
    int pos;
    
    vector<int> v;
    while ((pos = s.find(delimiter, cur_pos)) != string::npos)
    {
        int len = pos - cur_pos;
        string result = s.substr(cur_pos, len);
        v.push_back(stoi(result));
        
        cur_pos = pos + 1;
    }
    
    return v;
}

vector<int> solution(string s) {
    vector<int> answer;
    
    vector<vector<int>> v;
    string add;
    //init
    for(int i = 2; i < s.size() - 1; i++)
    {
        if(s[i] == '}')
        {
            v.push_back(parse(add));
            add.clear();
            i+= 2;
            continue;
        }
            
        add += s[i];
    }
    
    //sort
    sort(v.begin(), v.end(), [](const vector<int>& a, const vector<int>& b)
          {
              return a.size() < b.size();
          });
    
    //calc
    unordered_set<int> set;
    
    for(auto vc : v)
    {
        for(int i : vc)
        {
            if(set.insert(i).second)
            {
                answer.push_back(i);
            }
        }
    }
    
    return answer;
}