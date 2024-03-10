import Utils.*

// https://leetcode.com/problems/top-k-frequent-elements/description/
fun topKFrequent(
    nums: IntArray,
    k: Int,
): IntArray {
    val reps = mutableMapOf<Int, Int>()

    for (n in nums) {
        if (reps.containsKey(n)) {
            reps[n] = reps[n]!! + 1
        } else {
            reps[n] = 1
        }
    }

    return reps.toList().sortedByDescending { it.second }.map { it.first }.take(k).toIntArray()
}

fun test347() {
    println("347) Top K Frequent Elements:")
    val ts =
        mapOf(
            Pair(intArrayOf(1, 1, 1, 2, 2, 3), 2) to intArrayOf(1, 2),
            Pair(intArrayOf(1), 1) to intArrayOf(1),
            Pair(intArrayOf(1, 2), 2) to intArrayOf(1, 2),
        )

    for ((input, expected) in ts) {
        val (nums, k) = input
        val res = topKFrequent(nums, k).contentEquals(expected)
        println("For ${nums.contentToString()} with $k: ${colorResult(res)}")
    }
}
