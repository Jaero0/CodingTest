import kotlin.math.pow

class Solution {
	fun solution(n: Int): Int {
		var answer: Int = 0

		return if (n % 2 == 0) {
			(n downTo 1 step 2).sumOf() { it.toDouble().pow(2).toInt() }
		} else {
			(n downTo 1 step 2).sum()
		}
	}
}