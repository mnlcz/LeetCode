package Problems

import Utils.*

// https://leetcode.com/problems/two-sum/description/

fun twoSum(
    nums: IntArray,
    target: Int,
): IntArray {
    val diffs = mutableMapOf<Int, Int>()

    for ((i, n) in nums.withIndex()) {
        val diff = target - n

        if (diffs.containsKey(diff)) {
            return intArrayOf(diffs[diff]!!, i)
        } else {
            diffs[n] = i
        }
    }

    return intArrayOf()
}

fun test1() {
    println("1) Two Sum:")
    val ts =
        mapOf(
            Pair(intArrayOf(2, 7, 11, 15), 9) to intArrayOf(0, 1),
            Pair(intArrayOf(3, 2, 4), 6) to intArrayOf(1, 2),
            Pair(intArrayOf(3, 3), 6) to intArrayOf(0, 1),
        )

    for ((input, expected) in ts) {
        val (nums, target) = input
        val res = expected.contentEquals(twoSum(nums, target))
        println("For ${nums.contentToString()} with target $target: ${colorResult(res)}")
    }
}
