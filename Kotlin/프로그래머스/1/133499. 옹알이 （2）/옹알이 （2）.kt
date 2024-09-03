class Solution {
    fun solution(babbling: Array<String>): Int {
        var answer: Int = 0

        val ayayewooma = arrayOf("aya", "ye", "woo", "ma")
        val babblingCopy = babbling.copyOf() //"ayaye", "uuu", "yeye", "yemawoo", "ayaayaa"

        for (i in ayayewooma.indices) {
            for (j in babblingCopy.indices) {
                if (babblingCopy[j].contains(ayayewooma[i])) {
                    babblingCopy[j] = babblingCopy[j].replace(ayayewooma[i], ("$i "))
                }
            }
        }



        for (s in babblingCopy) {
            if (s[0] in '0'..'9') {
                val trimLastS = s.trimEnd()
                val splited = trimLastS.split(" ")

                var isSame = false
                var temp = ""

                for (s1 in splited) {
                    if (s1 == temp || s1[0] in 'a' .. 'z') {
                        isSame = true
                        break
                    }
                    temp = s1
                }

                if (!isSame) {
                    answer++
                }
            }
        }

        return answer
    }
}