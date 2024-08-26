class Solution {
    fun solution(strings: Array<String>, n: Int): Array<String> {
        var answer = strings.copyOf()

        for (i in answer.indices) {

            answer[i] = answer[i][n] + answer[i]
        }

        answer.sort()

        for (i in answer.indices) {
            answer[i] = answer[i].substring(1)
        }

        return answer
    }
}