class Solution {
	fun solution(n: Int): Int {
		var copyN = n
		var answer = 0

		while (copyN > 0) {
			answer += copyN % 10
			copyN /= 10
		}

		return answer
	}
}