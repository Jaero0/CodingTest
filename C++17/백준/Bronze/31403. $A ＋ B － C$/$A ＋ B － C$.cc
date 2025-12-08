#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int arr[3];
    cin >> arr[0];
    cin >> arr[1];
    cin >> arr[2];

    int s = arr[0] + arr[1] - arr[2];
    int s1 = std::stoi(std::to_string(arr[0]) + std::to_string(arr[1])) - arr[2];

    cout << s << '\n' << s1;

    return 0;
}