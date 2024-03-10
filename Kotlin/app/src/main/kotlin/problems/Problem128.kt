import Utils.*

// https://leetcode.com/problems/longest-consecutive-sequence/description/
fun longestConsecutive(nums: IntArray): Int {
    if (nums.isEmpty()) return 0

    val set = nums.toSet()
    var longest = 0

    for (n in set) {
        if (set.contains(n - 1)) continue

        var counter = 1
        while (true) {
            if (!set.contains(n + counter)) break

            counter++
        }
        longest = if (counter > longest) counter else longest
    }

    return longest
}

fun test128() {
    println("128) Longest Consecutive Sequence:")
    val ts =
        mapOf(
            intArrayOf(100, 4, 200, 1, 3, 2) to 4,
            intArrayOf(0, 3, 7, 2, 5, 8, 4, 6, 0, 1) to 9,
        )

    for ((input, expected) in ts) {
        val res = longestConsecutive(input) == expected
        println("For ${input.contentToString()}: ${colorResult(res)}")
    }
}
