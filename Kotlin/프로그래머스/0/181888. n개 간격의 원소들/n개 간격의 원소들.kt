class Solution {
    fun solution(num_list: IntArray, n: Int): IntArray {

        val x = if (num_list.size % n == 0) num_list.size / n
                else num_list.size / n + 1

        println(x)

        val answer: IntArray = IntArray(x)

        var count = 0
        for (i in num_list.indices) {

            if (i % n == 0) {
                answer[count] = num_list[i]
                count++
            }
        }

        return answer
    }
}