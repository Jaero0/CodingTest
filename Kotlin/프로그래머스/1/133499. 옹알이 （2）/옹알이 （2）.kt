class Solution {
    fun solution(babbling: Array<String>): Int {
        var answer: Int = 0

        val ayayewooma = arrayOf("aya", "ye", "woo", "ma")
        val ayaayayeyewoowoomama = arrayOf("ayaaya", "yeye", "woowoo", "mama")
        val babblingCopy = babbling.copyOf() //"ayaye", "uuu", "yeye", "yemawoo", "ayaayaa"

        for (i in ayayewooma.indices) {
            val aya = ayayewooma[i]
            val ayaaya = ayaayayeyewoowoomama[i]

            for (j in babblingCopy.indices) {
                if (babblingCopy[j].contains(ayaaya)) {
                    babblingCopy[j] = babblingCopy[j].replace(ayaaya, "1")
                } else if (babblingCopy[j].contains(aya)) {
                    babblingCopy[j] = babblingCopy[j].replace(aya, " ")
                }
            }
        }

        return babblingCopy.count { it.isBlank() }
    }
}