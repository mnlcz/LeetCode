import Utils.*

// https://leetcode.com/problems/product-of-array-except-self/description/
fun productExceptSelf(nums: IntArray): IntArray {
    val outArr = mutableListOf<Int>()
    val rev = nums.reversedArray()
    val left = mutableListOf<Int>(1)
    val right = mutableListOf<Int>(1)
    var prevI = -1
    var prevD = -1

    for ((i, _) in nums.withIndex()) {
        val ni = nums[i]
        val nd = rev[i]

        if (i == 0) {
            prevI = ni
            prevD = nd
            continue
        }

        left.add(prevI * left[i - 1])
        right.add(prevD * right[i - 1])
        prevI = ni
        prevD = nd
    }

    right.reverse()

    for ((i, n) in left.withIndex()) {
        outArr.add(n * right[i])
    }

    return outArr.toIntArray()
}

fun test238() {
    println("238) Product of Array Except Self:")
    val ts =
        mapOf(
            intArrayOf(1, 2, 3, 4) to intArrayOf(24, 12, 8, 6),
            intArrayOf(-1, 1, 0, -3, 3) to intArrayOf(0, 0, 9, 0, 0),
        )

    for ((input, expected) in ts) {
        val res = productExceptSelf(input).contentEquals(expected)
        println("For ${input.contentToString()}: ${colorResult(res)}")
    }
}
