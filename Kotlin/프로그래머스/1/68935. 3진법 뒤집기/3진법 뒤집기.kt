import kotlin.math.*

class Solution {
    fun solution(n: Int): Int {
        var answer : Int = 0
        var nn = n

        val sb = StringBuilder()

        while (nn > 0) {
            sb.append(nn % 3)
            println(sb.toString())
            nn /= 3
        }

        val charArr = sb.reverse().toString().toCharArray()

        for (i in charArr.indices) {
            val c = charArr[i].digitToInt()

            answer += c * (3.0.pow(i)).toInt()
        }

        return answer
    }
}