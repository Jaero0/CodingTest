#include "bits/stdc++.h"
using namespace std;

int main()
{
    int N, M; cin >> N >> M;

    vector<vector<int>> sq(N, vector<int>(M));

    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < M; ++j)
        {
            int t; cin >> t;

            sq[i][j] = t;
        }
    }

    int m = 0;

    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < M; ++j)
        {
#pragma region horizontal line
            //가로 4칸 ㅡ자
            if (j <= M - 4)
            {
                int t = sq[i][j] + sq[i][j+1] + sq[i][j+2] + sq[i][j+3];
                m = max(t, m);
            }

#pragma region vertical line
            //세로 4칸 ㅣ자
            if (i <= N - 4)
            {
                int t = sq[i][j] + sq[i+1][j] + sq[i+2][j] + sq[i+3][j];
                m = max(t, m);
            }

#pragma region 2*2 square
            //2*2정사각형 ㅁ자
            if (i <= N - 2 && j <= M - 2)
            {
                int t = sq[i][j] + sq[i+1][j] + sq[i][j+1] + sq[i+1][j+1];
                m = max(t, m);
            }

#pragma region horizontal 3*2 square
            if (i <= N - 2 && j <= M - 3)
            {
                //역 ㄴ자
                int t = sq[i][j+2] + sq[i+1][j] + sq[i+1][j+1] + sq[i+1][j+2];
                m = max(t, m);

                //ㄴ자
                t = sq[i][j] + sq[i+1][j] + sq[i+1][j+1] + sq[i+1][j+2];
                m = max(t, m);

                //역 ㄱ자
                t = sq[i+1][j] + sq[i][j] + sq[i][j+1] + sq[i][j+2];
                m = max(t, m);

                //ㄱ자
                t = sq[i][j] + sq[i][j+1] + sq[i][j+2] + sq[i+1][j+2];
                m = max(t, m);

                //역 ㄱㄴ 지그재그
                t = sq[i+1][j] + sq[i+1][j+1] + sq[i][j+1] + sq[i][j+2];
                m = max(t,m);

                //ㄱㄴ 지그재그
                t = sq[i][j] + sq[i][j+1] + sq[i+1][j+1] + sq[i+1][j+2];
                m = max(t, m);

                //ㅗ자
                t = sq[i+1][j] + sq[i+1][j+1] + sq[i][j+1] + sq[i+1][j+2];
                m = max(t,m);

                //ㅜ자
                t = sq[i][j] + sq[i][j+1] + sq[i+1][j+1] + sq[i][j+2];
                m = max(t,m);
            }

#pragma region vertical 2*3 square
            if (i <= N - 3 && j <= M - 2)
            {
                //세로 ㄴ자
                int t = sq[i][j] + sq[i+1][j] + sq[i+2][j] + sq[i+2][j+1];
                m = max(t, m);

                //역 세로 ㄴ자
                t = sq[i][j+1] + sq[i+1][j+1] + sq[i+2][j+1] + sq[i+2][j];
                m = max(t,m);

                //세로 ㄱ자
                t = sq[i][j] + sq[i][j+1] + sq[i+1][j+1] + sq[i+2][j+1];
                m = max(t,m);

                //역 세로 ㄱ자
                t = sq[i][j+1] + sq[i][j] + sq[i+1][j] + sq[i+2][j];
                m = max(t,m);

                //세로 ㄴㄱ 지그재그
                t = sq[i][j] + sq[i+1][j] + sq[i+1][j+1] + sq[i+2][j+1];
                m = max(t,m);

                //역 세로 ㄴㄱ 지그재그
                t = sq[i][j+1] + sq[i+1][j+1] + sq[i+1][j] + sq[i+2][j];
                m = max(t,m);

                //ㅓ자
                t = sq[i][j+1] + sq[i+1][j+1] + sq[i+1][j] + sq[i+2][j+1];
                m = max(t,m);

                //ㅏ자
                t = sq[i][j] + sq[i+1][j] + sq[i+1][j+1] + sq[i+2][j];
                m = max(t,m);
            }
        }        
    }

    cout << m;
    
    return 0;
}
