class Solution {
    func setZeroes(_ matrix: inout [[Int]]) {
        
        var positions: [(row: Int, col: Int)] = []
        
        for (r, row) in matrix.enumerated() {
            for (c, col) in row.enumerated() {
                if col == 0 {
                    positions.append((r, c))
                }
            }
        }
        
        for t in positions {
            setAllAt(row: t.row, col: t.col, of: &matrix)
        }

    }

    func setAllAt(row: Int, col: Int, of matrix: inout [[Int]]) {
        
        for i in 0..<matrix[row].count {
            matrix[row][i] = 0
        }
        
        for i in 0..<matrix.count {
            matrix[i][col] = 0
        }

    }
}