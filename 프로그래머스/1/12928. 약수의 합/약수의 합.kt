import kotlin.math.sqrt

class Solution {
	fun solution(n: Int): Int {

		val sqrt = sqrt(n.toDouble()).toInt()
		val list = mutableSetOf<Int>()

		for (i in 1..sqrt) {
			if (n % i == 0) {
				list.add(i)
				list.add(n / i)
			}
		}

		return list.sum()
	}
}