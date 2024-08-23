import kotlin.math.*

class Solution {
    fun solution(sizes: Array<IntArray>): Int {
        
        var maxX = max(sizes[0][0], sizes[0][1])
        var maxY = min(sizes[0][0], sizes[0][1])

        for (i in sizes.indices) {

            val x = max(sizes[i][0], sizes[i][1])
            val y = min(sizes[i][0], sizes[i][1])

                if (maxX < x) {
                    maxX = x
                    println("change maxX = $maxX")
                }
                if (maxY < y) {
                    maxY = y
                    println("change maxY = $maxY")
                }
            }
        

        return maxX * maxY
    }
}