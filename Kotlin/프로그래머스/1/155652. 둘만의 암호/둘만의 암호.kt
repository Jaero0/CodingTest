class Solution {
    fun solution(s: String, skip: String, index: Int): String {

        val sChar = s.toCharArray()
        val sb = StringBuilder()
        val sSkip = skip.toCharArray().sorted()

        for (i in sChar.indices) {
            var char = sChar[i] //y -> a

            for (j in 1 .. index) {
                char++

                var count = 0

                while (count < sSkip.size) {
                    if (char > 'z') char -= 26

                    if (sSkip[count] == char - 26 || sSkip[count] == char) {
                        char++
                        count = 0
                        continue
                    }

                    count++
                }
            }

            sb.append(char)
        }

        return sb.toString()
    }
}