#include <iostream>
#include <set>

int main()
{
    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);

    int a, b;
    std::cin >> a >> b;

    std::set<int> A, B;

    for (int i = 0; i < a; ++i) {
        int t;
        std::cin >> t;
        A.insert(t);
    }

    for (int i = 0; i < b; ++i) {
        int t;
        std::cin >> t;
        B.insert(t);
    }

    // 대칭 차집합의 크기 = A.size() + B.size() - 2 * 교집합.size()
    int common = 0;
    for (int x : A) {
        if (B.count(x)) {
            ++common;
        }
    }

    int result = A.size() + B.size() - 2 * common;
    std::cout << result;

    return 0;
}
