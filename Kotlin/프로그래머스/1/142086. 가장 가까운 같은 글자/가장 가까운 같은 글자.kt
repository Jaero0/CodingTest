class Solution {
    fun solution(s: String): IntArray {

        val sLength = s.length
        var isSame = false
        var count = 0
        val answer: IntArray = IntArray(sLength)

        for (i in sLength - 1 downTo  1) {
            val sBase = s[i]

            for (j in i - 1 downTo  0) {
                val sTarget = s[j]
                count++
                
                if (sBase == sTarget) {
                    isSame = true
                    break
                }
            }
            
            answer[i] = if (!isSame) -1 else count
            isSame = false
            count = 0
        }
        
        answer[0] = -1
        return answer
    }
}