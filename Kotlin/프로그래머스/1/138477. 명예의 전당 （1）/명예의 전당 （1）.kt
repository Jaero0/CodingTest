class Solution {
    fun solution(k: Int, score: IntArray): IntArray {
        var answer: IntArray = IntArray(score.size)

        val hallOfFame = mutableListOf<Int>()

        for (i in score.indices) {

            hallOfFame.add(score[i])
            hallOfFame.sort()
            
            if (i > k - 1) {
                hallOfFame.removeAt(0)
            }
            
            answer[i] = hallOfFame[0]
        }

        return answer
    }
}