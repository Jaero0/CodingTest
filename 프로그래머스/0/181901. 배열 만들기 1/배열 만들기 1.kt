class Solution {
	fun solution(n: Int, k: Int): IntArray {

		var arr = IntArray(n / k)
		
		var index = 0
		for (i in 1..n) {
			if (i % k == 0) {
				arr[index] = i
				index++
			}
		}

		return arr
	}
}