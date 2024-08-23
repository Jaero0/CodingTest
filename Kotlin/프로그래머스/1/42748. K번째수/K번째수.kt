class Solution {
    fun solution(array: IntArray, commands: Array<IntArray>): IntArray {
        val answer = IntArray(commands.size)

        for (i in commands.indices) {

            val command2 = commands[i][2]
            val command1 = commands[i][1]
            val command0 = commands[i][0]

            val sliced = array.slice(command0 - 1 until command1)

            answer[i] = sliced.sorted()[command2 - 1]
        }

        return answer
    }
}