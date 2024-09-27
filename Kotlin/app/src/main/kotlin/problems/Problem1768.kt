import Utils.*

// https://leetcode.com/problems/merge-strings-alternately/
fun mergeAlternately(word1: String, word2: String): String {
    val ls = mutableListOf<Char>()
    val st = ArrayDeque(mutableListOf<Char>())
    val sb = StringBuilder()

    for (ch in word1) {
        ls.add(ch)
        ls.add(' ')
    }

    for (ch in word2) {
        st.addLast(ch)
    }

    for (ch in ls) {
        if (ch != ' ') {
            sb.append(ch)
        } else if (st.isNotEmpty()) {
            sb.append(st.removeFirst())
        }
    }

    while (st.isNotEmpty()) {
        sb.append(st.removeFirst())
    }

    return sb.toString().trim()
}

fun test1768() {
    println("1768) Merge Strings Alternately")
    val ts =
            mapOf(
                    Pair("abc", "pqr") to "apbqcr",
                    Pair("ab", "pqrs") to "apbqrs",
                    Pair("abcd", "pq") to "apbqcd",
            )
    for ((input, expected) in ts) {
        val (w1, w2) = input
        val actual = mergeAlternately(w1, w2)
        val res = expected == actual
        println("For \"$w1\" and \"$w2\": ${colorResult(res)}")
        if (!res) {
            println("Actual: ${actual}\tExpected: ${expected}")
        }
    }
}
