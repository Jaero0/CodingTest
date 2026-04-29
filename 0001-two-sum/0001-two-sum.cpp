class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        
        vector<pair<int, int>> valInd;

        for(int i = 0; i < nums.size(); i++)
        {
            valInd.push_back(make_pair(nums[i], i));
        }

        sort(valInd.begin(), valInd.end());

        int l = 0;
        int r = nums.size() - 1;

        while(true)
        {
            int sum = valInd[l].first + valInd[r].first;

            if (sum > target)
            {
                r--;
            }
            else if (sum < target)
            {
                l++;
            }
            else
            {
                return vector<int> {valInd[l].second,valInd[r].second};
            }
        }

        return vector<int>();
    }
};