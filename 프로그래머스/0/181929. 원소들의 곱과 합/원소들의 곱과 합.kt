import kotlin.math.*

class Solution {
	fun solution(num_list: IntArray): Int {
		var answer: Int = 0

		var multi = 1

		for (num in num_list) {
			answer += num
			multi *= num
		}

		return if ((answer.toDouble()).pow(2) > multi) 1 else 0
	}
}