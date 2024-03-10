import Problems.*

val problems =
    arrayOf<() -> Unit>(
        ::test1,
        ::test49,
        ::test217,
        ::test242,
        ::test347,
    )

fun main() {
    problems.forEach {
        it()
        println()
    }
}
