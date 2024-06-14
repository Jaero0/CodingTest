class Solution {
	fun solution(x: Int): Boolean {
		var answer = true

		val sum = x.toString().toCharArray().sumOf { it.digitToInt() }


		return x % sum == 0
	}
}