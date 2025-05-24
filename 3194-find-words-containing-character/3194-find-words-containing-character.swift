class Solution {
    func findWordsContaining(_ words: [String], _ x: Character) -> [Int] {
        var ans: [Int] = []
        for (i, w) in words.enumerated() {
            if w.contains(x) {
                ans.append(i)
            }
        }
        return ans
    }
}