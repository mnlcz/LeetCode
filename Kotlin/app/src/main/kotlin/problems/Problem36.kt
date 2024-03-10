import Utils.*

// https://leetcode.com/problems/valid-sudoku/description/
fun isValidSudoku(board: Array<CharArray>): Boolean {
    val set = mutableSetOf<Char>()
    
    // rows
    for (r in board) {
        set.clear()
        for (ch in r) {
            if (ch != '.' && set.contains(ch)) return false
            set.add(ch)
        }
    }

    // cols
    for (i in 0 until board.size) {
        set.clear()  
        for (j in 0 until board.size) {
            val item = board[j][i]
            if (item != '.' && set.contains(item)) return false
            set.add(item)
        }
    }

    // 3x3
    for (i in 0 until board.size step 3) {
        for (j in 0 until board.size step 3) {
            set.clear()
            for (i2 in 0 until 3) {
                for (j2 in 0 until 3) {
                    val item = board[i + i2][j + j2]
                    if (item != '.' && set.contains(item)) return false
                    set.add(item)
                }
            }
        }
    }
    
    return true
}

fun test36() {
    println("36) Valid Sudoku:")
    val ts =
        mapOf(
            arrayOf(
                charArrayOf('5', '3', '.', '.', '7', '.', '.', '.', '.'),
                charArrayOf('6', '.', '.', '1', '9', '5', '.', '.', '.'),
                charArrayOf('.', '9', '8', '.', '.', '.', '.', '6', '.'),
                charArrayOf('8', '.', '.', '.', '6', '.', '.', '.', '3'),
                charArrayOf('4', '.', '.', '8', '.', '3', '.', '.', '1'),
                charArrayOf('7', '.', '.', '.', '2', '.', '.', '.', '6'),
                charArrayOf('.', '6', '.', '.', '.', '.', '2', '8', '.'),
                charArrayOf('.', '.', '.', '4', '1', '9', '.', '.', '5'),
                charArrayOf('.', '.', '.', '.', '8', '.', '.', '7', '9'),
            ) to true,
            arrayOf(
                charArrayOf('8', '3', '.', '.', '7', '.', '.', '.', '.'),
                charArrayOf('6', '.', '.', '1', '9', '5', '.', '.', '.'),
                charArrayOf('.', '9', '8', '.', '.', '.', '.', '6', '.'),
                charArrayOf('8', '.', '.', '.', '6', '.', '.', '.', '3'),
                charArrayOf('4', '.', '.', '8', '.', '3', '.', '.', '1'),
                charArrayOf('7', '.', '.', '.', '2', '.', '.', '.', '6'),
                charArrayOf('.', '6', '.', '.', '.', '.', '2', '8', '.'),
                charArrayOf('.', '.', '.', '4', '1', '9', '.', '.', '5'),
                charArrayOf('.', '.', '.', '.', '8', '.', '.', '7', '9'),
            ) to false,
        )

    for ((input, expected) in ts) {
        val res = isValidSudoku(input) == expected
        println("${colorResult(res)} for:")
        showGrid(input)
    }
}

private fun showGrid(grid: Array<CharArray>) {
    for (l in grid) {
        for (c in l) {
            print("$c ")
        }
        println()
    }
}
