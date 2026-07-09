#include <iostream>
#include <algorithm>

using namespace std;

int solution(int n, int a, int b)
{
    int answer = 0;
    
    //1 2 3 4 5 6 7 8
    //1 1 2 2 3 3 4 4
    //1   2   3   4
    //1   1   2   2
    //1       2
    //1       1
    
    while(a != b)
    {
        a = (a + 1) / 2;
        b = (b + 1) / 2;
        answer++;
    }
    
    return answer;
}