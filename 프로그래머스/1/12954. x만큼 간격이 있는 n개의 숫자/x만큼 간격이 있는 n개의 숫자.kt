class Solution {
	fun solution(x: Int, n: Int): LongArray {
		var answer = LongArray(n)

		for (i in answer.indices) {
			answer[i] = x * (i+1).toLong()
		}
		return answer
	}
}