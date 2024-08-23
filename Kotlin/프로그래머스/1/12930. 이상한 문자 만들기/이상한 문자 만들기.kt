class Solution {
    fun solution(s: String): String {

        val arr = s.split(" ")

        val sb = StringBuilder()

        for (s1 in arr) {
            for (c in s1.indices) {

                var char = s1[c]

                if (c % 2 == 0) {
                    sb.append(char.uppercaseChar())
                    continue
                }
                sb.append(char.lowercaseChar())
            }
            sb.append(" ")
        }

        return sb.replace(sb.length - 1, sb.length, "").toString()
    }
}