import Utils.*

// https://leetcode.com/problems/valid-palindrome/description/
fun isPalindrome(s: String): Boolean {
    if (s.length == 1) return true

    var l = 0
    var r = s.length - 1

    while (l != r && l < r) {
        val chL = s[l]
        val chR = s[r]

        if (!chL.isDigit() && !chL.isLetter()) {
            l++
            continue
        }

        if (!chR.isDigit() && !chR.isLetter()) {
            r--
            continue
        }

        if (chL.isDigit() || chL.isLetter() && chR.isDigit() || chR.isLetter()) {
            if (chL.lowercaseChar() != chR.lowercaseChar()) return false
        }

        l++
        r--
    }

    return true
}

fun test125() {
    println("125) Valid Palindrome:")
    val ts =
        mapOf(
            "A man, a plan, a canal: Panama" to true,
            "race a car" to false,
            " " to true,
        )

    for ((input, expected) in ts) {
        val res = expected == isPalindrome(input)
        println("For $input: ${colorResult(res)}")
    }
}
