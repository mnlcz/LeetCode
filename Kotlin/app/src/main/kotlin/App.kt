import Problems.*

val problems = arrayOf<() -> Unit>(
    ::test1,
    ::test217,
)

fun main() {
    problems.forEach { 
        it() 
        println()
    }
}
