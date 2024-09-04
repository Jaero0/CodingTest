class Solution {
    fun solution(s: String): Int {
        var answer: Int = 0

        val sChar = s.toCharArray()

        var wait = 0
        for (i in sChar.indices) {
            if (i < wait) {
                continue
            }
            val c = sChar[i]

            var cCount = 0
            var otherCount = 0

            for (j in i until sChar.size) {

                if (sChar[j] == c) {
                    cCount++
                } else {
                    otherCount++
                }

                if (cCount == otherCount || j == sChar.size - 1) {
                    answer++
                    wait = j + 1
                    break
                }
            }
        }

        return answer
    }
}