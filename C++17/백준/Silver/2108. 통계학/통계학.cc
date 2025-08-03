#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int c;
    cin >> c;

    vector<int> vec(c);
    map<int, int> numCount;
    int total = 0;

    for (int i = 0; i < c; ++i)
    {
        cin >> vec[i];
        total += vec[i];
        ++numCount[vec[i]];
    }

    sort(vec.begin(), vec.end());

    // 평균 (0과 -0 구분 처리)
    int avg = round((double)total / c);
    if (avg == -0) avg = 0;

    // 중앙값
    int median = vec[c / 2];

    // 최빈값 계산
    int maxFreq = 0;
    for (const auto& p : numCount)
        maxFreq = max(maxFreq, p.second);

    vector<int> modes;
    for (const auto& p : numCount)
        if (p.second == maxFreq)
            modes.push_back(p.first);

    sort(modes.begin(), modes.end());
    int mode = (modes.size() > 1) ? modes[1] : modes[0];

    // 범위
    int range = vec.back() - vec.front();

    // 출력
    cout << avg << "\n" << median << "\n" << mode << "\n" << range << "\n";

    return 0;
}
