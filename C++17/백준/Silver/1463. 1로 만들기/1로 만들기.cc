#include <bits/stdc++.h>

#include <algorithm>
#include <chrono>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int input;
    cin >> input;
    
    vector<int> numCount;
    //0번 인덱스 무시
    numCount.push_back(-11111111);
    //1부터 연산 사용횟수 최솟값
    numCount.push_back(0);
    numCount.push_back(1);
    numCount.push_back(1);

    for (int i = 4; i < input + 1; ++i)
    {
        int count = 1;
        int min = 999999999;

        if (i % 3 == 0)
        {
            min = std::min(min, numCount[i / 3]);
        }

        if (i % 2 == 0)
        {
            min = std::min(min, numCount[i / 2 ]);
        }

        min = std::min(min, numCount[i - 1]);

        numCount.push_back(count + min);
    }

    cout << numCount[input];

    return 0;
}
