package Utils

fun colorResult(result: Boolean): String = if (result) "[\u001B[32mPASS\u001B[0m]" else "[\u001B[31mFAIL\u001B[0m]"
