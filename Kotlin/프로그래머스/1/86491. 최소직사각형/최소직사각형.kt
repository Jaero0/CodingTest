class Solution {
    fun solution(sizes: Array<IntArray>): Int {
        
        var maxX = sizes[0][0]
        var maxY = sizes[0][1]

        if (maxX < maxY) {
            val temp = maxX
            maxX = maxY
            maxY = temp
        }

        for (i in sizes.indices) {

            val x = sizes[i][0]
            val y = sizes[i][1]

            if (y > x) {
                if (maxX < y) {
                    maxX = y
                    println("change maxX = $maxX")
                }
                if (maxY < x) {
                    maxY = x
                    println("change maxY = $maxY")
                }
                continue
            }

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