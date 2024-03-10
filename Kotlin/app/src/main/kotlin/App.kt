import Problems.*

val problems =
    arrayOf<() -> Unit>(
        ::test1,
        ::test36,
        // ::test49,
        // ::test217,
        // ::test238,
        // ::test242,
        // ::test347,
    )

fun main() {
    problems.forEach {
        it()
        println()
    }
}
