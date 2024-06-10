class Solution {
	fun solution(n: Int, k: Int): IntArray {

		val arr = IntArray(n / k)

		var index = 0
		for (i in k..n step k) {

			arr[index] = i
			index++

		}

		return arr
	}
}
