class Solution {
    fun solution(arr: Array<String>): String {
        var answer: String = ""

        arr.forEach { it -> answer+=it }

        return answer
    }
}