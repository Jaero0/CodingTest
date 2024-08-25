class Solution {
    fun solution(s: String): Int {
        val numString = arrayOf("zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine")

        val sb = StringBuilder()
        val answerSb = StringBuilder()

        for (c in s) {
            if (c in 'a'..'z') {
                sb.append(c)

                val indexOf = numString.indexOf(sb.toString())

                if (indexOf >= 0) {
                    sb.setLength(0)
                    answerSb.append(indexOf)
                    continue
                }
            }

            if (sb.isEmpty()) {
                answerSb.append(c)
            }
        }

        return answerSb.toString().toInt()
    }
}