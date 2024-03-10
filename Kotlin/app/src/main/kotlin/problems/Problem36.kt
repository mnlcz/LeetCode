import Utils.*

// https://leetcode.com/problems/valid-sudoku/description/
fun isValidSudoku(board: Array<CharArray>): Boolean {
    return false    
}

fun test36() {
    println("36) Valid Sudoku:")
    val ts = mapOf(
        arrayOf(
            charArrayOf('5','3','.','.','7','.','.','.','.'),
            charArrayOf('6','.','.','1','9','5','.','.','.'),
            charArrayOf('.','9','8','.','.','.','.','6','.'),
            charArrayOf('8','.','.','.','6','.','.','.','3'),
            charArrayOf('4','.','.','8','.','3','.','.','1'),
            charArrayOf('7','.','.','.','2','.','.','.','6'),
            charArrayOf('.','6','.','.','.','.','2','8','.'),
            charArrayOf('.','.','.','4','1','9','.','.','5'),
            charArrayOf('.','.','.','.','8','.','.','7','9')
        ) to true,
        arrayOf(
            charArrayOf('8','3','.','.','7','.','.','.','.'),
            charArrayOf('6','.','.','1','9','5','.','.','.'),
            charArrayOf('.','9','8','.','.','.','.','6','.'),
            charArrayOf('8','.','.','.','6','.','.','.','3'),
            charArrayOf('4','.','.','8','.','3','.','.','1'),
            charArrayOf('7','.','.','.','2','.','.','.','6'),
            charArrayOf('.','6','.','.','.','.','2','8','.'),
            charArrayOf('.','.','.','4','1','9','.','.','5'),
            charArrayOf('.','.','.','.','8','.','.','7','9')
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
