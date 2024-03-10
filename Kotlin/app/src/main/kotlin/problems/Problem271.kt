import Utils.*

// PART OF LEETCODE PREMIUM
// Original here: https://leetcode.com/problems/encode-and-decode-strings
// Tested logic (translated to JS) here: https://neetcode.io/problems/string-encode-and-decode
fun encode(strs: Array<String>): String? {
    return if (strs.isEmpty()) null else strs.joinToString("@@@@@@ENCODED@@@@@@")
}

fun decode(str: String?): Array<String> {
    return str?.split("@@@@@@ENCODED@@@@@@")?.toTypedArray() ?: arrayOf()
}

fun test271() {
    println("271) Encode and Decode Strings:")
    val ts =
        mapOf(
            arrayOf("neet", "code", "love", "you") to arrayOf("neet", "code", "love", "you"),
            arrayOf("we", "say", ":", "yes") to arrayOf("we", "say", ":", "yes"),
        )

    for ((input, expected) in ts) {
        val enc = encode(input)
        val res = decode(enc).contentEquals(expected)
        println("For ${input.contentToString()}: ${colorResult(res)}")
    }
}
