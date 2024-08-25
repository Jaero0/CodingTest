class Solution {
    fun solution(food: IntArray): String {
        val sb = StringBuilder()

        for (i in 1 until food.size) {
            if (food[i] > 1) {
                for (j in 1 .. food[i] / 2) {
                    sb.append(i)
                }
            }
        }

        val rev = sb.reversed()



        return sb.append(0).append(rev).toString()
    }
}