#include <bits/stdc++.h>

#include <algorithm>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int c; cin >> c;

    int total = 0;
    map<int, int> numCountDict;
    vector<int> vec;

    for (int i = 0; i < c; ++i)
    {
        int temp; cin >> temp;

        total += temp;

        if (numCountDict[temp] != 0)
        {
            numCountDict[temp]++;
        }
        else
        {
            numCountDict[temp] = 1;
        }

        vec.push_back(temp);
    }

    sort(vec.begin(), vec.end());

    int bigCount = 0;

    for (pair<const int, int> p : numCountDict)
    {
        bigCount = std::max(p.second, bigCount);
    }

    vector<int> modeVec;

    for (pair<const int, int> p : numCountDict)
    {
        if (bigCount == p.second)
        {
            modeVec.push_back(p.first);
        }
    }

    sort(modeVec.begin(), modeVec.end());

    const double avg = static_cast<double>(total) / c;
    int floored = round(avg);
    int middle = vec[c/2];
    int mode = modeVec.size() > 1 ? modeVec[1] : modeVec[0];
    int range = vec[c - 1] - vec[0];

    cout << (floored == -0 ? 0 : floored)  << "\n" << middle << "\n" << mode << "\n" << range << "\n";
    
    return 0;
    
}
