#include "bits/stdc++.h"
using namespace std;

int Move(int n, bool isLeft)
{
    if (isLeft == true)
    {
        //0123
        //1230
        return (n % 1000) * 10 + (n / 1000);
    }
    //0123
    //3012
    return (n / 10) + (n % 10) * 1000;
}

pair<int, char> Func(int n, int cases)
{
    switch (cases)
    {
    case 1: n *= 2;
        if (n > 9999) { return make_pair(n % 10000, 'D'); }
        return make_pair(n, 'D');
        break;
    case 2: if (n == 0) { return make_pair(9999, 'S');; }
        return make_pair(n - 1, 'S');;
        break;
    case 3: return make_pair(Move(n, true), 'L');;
        break;
    case 4: return make_pair(Move(n, false), 'R');;
        break;
    }
}

int main()
{
    int N;
    cin >> N;

    for (int i = 0; i < N; ++i)
    {
        int orig, res;
        cin >> orig >> res;

        bool bIsOver = false;
        vector<bool> visited(10000, false);
        vector<int> come(10000, -1);
        vector<char> how(10000);

        queue<int> HaveToVisit;
        HaveToVisit.push(orig);

        while (!HaveToVisit.empty() && bIsOver == false)
        {
            int num = HaveToVisit.front();
            HaveToVisit.pop();

            if (visited[num] == true)
            {
                continue;
            }

            visited[num] = true;

            for (int j = 1; j <= 4; ++j)
            {
                auto ts = Func(num, j);

                int temp = ts.first;
                char c = ts.second;

                if (visited[temp] == true)
                {
                    continue;
                }

                if (come[temp] > -1)
                {
                    continue;
                }

                come[temp] = num;
                how[temp] = c;

                if (temp == res)
                {
                    bIsOver = true;
                    break;
                }

                HaveToVisit.push(temp);
            }
        }

        string way;

        int cur = res;
        while (cur != orig)
        {
            way += how[cur];
            cur = come[cur];
        }

        reverse(way.begin(), way.end());
        cout << way << "\n";
    }

    return 0;
}
