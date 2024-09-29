import Utils.*

fun reverseVowels(s: String): String {
    val st = ArrayDeque(mutableListOf<Char>())
    val vwls = arrayOf('a', 'e', 'i', 'o', 'u')
    val sb = StringBuilder()

    s.forEach { if (it.lowercaseChar() in vwls) st.add(it) }
    s.forEach { sb.append(if (it.lowercaseChar() !in vwls) it else st.removeLast()) }

    return sb.toString()
}

fun test345() {
    println("345) Reverse Vowels of a String")
    val ts =
            mapOf(
                    "IceCreAm" to "AceCreIm",
                    "leetcode" to "leotcede",
            )
    for ((input, expected) in ts) {
        val actual = reverseVowels(input)
        val res = expected == actual
        println("For \"$input\": ${colorResult(res)}")
        if (!res) {
            println("Actual: ${actual}\tExpected: ${expected}")
        }
    }
}
