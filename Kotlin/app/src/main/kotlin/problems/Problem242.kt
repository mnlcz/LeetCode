import Utils.*

// https://leetcode.com/problems/valid-anagram/description/
fun isAnagram(s: String, t: String): Boolean = s.toCharArray().sorted() == t.toCharArray().sorted()

fun test242() {
    println("242) Valid Anagram:")
    val ts = mapOf(
        Pair("anagram", "nagaram") to true,
        Pair("rat", "car") to false,
    )
    
    for ((input, expected) in ts) {
        val (s, t) = input
        val res = expected == isAnagram(s, t)
        println("For \"$s\" and \"$t\": ${colorResult(res)}")
    }
}
