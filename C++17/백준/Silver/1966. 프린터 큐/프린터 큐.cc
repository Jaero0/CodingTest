#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int c;
    cin >> c;

    //문서개수, 언제 출력되는지 알고싶은 문서의 index
    int docCount, docInx;

    for (int i = 0; i < c; ++i)
    {
        cin >> docCount >> docInx;

        //문서 우선순위(수 높으면 우선순위 높음)
        vector<pair<string, int>> priorities;

        for (int j = 0; j < docCount; ++j)
        {
            int second;
            cin >> second;
            string first = "A" + to_string(j);

            priorities.push_back(make_pair(first, second));
        }

        pair<string, int> desire = priorities[docInx];

        
        
        int deleteCount = 0;

        for (int j = 0; j < docCount; ++j)
        {
            bool isBiggerDetected = false;
            pair<string, int> p = priorities[j];
            
            for (int k = 0; k < docCount; ++k)
            {
                if (p.second < priorities[k].second)
                {
                    priorities.erase(priorities.begin());
                    priorities.push_back(p);
                    p = priorities[0];
                    isBiggerDetected = true;
                    break;
                }
            }

            if (isBiggerDetected == false)
            {
                if (desire.first == p.first)
                {
                    cout << deleteCount + 1 << "\n";
                    break;
                }

                priorities.erase(priorities.begin());
                deleteCount++;
                docCount--;
                j = -1;
                
            }
            else
            {
                j = -1;
            }
        }
        
    }

    return 0;
}
