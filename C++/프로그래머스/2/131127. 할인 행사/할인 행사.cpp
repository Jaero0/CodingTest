#include <string>
#include <vector>
#include <unordered_map>

using namespace std;

int solution(vector<string> want, vector<int> number, vector<string> discount) {
    int answer = 0;
    
    string start = want[0];
    unordered_map<string, int> foodCountM;
    
    for(int i = 0; i < want.size(); i++)
    {
        foodCountM[want[i]] = number[i];
    }
    
    for(int i = 0; i <= discount.size() - 10; i++)
    {
        if(foodCountM[discount[i]] == 0) continue;
        
        unordered_map<string, int> checkM = foodCountM;
        bool isPassed = true;
        for(int r = i; r < i + 10; r++)
        {
            checkM[discount[r]]--;
            
            if(checkM[discount[r]] < 0)
            {
                isPassed = false;
                break;
            }
        }
        
        if(isPassed) answer++;
        
    }
    
    return answer;
}