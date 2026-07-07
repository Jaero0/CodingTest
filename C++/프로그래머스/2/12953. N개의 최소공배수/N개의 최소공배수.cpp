#include <string>
#include <vector>
#include <iostream>

using namespace std;

int GCD(int a, int b)
{
    if(b == 0) return a;
    
    return GCD(b, a % b);
}

int solution(vector<int> arr) 
{
    int answer = arr[0];
    
    
    for(int i = 0; i < arr.size(); i++)
    {
        int gcd = GCD(answer, arr[i]);
        
        answer =  answer * arr[i] / gcd;
    }
    
    return answer;
}