import kotlin.math.*

class Solution {
	fun solution(k: Int, d: Int): Long {
		var answer: Long = 0

		var x = 0
		while (x <= d) {
			val maxY = sqrt(d.toDouble() * d.toDouble() - x.toDouble() * x.toDouble()).toInt()
			answer += (maxY / k) + 1
			x += k
		}

		return answer
	}
}