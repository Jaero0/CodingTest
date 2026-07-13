#include <string>
#include <vector>

using namespace std;

vector<int> solution(int n, long long left, long long right) {
    vector<int> answer;
    answer.reserve(right - left + 1);

    long long bl = left / n;
    int il = left % n;

    long long br = right / n;
    int ir = right % n;

    // 같은 행 안에서 끝나는 경우
    if (bl == br)
    {
        for (int i = il; i <= ir; i++)
        {
            if (i <= bl)
                answer.push_back(bl + 1);
            else
                answer.push_back(i + 1);
        }

        return answer;
    }

    // 첫 번째 행
    for (int i = il; i < n; i++)
    {
        if (i <= bl)
            answer.push_back(bl + 1);
        else
            answer.push_back(i + 1);
    }
    
    bl++;
    
    
    
    // 중간 행
    while(bl < br)
    {
        for (int i = 0; i < n; i++)
        {
            if (i <= bl)
                answer.push_back(bl + 1);
            else
                answer.push_back(i + 1);
        }
        
        bl++;
    }

    

    // 마지막 행
    for (int i = 0; i <= ir; i++)
    {
        if (i <= br)
            answer.push_back(br + 1);
        else
            answer.push_back(i + 1);
    }

    return answer;
}