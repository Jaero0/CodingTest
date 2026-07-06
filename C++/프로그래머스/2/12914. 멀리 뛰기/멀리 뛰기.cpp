#include <vector>

long long solution(int n) 
{
    //1 1, 2 2, 3 3, 4 5, 5 8
    std::vector<long long> v;
    v.push_back(0);
    v.push_back(1);
    v.push_back(2);
    for(int i = 3; i <= n; i++)
    {
        v.push_back((v[i-1] + v[i-2]) % 1234567);
    }
    return v[n];
}