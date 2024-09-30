import Problems.*

val problems =
    arrayOf<() -> Unit>(
        // ::test1,
        // ::test36,
        // ::test49,
        // ::test125,
        // ::test128,
        // ::test217,
        // ::test238,
        // ::test242,
        // ::test271,
        ::test283,
        // ::test345,
        // ::test347,
        // ::test1768,
    )

fun main() {
    problems.forEach {
        it()
        println()
    }
}
