class Solution {
	fun solution(start_num: Int, end_num: Int): IntArray {
		var answer: IntArray = IntArray(end_num - start_num + 1)

		for ((index, i) in (start_num..end_num).withIndex()) {
			answer[index] = i
		}

		return answer
	}
}