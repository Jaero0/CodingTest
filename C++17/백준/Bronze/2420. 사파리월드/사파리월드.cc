#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int64_t N,M; cin >> N >> M;

    int64_t i = N - M;

    cout << abs(i);

    return 0;
}
