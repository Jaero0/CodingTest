#include "bits/stdc++.h"
using namespace std;

int n, r, c;

void Rec(int x, int y, int size, int *count)
{
    if (c == x && r == y)
    {
        cout << *count;
        return;
    }

    if (c < x + size && r < y + size && c >= x && r >= y)
    {
        //1사분면
        Rec(x, y, size / 2, count);
        //2사분면
        Rec(x + size / 2, y, size / 2, count);
        //3사분면
        Rec(x, y + size / 2, size / 2, count);
        //4사분면
        Rec(x + size / 2, y + size / 2, size / 2, count);
    }
    else
    {
        // 없다면 숫자 카운트 -> 정사각형 넓이
        *count += size * size;
    }
}

int main()
{
    cin >> n >> r >> c;
    
    int count = 0;
    Rec(0, 0, pow(2, n), &count);
    return 0;
}
