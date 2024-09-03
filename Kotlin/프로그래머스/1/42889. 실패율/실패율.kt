class Solution {
    fun solution(N: Int, stages: IntArray): IntArray {
        var answer = mutableListOf<Int>()

        val modo = IntArray(N)

        for (stage in stages) {
            if (stage == N + 1) {
                continue
            }
            modo[stage - 1]++
        }

        val failure = mutableListOf<Double>()
        var people = stages.size.toDouble()

        for (i in modo.indices) {
            if (people != 0.0) {
                failure.add(modo[i] / people)
                people -= modo[i]
            } else {
                failure.add(0.0)
            }

        }

        val sortDescFailure = failure.sortedDescending()

        for (d in sortDescFailure) {
            val ind = failure.indexOf(d)
            answer.add(ind + 1)
            failure[ind] = -1.0
        }

        return answer.toIntArray()
    }
}