import kotlin.math.*

class Solution {
	fun solution(n: Long): Long {
		val sqrt = sqrt(n.toDouble())

		return if (n.toDouble() % sqrt == 0.0) (sqrt+1).pow(2).toLong() else -1
	}
}