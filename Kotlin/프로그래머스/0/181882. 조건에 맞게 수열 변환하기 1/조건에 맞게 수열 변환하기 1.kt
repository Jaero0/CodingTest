class Solution {
    fun solution(arr: IntArray): IntArray {
        var answer: IntArray = IntArray(arr.size)

        for (i in arr.indices) {
            val x = arr[i]
            if (x >= 50 && x % 2 == 0) {
                answer[i] = x / 2
            } else if (x < 50 && x % 2 != 0) {
                answer[i] = x * 2
            } else {
                answer[i] = x
            }
        }

        return answer
    }
}