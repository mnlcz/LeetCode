import Problems.*

val problems = arrayOf<() -> Unit>(
    ::test1,
)

fun main() {
    problems.forEach { 
        it() 
        println()
    }
}
