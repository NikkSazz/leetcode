class Solution {
    func buildArray(_ nums: [Int]) -> [Int] {

        var ans: [Int] = []

        for i in 0..<nums.count {
            ans.append(nums[nums[i]])
        }

        return ans
    }
}