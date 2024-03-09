import Utils.*

// https://leetcode.com/problems/contains-duplicate/description/

fun containsDuplicate(nums: IntArray): Boolean {
    val reps = mutableMapOf<Int, Boolean>()

    for (n in nums) {
        if (reps.containsKey(n)) {
            return true
        }
        reps[n] = true
    }

    return false
}

fun test217() {
    println("217) Contains Duplicate:")
    val ts =
        mapOf(
            intArrayOf(1, 2, 3, 1) to true,
            intArrayOf(1, 2, 3, 4) to false,
            intArrayOf(1, 1, 1, 3, 3, 4, 3, 2, 4, 2) to true,
        )

    for ((input, expected) in ts) {
        val res = containsDuplicate(input) == expected
        println("For ${input.contentToString()}: ${colorResult(res)}")
    }
}
