class Solution {
    fun solution(num_list: IntArray, n: Int): IntArray {

        val list = num_list.toMutableList()

        for (i in num_list.indices) {
            if (i == n - 1) {
                break
            }
            list.removeAt(0)
        }

        return list.toIntArray()
    }
}