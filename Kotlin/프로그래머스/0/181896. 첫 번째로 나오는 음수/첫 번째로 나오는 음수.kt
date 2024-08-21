class Solution {
    fun solution(num_list: IntArray): Int {
        var answer: Int = -1

        for (i in num_list) {
            if (i < 0) {
                answer = num_list.indexOf(i)
                break
            }
        }

        return if (answer >= 0) answer else answer
    }
}