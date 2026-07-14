#include <string>
#include <vector>
#include <unordered_map>

using namespace std;

int solution(vector<vector<string>> clothes) {
    
    int sum = 1;
    unordered_map<string, int> m;
    
    for(vector<string> v : clothes)
    {
        m[v[1]]++;
    }
    
    for(auto p : m)
    {
        sum *= p.second + 1;
    }
    
    return sum - 1;
}