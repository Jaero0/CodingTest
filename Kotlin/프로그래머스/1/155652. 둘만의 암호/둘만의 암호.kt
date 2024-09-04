class Solution {
    fun solution(s: String, skip: String, index: Int): String {

        val sChar = s.toCharArray()
        val skipSet = skip.toSet()

        val sb = StringBuilder()

        for (i in sChar.indices) {
            var char = sChar[i] //y -> a

            repeat(index) {
                do {
                    char++
                    println(char)
                    if (char > 'z') char -= 26
                } while (char in skipSet)
            }

            sb.append(char)
        }

        return sb.toString()
    }
}