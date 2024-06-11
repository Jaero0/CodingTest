class Solution {
	fun solution(num_list: IntArray): IntArray {
		var answer: IntArray = IntArray(num_list.size + 1)

		for (i in num_list.indices) {
			answer[i] = num_list[i]

			if (i == num_list.size - 1) {
				if (num_list[i] <= num_list[i - 1]) {
					answer[i + 1] = num_list[i] * 2
					break
				} else {
					answer[i + 1] = num_list[i] - num_list[i - 1]
					break
				}
			}
		}

		return answer
	}
}