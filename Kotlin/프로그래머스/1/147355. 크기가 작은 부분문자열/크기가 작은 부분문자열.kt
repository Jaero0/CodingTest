class Solution {
    fun solution(t: String, p: String): Int {
        var answer: Int = 0

        val pInt = p.toLong()

        for (i in 0..t.length - p.length) {

            val s = t.substring(i..i + p.length-1)

            println(s)
            if (s.toLong() <= pInt) {
                answer++
            }
        }

        return answer
    }
}