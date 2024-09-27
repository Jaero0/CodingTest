import java.util.Stack

class Solution {
    fun solution(board: Array<IntArray>, moves: IntArray): Int {
        var answer = 0

        val stack = Stack<Int>()
        val bCopy = board.clone()

        for (i in moves) {
            for (j in bCopy.indices) {
                if (bCopy[j][i - 1] > 0) {
                    stack.push(bCopy[j][i - 1])
                    bCopy[j][i - 1] = 0
                    break
                }
            }
            if (stack.size > 1) {
                val size = stack.size

                if (stack[size - 1] == stack[size - 2]) {
                    answer += 2
                    stack.pop()
                    stack.pop()
                }
            }
        }
        return answer
    }
}