class Solution {
    fun solution(num_list: IntArray, n: Int): IntArray {

        val list = num_list.toMutableList()

        for (i in num_list.indices) {
            if (i >= n) {
                break
            }
            println(num_list[i])
            list.removeAt(0)
            list.add(num_list[i])
        }

        return list.toIntArray()
    }
}