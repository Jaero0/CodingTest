class Solution {
    fun solution(my_strings: Array<String>, parts: Array<IntArray>): String {

        val sb = StringBuilder()

        for (i in my_strings.indices) {
            sb.append(my_strings[i].substring(parts[i][0]..parts[i][1]))
        }

        return sb.toString()
    }
}