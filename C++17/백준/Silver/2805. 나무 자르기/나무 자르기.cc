#include "bits/stdc++.h"
using namespace std;

bool CanMakeTree(vector<int> &v, int treeCount, int cutSize)
{
    int64_t count = 0;
    for (int i : v)
    {
        count += i - cutSize > 0 ? i - cutSize : 0;
    }

    //나무가 더 많이 만들어지면
    if (count >= treeCount)
    {
        return true;
    }

    //나무가 적게 만들어지면
    return false;
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N, M; cin >> N >> M;

    vector<int> trees;

    int maxLength = 0;
    for (int i = 0; i < N; ++i)
    {
        int t; cin >> t;\
        maxLength = std::max(maxLength, t);
        trees.push_back(t);
    }

    int lowLength = 0;
    int result = 0;

    while (lowLength <= maxLength)
    {
        int half = (lowLength + maxLength) / 2;

        bool can = CanMakeTree(trees, M, half);

        //자르는 크기는 충분, 자르는 크기가 최대가 될때까지 half값 증가를 위해 low값 증가
        if (can == true)
        {
            result = half;
            lowLength = half + 1;
        }
        //자르는 크기가 너무 크므로 half값 감소를 위해 max줄이기
        else
        {
            maxLength = half - 1;
        }
    }

    cout << result;
    
    return 0;
}
