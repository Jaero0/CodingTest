#include <bits/stdc++.h>
using namespace std;

// 접미사 배열 생성
vector<int> buildSuffixArray(const string& s) {
    int n = s.size(), k = 1;
    vector<int> sa(n), rank(n), tmp(n);

    for (int i = 0; i < n; i++) {
        sa[i] = i;
        rank[i] = s[i];
    }

    auto cmp = [&](int i, int j) {
        if (rank[i] != rank[j]) return rank[i] < rank[j];
        int ri = (i + k < n) ? rank[i + k] : -1;
        int rj = (j + k < n) ? rank[j + k] : -1;
        return ri < rj;
    };

    for (; k < n; k <<= 1) {
        sort(sa.begin(), sa.end(), cmp);
        tmp[sa[0]] = 0;
        for (int i = 1; i < n; i++) {
            tmp[sa[i]] = tmp[sa[i - 1]] + (cmp(sa[i - 1], sa[i]) ? 1 : 0);
        }
        rank = tmp;
    }

    return sa;
}

// LCP 배열 생성
vector<int> buildLCP(const string& s, const vector<int>& sa) {
    int n = s.size();
    vector<int> rank(n), lcp(n);
    for (int i = 0; i < n; i++) rank[sa[i]] = i;

    int h = 0;
    for (int i = 0; i < n; i++) {
        if (rank[i] > 0) {
            int j = sa[rank[i] - 1];
            while (i + h < n && j + h < n && s[i + h] == s[j + h]) h++;
            lcp[rank[i]] = h;
            if (h > 0) h--;
        }
    }
    return lcp;
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    string s;
    cin >> s;

    vector<int> sa = buildSuffixArray(s);
    vector<int> lcp = buildLCP(s, sa);

    int n = s.size();
    long long total = 0;

    for (int i = 0; i < n; i++) {
        int suffixLen = n - sa[i];
        int lcpLen = (i == 0) ? 0 : lcp[i];
        total += (suffixLen - lcpLen);
    }

    cout << total << "\n";
    return 0;
}