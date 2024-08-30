class Solution {
    fun solution(answers: IntArray): IntArray {
        var answer = mutableListOf<Int>()

        val firstStudent = arrayOf(1, 2, 3, 4, 5)
        val secondStudent = arrayOf(2, 1, 2, 3, 2, 4, 2, 5)
        val thirdStudent = arrayOf(3, 3, 1, 1, 2, 2, 4, 4, 5, 5)

        val answerCount = arrayOf(0, 0, 0)

        for (i in answers.indices) {
            if (answers[i] == firstStudent[i % 5]) {
                answerCount[0]++
            }
            if (answers[i] == secondStudent[i % 8]) {
                answerCount[1]++
            }
            if (answers[i] == thirdStudent[i % 10]) {
                answerCount[2]++
            }
        }

        var max = -1
        for (i in answerCount) {
            if (i > max) {
                max = i
            }
        }

        for (i in answerCount.indices) {
            if (answerCount[i] == max) {
                answer.add(i + 1)
            }
        }

        return answer.toIntArray()
    }
}

fun main() {
    val s = Solution()
    s.solution(intArrayOf(1,2,3,4,5))
}