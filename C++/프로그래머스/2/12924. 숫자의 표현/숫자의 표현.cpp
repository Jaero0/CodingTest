#include <string>
#include <vector>
#include <iostream>

using namespace std;

int solution(int n) 
{
    int l = 1;
    int r = 1;
    int sum = 1;
    int count = 0;
    
    while(l <= r)
    {
        if(sum < n)
        {
            r++;
            sum += r;
        }
        else if(sum > n)
        {
            sum -= l;
            l++;
        }
        else
        {
            count++;
            sum -= l;
            l++;
        }
    }
    
    return count;
}