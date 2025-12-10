#include <bits/stdc++.h>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N, T, P = 0; int arr[6];

    cin >> N;
    for (int i = 0; i < 6; ++i)
    {
        cin >> arr[i];
    }
    cin >> T >> P;

    int sumT = 0;
    for (int i = 0; i < 6; ++i)
    {
        sumT += arr[i] % T != 0 ? arr[i] / T + 1 : arr[i] / T;
    }

    cout << sumT << '\n' << N / P << " " << N % P;

    return 0;
}
