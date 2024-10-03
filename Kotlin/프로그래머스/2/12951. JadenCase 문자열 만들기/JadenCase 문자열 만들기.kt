class Solution {
    fun solution(s: String): String {
        val sb = StringBuilder()

        val ss = s.split(" ").toMutableList()

        for (i in ss.indices) {
            if (ss[i].isNotBlank() && ss[i][0] - '0' !in 0..9) {
                val first = ss[i][0].uppercase()
                ss[i] = first + ss[i].substring(1 until ss[i].length).lowercase()
                sb.append(ss[i])
            } else {
                sb.append(ss[i].lowercase())
            }
    
            if (i == ss.size - 1) {
                break
            }

            sb.append(" ")
        }

        return sb.toString()
    }
}