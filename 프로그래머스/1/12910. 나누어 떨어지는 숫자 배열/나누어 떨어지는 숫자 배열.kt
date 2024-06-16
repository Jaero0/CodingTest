class Solution {
	fun solution(arr: IntArray, divisor: Int): IntArray {
		val filter = arr.filter { it % divisor == 0 }.toMutableList()

		return if (filter.isNotEmpty()) {
			filter.sort()
			filter.toIntArray()
		} else {
			filter.add(-1)
			filter.toIntArray()
		}
	}
}
