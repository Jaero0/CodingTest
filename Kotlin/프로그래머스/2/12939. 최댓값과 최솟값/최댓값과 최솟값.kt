class Solution {
    fun solution(s: String): String {
        var answer = ""

        var min = Int.MAX_VALUE
        var max = Int.MIN_VALUE
        for (c in s.split(" ")) {
            val cToInt = c.toInt()
            if (cToInt > max) {
                max = cToInt
            }

            if (cToInt < min) {
                min = cToInt
            }
        }

        return "$min $max"
    }
}