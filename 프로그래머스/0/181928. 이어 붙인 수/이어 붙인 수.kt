class Solution {
	fun solution(num_list: IntArray): Int {
		var answer: Int = 0

		var sbOdd = StringBuilder()
		var sbEven = StringBuilder()

		for (i in num_list.indices) {
			if (num_list[i] % 2 == 0) sbEven.append(num_list[i]) else sbOdd.append(num_list[i])
		}

		return sbOdd.toString().toInt() + sbEven.toString().toInt()
	}
}