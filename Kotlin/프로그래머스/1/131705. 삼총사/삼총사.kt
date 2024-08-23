class Solution {
    fun solution(number: IntArray): Int {
        var answer: Int = 0

        for (i in 0 until number.size - 2) {
            val first = number[i]

            for (j in i + 1 until number.size - 1) {
                val second = number[j]

                for (k in j + 1 until  number.size) {
                    val third = number[k]

                    if (first + second + third == 0) {
                        answer++
                    }
                }
            }
        }

        return answer
    }
}