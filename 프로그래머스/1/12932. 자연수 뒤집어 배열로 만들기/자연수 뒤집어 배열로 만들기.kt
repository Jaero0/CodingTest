class Solution {
	fun solution(n: Long): IntArray {
		var copy = n
		var answer = IntArray(n.toString().length)

		for (i in answer.indices) {
			answer[i] = (copy % 10).toInt()
			copy /= 10
		}

		return answer
	}
}