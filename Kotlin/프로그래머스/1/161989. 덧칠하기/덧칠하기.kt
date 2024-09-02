class Solution {
    fun solution(n: Int, m: Int, section: IntArray): Int {
        var answer: Int = 0

        val arr: Array<Boolean> = Array(n) { true }

        for (i in section) {
            arr[i - 1] = false
        }

        for (i in arr.indices) {
            if (!arr[i]) {
                for (j in i until i + m) {
                    if (j > arr.size - 1) {
                        break;
                    }
                    arr[j] = true
                }
                answer++
            }
        }

        return answer
    }
}