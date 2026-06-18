#include <string>
#include <vector>

using namespace std;

int CalcBin(int i)
{
    int originCount = 0;
    
    while(i != 0)
    {
        if(i & 1 == 1) originCount++;
        
        i = i>>1;
    }
    
    return originCount;
}

int solution(int n) 
{
    int answer = 0;
    
    int nCount = CalcBin(n);
    
    for(int i = n + 1; ; i++)
    {
        if(CalcBin(i) == nCount) return i;
    }
    
    
    return 0;
}