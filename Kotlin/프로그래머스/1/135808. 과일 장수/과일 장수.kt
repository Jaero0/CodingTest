class Solution {
    fun solution(k: Int, m: Int, score: IntArray): Int {
        var answer: Int = 0

        val sortedDesc = score.sortedDescending().chunked(m)

        for (intList in sortedDesc) {
            if (intList.size == m) {
                val min = intList[m-1]
                answer += min * m
            }
        }

        return answer
    }
}