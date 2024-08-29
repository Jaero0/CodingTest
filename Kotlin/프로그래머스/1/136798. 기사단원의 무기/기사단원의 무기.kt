import kotlin.math.sqrt

class Solution {
    fun solution(number: Int, limit: Int, power: Int): Int {
        var answer: Int = 0

        val divisorCount = mutableListOf<Int>()
        divisorCount.add(1)

        for (i in 2 .. number) {
            val sqrt = sqrt(i.toDouble())
            var count = 1

            for (j in 2 .. sqrt.toInt()) {
                if (i % j == 0) {
                    count++
                }
            }

            if (i % sqrt == 0.0) {
                count = count * 2 - 1
            } else {
                count *= 2
            }

            if (count > limit) {
                divisorCount.add(power)
            } else {
                divisorCount.add(count)
            }
        }

        return divisorCount.sumOf { it }
    }
}