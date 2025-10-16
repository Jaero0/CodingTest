#include "bits/stdc++.h"
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N;
    cin >> N;

    vector<int> v(N);

    for (int i = 0; i < N; ++i)
    {
        cin >> v[i];
    }

    stack<int> st;

    //4 5 2 7 9 2
    for (int i = 0; i < N; ++i)
    {
        while (!st.empty() && v[st.top()] < v[i])
        {
            v[st.top()] = v[i];
            st.pop();
        }
        st.push(i);
    }

    while (!st.empty())
    {
        v[st.top()] = -1;
        st.pop();
    }

    for (int i : v) cout << i << " ";

    return 0;
}
