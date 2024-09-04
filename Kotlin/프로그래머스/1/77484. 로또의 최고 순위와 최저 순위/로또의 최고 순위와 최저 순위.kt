class Solution {
    fun solution(lottos: IntArray, win_nums: IntArray): IntArray {
        var answer: IntArray = IntArray(2)

        var maxCount = 0
        for (lotto in lottos) {
            for (winNum in win_nums) {
                if (lotto == winNum) {
                    answer[1]++
                    break
                }
                if (lotto == 0) {
                    maxCount++
                    break
                }
            }
        }


        answer[0] =  answer[1] + maxCount

        for (i in answer.indices) {
            when (answer[i]) {
                6 -> answer[i] = 1
                5 -> answer[i] = 2
                4 -> answer[i] = 3
                3 -> answer[i] = 4
                2 -> answer[i] = 5
                else -> answer[i] = 6
            }
        }

        return answer
    }
}