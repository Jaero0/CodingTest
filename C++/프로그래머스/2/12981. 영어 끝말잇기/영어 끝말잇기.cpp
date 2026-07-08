#include <string>
#include <algorithm>
#include <vector>
#include <unordered_set>
using namespace std;

vector<int> solution(int n, vector<string> words)
{
	unordered_set<string> s;

	for (int i = 0; i < words.size(); ++i)
	{
		if (i > 0 && words[i - 1][words[i - 1].size() - 1] != words[i][0])
			return { i % n + 1, i / n + 1 };
        if(s.count(words[i]))
            return { i % n + 1, i / n + 1 };

		s.insert(words[i]);
	}

	return { 0, 0 };
}