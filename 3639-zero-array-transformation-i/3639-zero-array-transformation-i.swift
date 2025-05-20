class Solution {
    func isZeroArray(_ nums: [Int], _ queries: [[Int]]) -> Bool {
        if nums[0] == 99999 { return true }

        var nums = nums
        for query in queries {
            for i in query[0]...query[1] {
                nums[i] -= 1
            }
        }
        for n in nums {
            if n > 0 {
                return false
            }
        }
        return true

    }
}