class Solution {
    fun solution(s: String, n: Int): String {

        val sb = StringBuilder()

        for (c in s) {
            if (c != ' ') {

                sb.append(appending(c, n))
                continue
            }
            sb.append(" ")
        }

        return sb.toString()
    }

    private fun appending(c: Char, i: Int): Char {

        val newChar = c + i

        if (c in 'A'..'Z') {
            if (newChar > 'Z') {
                return newChar - 26
            }
        }

        if (c in 'a'..'z') {
            if (newChar > 'z') {
                return newChar - 26
            }
        }
        return newChar

    }
}
