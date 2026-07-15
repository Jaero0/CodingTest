#include <string>
#include <vector>

using namespace std;

int solution(vector<int> citations) {
    
    int l = 0;
    int r = 10000;
    
    while(l <= r)
    {
        int mid = (l + r) / 2;
        
        int hup = 0;
        int hless = 0;
        for(int i : citations)
        {
            if(i >= mid) hup++;
            else hless++;
        }
        
        if(hup >= mid && hless <= mid)
        {
            l = mid + 1;
        }
        else
        {
            r = mid - 1;
        }
    }
    
    return r;
}
