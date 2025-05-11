class Solution {
    func threeConsecutiveOdds(_ arr: [Int]) -> Bool {
        var cons = 0
        for n in arr {
            if n % 2 == 1 {
                cons += 1
                if cons == 3 {
                    return true
                }
            }
            else {
                cons = 0
            }
        }
        return false
    }
}