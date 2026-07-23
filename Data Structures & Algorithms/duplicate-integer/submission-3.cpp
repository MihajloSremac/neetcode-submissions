class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        unordered_set <int> setNums(nums.begin(), nums.end());

        if(setNums.size() < nums.size())
            return true;

        return false;
    }
};