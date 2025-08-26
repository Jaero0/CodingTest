#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N;
    cin >> N;

    vector<int> fruits;

    for (int i = 0; i < N; ++i)
    {
        int t;
        cin >> t;
        fruits.push_back(t);
    }

    map<int, int> fc;

    //map포인터
    int left = 0;
    int maxVal = 0;

    //하나의 포인터는 fruit리스트, 하나의 포인터는 map의 키에
    for (int i = 0; i < N; ++i)
    {
        fc[fruits[i]] += 1;
        int tempLeft = left;

        //2종류 이하 과일개수
        while (fc.size() > 2)
        {
            //fruits배열에서 left인덱스에 해당되는 과일을 map에서 제거
            fc[fruits[left]]--;

            //fc의 키가 fruits[left]이고, 값이 0이면 맵에서 삭제
            if (fc[fruits[left]] == 0)
            {
                fc.erase(fruits[left]);
            }

            //fruits배열에서 다음 인덱스를 찾아 left를 증가
            left++;
        }

        if (i > 0)
        {
            maxVal = std::max(maxVal, fc[fruits[i-1]] + left - tempLeft);
        }
    }

    int sum = 0;
    for (auto pair : fc)
    {
        sum += pair.second;
    }

    maxVal = std::max(maxVal, sum);

    cout << maxVal;

    return 0;
}
