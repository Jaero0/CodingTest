class Solution {
    fun solution(num_list: IntArray, n: Int): IntArray {
        var answer: IntArray = IntArray(n)

        for (i in answer.indices) {
            answer[i] = num_list[i]
        }

        return answer
    }
}