import Utils.*

// https://leetcode.com/problems/move-zeroes/description/
fun moveZeroes(nums: IntArray): Unit {
    var left = 0

    for (right in nums.indices) {
        if (nums[right] != 0) {
            val aux = nums[left]
            nums[left] = nums[right]
            nums[right] = aux
            left++
        }
    }
}

fun test283(): Unit {
    println("283) Move Zeroes")
    val ts =
            mapOf(
                    intArrayOf(0, 1, 0, 3, 12) to intArrayOf(1, 3, 12, 0, 0),
                    intArrayOf(0) to intArrayOf(0),
                    intArrayOf(1, 0, 1) to intArrayOf(1, 1, 0),
                    intArrayOf(2, 1) to intArrayOf(2, 1),
                    intArrayOf(4, 2, 4, 0, 0, 3, 0, 5, 1, 0) to
                            intArrayOf(4, 2, 4, 3, 5, 1, 0, 0, 0, 0)
            )
    for ((input, expected) in ts) {
        val og = input.contentToString()
        moveZeroes(input)
        val actual = input
        val res = expected contentEquals actual
        println("For \"${og}\": ${colorResult(res)}")
        if (!res) {
            println("Actual: ${actual.contentToString()}\tExpected: ${expected.contentToString()}")
            break
        }
    }
}
