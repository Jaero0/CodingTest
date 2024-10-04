class Solution {
    fun solution(s: String): IntArray {

        val sb = StringBuilder(s)
        val regex = "0".toRegex()
        var int = 0
        var count = 0
        var binaryCount = 0

        while (true) {

            sb.forEach { if (it == '0') count++ }
            int = sb.replace(regex, "").length
            binaryCount++

            if (int == 1) {
                break
            }

            sb.setLength(0)

            while (int != 0) {

                sb.append(int % 2)
                int /= 2
            }
            sb.reverse()

        }

        return intArrayOf(binaryCount, count)
    }
}