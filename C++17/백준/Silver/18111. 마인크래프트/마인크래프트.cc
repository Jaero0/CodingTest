#include "bits/stdc++.h"
using namespace std;

int mc[501][501];

int main()
{
    int N, M, OriginalBlockCount;
    cin >> N >> M >> OriginalBlockCount;

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            int t; cin >> t;
            mc[i][j] = t;
        }
    }

    int minTime = 500000000;
    int maxHeight = 0;
    
    for (int height = 0; height <= 256; ++height)
    {
        int haveToRemove = 0;
        int haveToAdd = 0;
        
        for (int i = 0; i < N; ++i)
        {
            for (int j = 0; j < M; ++j)
            {
                if (mc[i][j] > height)
                {
                    haveToRemove += mc[i][j] - height;
                    continue;
                }

                if (mc[i][j] < height)
                {
                    haveToAdd += height - mc[i][j];
                }
            }
        }

        int time = 500000001;
        if (OriginalBlockCount + haveToRemove >= haveToAdd)
        {
            time = haveToRemove * 2 + haveToAdd * 1;
        }

        if (time <= minTime)
        {
            minTime = time;
            maxHeight = height;
        }
    }

    cout << minTime << " " << maxHeight;
    
    return 0;
}