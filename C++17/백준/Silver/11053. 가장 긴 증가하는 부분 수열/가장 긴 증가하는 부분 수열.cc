#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N; cin >> N;
    
    vector<int> v;
    for (int i = 0; i < N; ++i)
    {
        int t; cin >> t;
        
        v.push_back(t);
    }

    //배열에서 i번째 인덱스까지 가능한 증가하는 수열의 크기
    vector<int> count(N);
    int m = 0;

    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j <= i; ++j)
        {
            if (v[j] < v[i])
            {
                //자신을 포함한 수열 중 가능한 가장 수열
                count[i] = max(count[j] + 1, count[i]);
            }
        }

        //자신보다 작은 수가 없었다면 자신만 포함하는 수열 길이 1로 초기화
        if (count[i] == 0)
        {
            count[i] = 1;
        }

        m = max(count[i], m);
    }


    cout << m;
    
    return 0;
}