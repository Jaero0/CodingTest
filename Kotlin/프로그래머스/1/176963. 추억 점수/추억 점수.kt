class Solution {
    fun solution(name: Array<String>, yearning: IntArray, photo: Array<Array<String>>): IntArray {
        var answer: IntArray = IntArray(photo.size)

        for (i in photo.indices) {
            var score = 0

            for (j in photo[i].indices) {
                val index = name.indexOf(photo[i][j])
                if (index >= 0) {
                    score += yearning[index]
                }
            }
            answer[i] = score
        }

        return answer
    }
}