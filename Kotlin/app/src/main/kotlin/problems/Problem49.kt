import Utils.*

// https://leetcode.com/problems/group-anagrams/description/
fun groupAnagrams(strs: Array<String>): List<List<String>> {
    val groups = mutableMapOf<String, MutableList<String>>()

    for (str in strs) {
        val sorted = str.toCharArray().sorted().joinToString("")

        if (groups.containsKey(sorted)) {
            groups[sorted]!!.add(str)
        } else {
            groups[sorted] = mutableListOf(str)
        }
    }

    return groups.values.toList()
}

fun test49() {
    println("49) Group Anagrams:")
    val ts =
        mapOf(
            arrayOf("eat", "tea", "tan", "ate", "nat", "bat") to listOf(listOf("bat"), listOf("nat", "tan"), listOf("ate", "eat", "tea")),
            arrayOf("") to listOf(listOf("")),
            arrayOf("a") to listOf(listOf("a")),
        )

    for ((input, expected) in ts) {
        val actual = groupAnagrams(input)
        val res = compare(expected, actual)
        println("For ${input.contentToString()}: ${colorResult(res)}")
    }
}

private fun compare(
    l1: List<List<String>>,
    l2: List<List<String>>,
): Boolean {
    if (l1.size != l2.size) return false

    val s1 = l1.sortedBy { it.size }
    val s2 = l2.sortedBy { it.size }

    for (i in s1.indices) {
        if (s1[i].size != s2[i].size || !s1[i].containsAll(s2[i])) return false
    }

    return true
}
